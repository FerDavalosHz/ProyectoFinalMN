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
        private static int ClampDec(int n) => Math.Max(0, Math.Min(15, n));

        public void CalcularSecante(
            string fun, double x0, double x1, double tol, int maxIter,
            DataGridView Dt, TextBox txtResultado, int cantidadDec = 5)
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
                if (Math.Abs(x1 - x0) < 1e-14)
                {
                    MessageBox.Show("x0 y x1 no pueden ser iguales o prácticamente iguales.");
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


                try
                {
                    mf.Evaluar(expresion, x0);
                    mf.Evaluar(expresion, x1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al evaluar en los puntos iniciales:\n" + ex.Message);
                    txtResultado.Text = "Error";
                    return;
                }

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

                    double denominador = fxk1 - fxk;
                    if (Math.Abs(denominador) < 1e-14)
                    {
                        MessageBox.Show(
                            $"f(xk+1) - f(xk) ≈ 0 en la iteración {i + 1}.\n" +
                            "El método no puede continuar (división por cero).\n" +
                            "Prueba con otros puntos iniciales.");
                        txtResultado.Text = "Error";
                        return;
                    }

                    double xk2 = xk1 - fxk1 * (xk1 - xk) / denominador;

  
                    if (double.IsNaN(xk2) || double.IsInfinity(xk2))
                    {
                        MessageBox.Show(
                            $"El método diverge en la iteración {i + 1}.\n" +
                            "Prueba con otros puntos iniciales.");
                        txtResultado.Text = "Error";
                        return;
                    }

                    double error = Math.Abs(xk2) > 1e-10
                        ? Math.Abs((xk2 - xk1) / xk2) * 100.0
                        : Math.Abs(xk2 - xk1) * 100.0;

                    Dt.Rows.Add(
                        Math.Round(xk, cantidadDec),
                        Math.Round(xk1, cantidadDec),
                        Math.Round(fxk, cantidadDec),
                        Math.Round(fxk1, cantidadDec),
                        Math.Round(error, cantidadDec).ToString() + "%");

                    if (error < tol)
                    {
                        txtResultado.Text = Math.Round(xk2, cantidadDec).ToString();
                        return;
                    }

                    xk = xk1;
                    xk1 = xk2;
                }

                txtResultado.Text = Math.Round(xk1, cantidadDec).ToString();
                MessageBox.Show("Se alcanzó el máximo de iteraciones.\nEl resultado puede no ser exacto.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado:\n" + ex.Message);
                txtResultado.Text = "Error";
            }
        }
    }
}
