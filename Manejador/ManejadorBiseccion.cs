using System;
using System.Windows.Forms;

namespace Manejador
{
    public class ManejadorBiseccion
    {
        private static int ClampDec(int n) => Math.Max(0, Math.Min(15, n));

        public void CalcularBiseccion(
            string fun, double a, double b, double tol, int maxIter,
            DataGridView Dt, TextBox txtResultado, int cantidadDec = 3)
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
                if (a >= b)
                {
                    MessageBox.Show("El límite inferior debe ser estrictamente menor que el superior.");
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

                double fa, fb;
                try
                {
                    fa = mf.Evaluar(expresion, a);
                    fb = mf.Evaluar(expresion, b);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al evaluar en los extremos del intervalo:\n" + ex.Message);
                    txtResultado.Text = "Error";
                    return;
                }

                if (fa * fb > 0)
                {
                    MessageBox.Show(
                        $"El intervalo [{a}, {b}] no garantiza una raíz.\n" +
                        $"f(a) = {fa}\nf(b) = {fb}\n\n" +
                        "f(a) y f(b) deben tener signos opuestos.");
                    txtResultado.Text = "Error";
                    return;
                }

                if (Math.Abs(fa) < tol)
                {
                    txtResultado.Text = Math.Round(a, cantidadDec).ToString();
                    MessageBox.Show($"El extremo a = {a} ya es raíz (f(a) ≈ 0).");
                    return;
                }
                if (Math.Abs(fb) < tol)
                {
                    txtResultado.Text = Math.Round(b, cantidadDec).ToString();
                    MessageBox.Show($"El extremo b = {b} ya es raíz (f(b) ≈ 0).");
                    return;
                }

                Dt.Rows.Clear();
                Dt.Columns.Clear();
                Dt.AutoGenerateColumns = false;
                Dt.Columns.Add("No", "No");
                Dt.Columns.Add("xa", "xa");
                Dt.Columns.Add("xb", "xb");
                Dt.Columns.Add("xm", "xm");
                Dt.Columns.Add("fxm", "f(xm)");
                Dt.Columns.Add("fxa", "f(xa)");

                Dt.Rows.Add("0",
                    Math.Round(a, cantidadDec),
                    Math.Round(b, cantidadDec),
                    "-", "-", "-");

                double c = a;
                double fc = fa;

                for (int i = 1; i <= maxIter; i++)
                {
                    c = (a + b) / 2.0;
                    fc = mf.Evaluar(expresion, c);
                    fa = mf.Evaluar(expresion, a);

                    Dt.Rows.Add(
                        i.ToString(),
                        Math.Round(a, cantidadDec),
                        Math.Round(b, cantidadDec),
                        Math.Round(c, cantidadDec),
                        Math.Round(fc, cantidadDec),
                        Math.Round(fa, cantidadDec));

                    // Convergencia por valor de función
                    if (Math.Abs(fc) < tol)
                    {
                        txtResultado.Text = Math.Round(c, cantidadDec).ToString();
                        return;
                    }

                    // Convergencia por tamaño de intervalo
                    if ((b - a) / 2.0 < tol)
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