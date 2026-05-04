using System;
using System.Windows.Forms;

namespace Manejador
{
    public class ManejadorNewtonRaphson
    {
        public void CalcularNewtonRaphson(string fun, double x0, double tol, int maxIter, DataGridView Dt, TextBox txtResultado, int cantidadDec = 4)
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
                Dt.Columns.Add("fxk", "f(xk)");
                Dt.Columns.Add("dfxk", "f'(xk)");
                Dt.Columns.Add("xk1", "xk+1");
                Dt.Columns.Add("error", "Error %");

                double xk = x0;

                for (int i = 0; i < maxIter; i++)
                {
                    double fxk = mf.Evaluar(expresion, xk);
                    double dfxk = DerivadaNumerica(mf, expresion, xk);

                    
                    if (Math.Abs(dfxk) < 1e-12)
                    {
                        MessageBox.Show("La derivada es cero, el método no puede continuar.");
                        txtResultado.Text = "Error";
                        return;
                    }

                    
                    double xk1 = xk - fxk / dfxk;
                    double error = Math.Abs((xk1 - xk) / xk1) * 100;

                    Dt.Rows.Add(
                        Math.Round(xk, cantidadDec).ToString(),
                        Math.Round(fxk, cantidadDec).ToString(),
                        Math.Round(dfxk, cantidadDec).ToString(),
                        Math.Round(xk1, cantidadDec).ToString(),
                        Math.Round(error, cantidadDec).ToString() + "%"
                    );

                    if (error < tol)
                    {
                        txtResultado.Text = Math.Round(xk1, cantidadDec).ToString();
                        return;
                    }

                    xk = xk1;
                }

                txtResultado.Text = Math.Round(xk, cantidadDec).ToString();
                MessageBox.Show("Máximo de iteraciones alcanzado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                txtResultado.Text = "Error";
            }
        }

        private double DerivadaNumerica(ManejadorFuncion mf, string expresion, double x)
        {
            double h = 1e-7;
            return (mf.Evaluar(expresion, x + h) - mf.Evaluar(expresion, x - h)) / (2 * h);
        }
    }
}