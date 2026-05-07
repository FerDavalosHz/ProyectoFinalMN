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
    public partial class UCNewtonRaphson : UserControl
    {

        ManejadorNewtonRaphson Mr;
        ManejadorGrafica mg;
        ManejadorQIA mQUIA;
        double a;

        public UCNewtonRaphson()
        {
            InitializeComponent();
            Mr = new ManejadorNewtonRaphson();
            mQUIA = new ManejadorQIA();
            mg = new ManejadorGrafica();
            mg.InicializarGrafica(pGrafica);
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (!RevisarGB())
            {
                MessageBox.Show("Hay campos vacíos, debe llenar todos para continuar", "Error: Campos vacíos");
                return;
            }

            if (!double.TryParse(TxtX0.Text, out a) ||
                !int.TryParse(TxtTolerancia.Text, out int tol) ||
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


            Mr.CalcularNewtonRaphson(FrmPrincipal.FX, a, tol, iter, DtgDatos, TxtRaiz);

            if (TxtRaiz.Text == "Error") return;

            Estilos.ResaltarUltimaFila(DtgDatos);
            if (double.TryParse(TxtRaiz.Text, out double raiz))
                mg.Graficar(FrmPrincipal.FX, a - 3, a + 3, raiz, DtgDatos, "xk");
            rIA.Text = "Generando problema...";
            mQUIA.GenerarProblemaPro(
                rIA, FrmPrincipal.FX, "Newton Raphson",
                $"Xo={TxtX0.Text}" +
                $"tol={TxtTolerancia.Text} %, iter={TxtIter.Text}, " +
                $"raiz={TxtRaiz.Text}");

        }

        private void BtnGraficar_Click(object sender, EventArgs e)
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


        private void UCNewtonRaphson_Load(object sender, EventArgs e)
        {

        }
    }
}
