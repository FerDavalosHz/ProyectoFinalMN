using System;
using System.Windows.Forms;

namespace Manejador
{
    public class ManejadorBiseccion
    {
        public void CalcularBiseccion(string fun, double a, double b, double tol, int maxIter, DataGridView Dt, TextBox txtResultado, int cantidadDec = 3)
        {
            ManejadorFuncion mf = new ManejadorFuncion();

            try
            {
                if (string.IsNullOrWhiteSpace(fun))
                {
                    MessageBox.Show("No hay función seleccionada");
                    return;
                }

                if (a >= b)
                {
                    MessageBox.Show("El límite inferior debe ser menor que el superior");
                    return;
                }

                string expresion = mf.ProcesarFuncion(fun);

                Dt.Rows.Clear();
                Dt.Columns.Clear();
                Dt.AutoGenerateColumns = false;
                Dt.Columns.Add("No", "No");
                Dt.Columns.Add("xa", "xa");
                Dt.Columns.Add("xb", "xb");
                Dt.Columns.Add("xm", "xm");
                Dt.Columns.Add("f(xm)", "f(xm)");
                Dt.Columns.Add("f(xa)", "f(xa)");

                double fa = mf.Evaluar(expresion, a);
                double fb = mf.Evaluar(expresion, b);

                if (fa * fb > 0)
                {
                    MessageBox.Show($"El intervalo no contiene raíz\nf(a)={fa}, f(b)={fb}");
                    txtResultado.Text = "Error";
                    return;
                }

                // Fila 0 — sin xm ni f(xm) ni f(xa)
                Dt.Rows.Add(
                    "0",
                    Math.Round(a, cantidadDec).ToString(),
                    Math.Round(b, cantidadDec).ToString(),
                    "-",
                    "-",
                    "-"
                );

                double c = 0;
                double fc = 0;

                for (int i = 1; i <= maxIter; i++)
                {
                    c = (a + b) / 2.0;
                    fc = mf.Evaluar(expresion, c);
                    fa = mf.Evaluar(expresion, a);

                    Dt.Rows.Add(
                        i.ToString(),
                        Math.Round(a, cantidadDec).ToString(),
                        Math.Round(b, cantidadDec).ToString(),
                        Math.Round(c, cantidadDec).ToString(),
                        Math.Round(fc, cantidadDec).ToString(),
                        Math.Round(fa, cantidadDec).ToString()
                    );

                    if (Math.Abs(fc) < tol)
                    {
                        txtResultado.Text = Math.Round(c, cantidadDec).ToString();
                        return;
                    }

                    if (fa * fc < 0)
                        b = c;
                    else
                        a = c;
                }

                txtResultado.Text = Math.Round(c, cantidadDec).ToString();
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