using System;
using System.Windows.Forms;

namespace Manejador
{
    public class ManejadorNewtonRaphson
    {
        private static int ClampDec(int n) => Math.Max(0, Math.Min(15, n));

        public void CalcularNewtonRaphson(
            string fun, double x0, double tol, int maxIter,
            DataGridView Dt, TextBox txtResultado, int cantidadDec = 4)
        {
            cantidadDec = ClampDec(cantidadDec);
            ManejadorFuncion mf = new ManejadorFuncion();

            try
            {
                if (string.IsNullOrWhiteSpace(fun))
                {
                    MessageBox.Show("No hay función seleccionada.");
                    return;
                }
                if (tol <= 0)
                {
                    MessageBox.Show("La tolerancia debe ser un valor positivo.");
                    return;
                }
                if (maxIter <= 0)
                {
                    MessageBox.Show("El número de iteraciones debe ser mayor a cero.");
                    return;
                }

                if (!mf.TryProcesar(fun, out string expresion, out string errorProceso))
                {
                    MessageBox.Show(errorProceso);
                    txtResultado.Text = "Error";
                    return;
                }


                try { mf.Evaluar(expresion, x0); }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al evaluar en x0:\n" + ex.Message);
                    txtResultado.Text = "Error";
                    return;
                }

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
                        MessageBox.Show(
                            $"La derivada es cero (o casi cero) en x = {xk}.\n" +
                            "El método no puede continuar. Prueba con otro punto inicial.");
                        txtResultado.Text = "Error";
                        return;
                    }

                    double xk1 = xk - fxk / dfxk;

      
                    if (double.IsNaN(xk1) || double.IsInfinity(xk1))
                    {
                        MessageBox.Show(
                            $"El método diverge en la iteración {i + 1}.\n" +
                            "Prueba con un punto inicial más cercano a la raíz.");
                        txtResultado.Text = "Error";
                        return;
                    }

  
                    double error = Math.Abs(xk1) > 1e-10
                        ? Math.Abs((xk1 - xk) / xk1) * 100.0
                        : Math.Abs(xk1 - xk) * 100.0;

                    Dt.Rows.Add(
                        Math.Round(xk, cantidadDec),
                        Math.Round(fxk, cantidadDec),
                        Math.Round(dfxk, cantidadDec),
                        Math.Round(xk1, cantidadDec),
                        Math.Round(error, cantidadDec).ToString() + "%");

                    if (error < tol)
                    {
                        txtResultado.Text = Math.Round(xk1, cantidadDec).ToString();
                        return;
                    }

                    xk = xk1;
                }

                txtResultado.Text = Math.Round(xk, cantidadDec).ToString();
                MessageBox.Show("Se alcanzó el máximo de iteraciones.\nEl resultado puede no ser exacto.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado:\n" + ex.Message);
                txtResultado.Text = "Error";
            }
        }

        private double DerivadaNumerica(ManejadorFuncion mf, string expresion, double x)
        {
            double h = 1e-7;
            return (mf.Evaluar(expresion, x + h) - mf.Evaluar(expresion, x - h)) / (2.0 * h);
        }
    }
}