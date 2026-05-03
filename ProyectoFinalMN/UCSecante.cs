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
        public UCSecante()
        {
            InitializeComponent();
            MS = new ManejadorSecante();
        }

     

        private void BtnCalcular_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(FrmPrincipal.FX);

            double a = double.Parse(TxtX0.Text);
            double b = double.Parse(TxtX1.Text);
            double tol = double.Parse(TxtTolerancia.Text);
            int iter = int.Parse(TxtIter.Text);

            MS.CalcularSecante(
                FrmPrincipal.FX,
                a,
                b,
                tol,
                iter,
                DtgDatos,
                TxtRaiz
            );

        }
    }
}
