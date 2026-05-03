using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejador
{
    public class ManejadorSecante
    {
        public void CalcularSecante(string fun, double x0, double x1, double tol, int maxIter, DataGridView Dt, TextBox txtResultado, int cantidadDec = 5)
        {
            ManejadorFuncion mf = new ManejadorFuncion();

            try
            {
                if (string.IsNullOrWhiteSpace(fun))
                {
                    MessageBox.Show("No hay función seleccionada");
                    return;
                }

                string expresion = mf.ProcesarFuncion(fun);

                Dt.Rows.Clear();
                Dt.Columns.Clear();
                Dt.AutoGenerateColumns = false;
                Dt.Columns.Add("xk", "xk");
                Dt.Columns.Add("xk1", "xk+1");
                Dt.Columns.Add("fxk", "f(xk)");
                Dt.Columns.Add("fxk1", "f(xk+1)");
                Dt.Columns.Add("error", "Error %");

                double xk = x0;
                double xk1 = x1;

                for (int i = 0; i < maxIter; i++)
                {
                    double fxk = mf.Evaluar(expresion, xk);
                    double fxk1 = mf.Evaluar(expresion, xk1);

                    if (Math.Abs(fxk1 - fxk) < 1e-12)
                    {
                        MessageBox.Show("División por cero: f(xk+1) - f(xk) es demasiado pequeño");
                        txtResultado.Text = "Error";
                        return;
                    }

                    double xk2 = xk1 - fxk1 * (xk1 - xk) / (fxk1 - fxk);
                    double error = Math.Abs((xk2 - xk1) / xk2) * 100;

                    Dt.Rows.Add(
                        Math.Round(xk, cantidadDec).ToString(),
                        Math.Round(xk1, cantidadDec).ToString(),
                        Math.Round(fxk, cantidadDec).ToString(),
                        Math.Round(fxk1, cantidadDec).ToString(),
                        Math.Round(error, cantidadDec).ToString() + "%"
                    );


                    if (error < tol)
                    {
                        txtResultado.Text = Math.Round(xk2, cantidadDec).ToString();
                        return;
                    }

                    xk = xk1;
                    xk1 = xk2;
                }

                txtResultado.Text = Math.Round(xk1, cantidadDec).ToString();
                MessageBox.Show("Máximo de iteraciones alcanzado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                txtResultado.Text = "Error";
            }
        }
    }
}
