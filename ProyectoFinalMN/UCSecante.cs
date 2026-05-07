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

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FrmPrincipal.FX);

            a = double.Parse(X0.Text);
            b = double.Parse(X1.Text);
            double tol = double.Parse(Tolerancia.Text);
            int iter = int.Parse(Iterr.Text);

            MS.CalcularSecante(
                FrmPrincipal.FX,
                a,
                b,
                tol,
                iter,
                DtgDatos,
                TxtRaiz
            );
            Estilos.ResaltarUltimaFila(DtgDatos);
            BtnGraficar.Visible = true;

            rIA.Text = "Generando problema...";
            mQUIA.GenerarProblemaPro(
              rIA, FrmPrincipal.FX, "Secante", $"a={a}, b={b}, tol={TxtTolerancia.Text}, iter={TxtIter.Text}, raiz= {TxtRaiz}"
            );

            mg.Graficar(FrmPrincipal.FX, a, b, double.Parse(TxtRaiz.Text), DtgDatos, "xk");

        }
    }
}
