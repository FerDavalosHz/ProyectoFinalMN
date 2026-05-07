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
    public partial class UCSecante : UserControl
    {
        ManejadorSecante MS;
        ManejadorGrafica mg;
        ManejadorQIA mQUIA;
        double a;
        double b;
        public UCSecante()
        {
            InitializeComponent();
            MS = new ManejadorSecante();
            mg = new ManejadorGrafica();
            mQUIA = new ManejadorQIA();
         
            mg.InicializarGrafica(pGrafica);
        }

     

        private void BtnCalcular_Click_1(object sender, EventArgs e)
        {
          

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


        private void BtnCalc_Click(object sender, EventArgs e)
        {
            if (!RevisarGB())
            {
                MessageBox.Show("Hay campos vacíos, debe llenar todos para continuar", "Error: Campos vacíos");
                return;
            }
          

           if (!double.TryParse(X0.Text, out a) ||
                !double.TryParse(X1.Text, out b) ||
                !double.TryParse(Tolerancia.Text, out double tol) ||
                !int.TryParse(Iterr.Text, out int iter))
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
         


            MS.CalcularSecante(FrmPrincipal.FX, a, b, tol, iter, DtgDatos, TxtRaiz);

            if (TxtRaiz.Text == "Error") return;

            Estilos.ResaltarUltimaFila(DtgDatos);
           // BtnProblema.PerformClick();

            if (double.TryParse(TxtRaiz.Text, out double raiz))
                mg.Graficar(FrmPrincipal.FX, a , b , raiz, DtgDatos, "xk");

            mQUIA.GenerarProblemaPro(
               rIA, FrmPrincipal.FX, "Falsa posicion",
               $"X0={X0.Text}, X1={X1.Text}, " +
               $"tol={TxtTolerancia.Text}%, iter={TxtIter.Text}, " +
               $"raiz={TxtRaiz.Text}");
        }

        private void X1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UCSecante_Load(object sender, EventArgs e)
        {
            X0.Text = "";
            X1.Text = "";
        }
    }
}
