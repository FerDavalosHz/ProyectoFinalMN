using System;
using System.Drawing;
using System.Windows.Forms;
using Manejador;

namespace ProyectoFinalMN
{
    public partial class UCBiseccion : UserControl
    {
        ManejadorBiseccion MB;
        ManejadorGrafica mg;
        ManejadorQIA mQUIA;
        double a;
        double b;

        public UCBiseccion()
        {
            InitializeComponent();
            MB = new ManejadorBiseccion();
            mg = new ManejadorGrafica();
            mg.InicializarGrafica(pGrafica);
            mQUIA = new ManejadorQIA();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (!RevisarGB())
            {
                MessageBox.Show("Hay campos vacíos, debe llenar todos para continuar", "Error: Campos vacíos");
                return;
            }

            if (!double.TryParse(TxtInferior.Text, out a) ||
                !double.TryParse(TxtSuperior.Text, out b) ||
                !double.TryParse(TxtTolerancia.Text, out double tol) ||
                !int.TryParse(TxtIter.Text, out int iter))
            {
                MessageBox.Show("Uno o más valores no son números válidos.", "Error: Valor inválido");
                return;
            }
            ManejadorFuncion mf = new ManejadorFuncion();
            if (!mf.TryProcesar(FrmPrincipal.FX, out string expresion, out string errorProceso))
            {
                MessageBox.Show(errorProceso, "Error en la función");
                return;
            }

            try
            {
                double fa = mf.Evaluar(expresion, a);
                double fb = mf.Evaluar(expresion, b);

                if (fa * fb > 0)
                {
                    MessageBox.Show(
                        $"Intervalo inválido.\n\n" +
                        $"Al evaluar la función:\n" +
                        $"f(a) = f({a}) = {fa}\n" +
                        $"f(b) = f({b}) = {fb}\n\n" +
                        $"Ambos valores tienen el mismo signo, por lo que no se garantiza la existencia de una raíz en el intervalo.\n" +
                        $"Intenta con valores de 'a' y 'b' donde la función cambie de signo.",
                        "Error de intervalo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al evaluar en los extremos:\n" + ex.Message, "Error");
                return;
            }

            MB.CalcularBiseccion(FrmPrincipal.FX, a, b, tol, iter, DtgDatos, TxtRaiz);

            if (TxtRaiz.Text == "Error") return;

            Estilos.ResaltarUltimaFila(DtgDatos);
            BtnProblema.PerformClick();

            if (double.TryParse(TxtRaiz.Text, out double raiz))
                mg.Graficar(FrmPrincipal.FX, a, b, raiz, DtgDatos, "xm");
        }

        private void BtnProblema_Click(object sender, EventArgs e)
        {
            rIA.Text = "Generando problema...";
            mQUIA.GenerarProblemaPro(
                rIA, FrmPrincipal.FX, "Bisección",
                $"a={TxtInferior.Text}, b={TxtSuperior.Text}, " +
                $"tol={TxtTolerancia.Text}, iter={TxtIter.Text}, " +
                $"raiz={TxtRaiz.Text}");
        }

        private void UCBiseccion_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1268, 673);
            Estilos.BotonRedondeado(BtnCalcular, 15);
            Estilos.EnchularGrid(DtgDatos);
        }

        bool RevisarGB()
        {
            foreach (Control item in gbParametros.Controls)
            {
                if (item is TextBox txt && string.IsNullOrWhiteSpace(txt.Text))
                    return false;
            }
            return true;
        }

        private void BtnGraficar_Click(object sender, EventArgs e) { }
        private void las_Click(object sender, EventArgs e) { }
    }
}