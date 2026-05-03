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
    public partial class UCBiseccion : UserControl
    {

        ManejadorBiseccion MB;
        public UCBiseccion()
        {
            InitializeComponent();
            MB = new ManejadorBiseccion();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
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
                    MessageBox.Show("El intervalo NO es válido: f(a) y f(b) deben tener signos opuestos.");
                    return;
                }

                MB.CalcularBiseccion(
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
