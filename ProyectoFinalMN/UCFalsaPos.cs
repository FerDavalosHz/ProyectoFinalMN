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

     

        private void BtnCalcular_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(FrmPrincipal.FX);

            double a = double.Parse(TxtInferior.Text);
            double b = double.Parse(TxtSuperior.Text);
            double tol = double.Parse(TxtTolerancia.Text);
            int iter = int.Parse(TxtIter.Text);

            ManejadorFuncion mf = new ManejadorFuncion();

            double fa = mf.Evaluar(FrmPrincipal.FX, a);
            double fb = mf.Evaluar(FrmPrincipal.FX, b);

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
                    MessageBoxIcon.Warning
                );
                return;
            }

            MFP.CalcularFalsaPosicion(
                FrmPrincipal.FX,
                a,
                b,
                tol,
                iter,
                DtgDatos,
                TxtRaiz
            );

            Estilos.ResaltarUltimaFila(DtgDatos);
          
            rIA.Text = "Generando problema...";
            mQUIA.GenerarProblemaPro(
              rIA, FrmPrincipal.FX, "Falsa posicion", $"a={TxtInferior.Text}, b={TxtSuperior.Text}, tol={TxtTolerancia.Text}, iter={TxtIter.Text}, raiz= {TxtRaiz}"
            );
            mg.Graficar(FrmPrincipal.FX, a, b, double.Parse(TxtRaiz.Text), DtgDatos, "xm");
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
    }
}
