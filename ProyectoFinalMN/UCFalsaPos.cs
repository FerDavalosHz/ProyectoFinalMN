using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejador;

namespace ProyectoFinalMN
{
    public partial class UCFalsaPos : UserControl
    {
        ManejadorFalsaPosicion MFP;
        ManejadorGrafica mg;
        ManejadorQIA mQUIA;
        double a;
        double b;
        public UCFalsaPos()
        {
            InitializeComponent();
            MFP = new ManejadorFalsaPosicion();
            mg = new ManejadorGrafica();
            mQUIA = new ManejadorQIA();
            mg.InicializarGrafica(pGrafica);

        }



        private void BtnCalcular_Click(object sender, EventArgs e)
        {
           

        }

        private void BtnGraficar_Click(object sender, EventArgs e)
        {
            mg.Graficar(FrmPrincipal.FX, a, b, double.Parse(TxtRaiz.Text), DtgDatos, "xm");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rIA_TextChanged(object sender, EventArgs e)
        {

        }

        private void UCFalsaPos_Load(object sender, EventArgs e)
        {

        }

        bool RevisarGB()
        {
            foreach (Control item in gbParametros.Controls)
            {
                if (item is TextBox txt)
                {
                    if (string.IsNullOrWhiteSpace(txt.Text))
                    {

                        return false;
                    }
                }
            }


            return true;
        }

        private void BtnCalcular_Click_1(object sender, EventArgs e)
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

            MFP.CalcularFalsaPosicion(FrmPrincipal.FX, a, b, tol, iter, DtgDatos, TxtRaiz);

            if (TxtRaiz.Text == "Error") return;

            Estilos.ResaltarUltimaFila(DtgDatos);
            if (double.TryParse(TxtRaiz.Text, out double raiz))
                mg.Graficar(FrmPrincipal.FX, a, b, raiz, DtgDatos, "xm");
            rIA.Text = "Generando problema...";
            mQUIA.GenerarProblemaPro(
                rIA, FrmPrincipal.FX, "Falsa posicion",
                $"a={TxtInferior.Text}, b={TxtSuperior.Text}, " +
                $"tol={TxtTolerancia.Text}, iter={TxtIter.Text}, " +
                $"raiz={TxtRaiz.Text}");
        }
    }
}
