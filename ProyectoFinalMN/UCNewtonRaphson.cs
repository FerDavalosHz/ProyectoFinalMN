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
        double a;

        public UCNewtonRaphson()
        {
            InitializeComponent();
            Mr = new ManejadorNewtonRaphson();
            mg = new ManejadorGrafica();
            mg.InicializarGrafica(pGrafica);
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FrmPrincipal.FX);

             a = double.Parse(TxtX0.Text);
            double tol = double.Parse(TxtTolerancia.Text);
            int iter = int.Parse(TxtIter.Text);

            ManejadorFuncion mf = new ManejadorFuncion();

            double fa = mf.Evaluar(FrmPrincipal.FX, a);
  
        

            Mr.CalcularNewtonRaphson(
                FrmPrincipal.FX,
                a,
                tol,
                iter,
                DtgDatos,
                TxtRaiz
            );

            BtnGraficar.Visible = true;
        }

        private void BtnGraficar_Click(object sender, EventArgs e)
        {
            mg.Graficar(FrmPrincipal.FX, a, a + 3, double.Parse(TxtRaiz.Text), DtgDatos, "xk");
        }
    }
}
