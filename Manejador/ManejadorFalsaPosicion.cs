using System.Windows.Forms;
using System;

namespace Manejador
{
    public class ManejadorFalsaPosicion
    {
        private static int ClampDec(int n) => Math.Max(0, Math.Min(15, n));

        public void CalcularFalsaPosicion(
            string fun, double a, double b, double tol, int maxIter,
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

                // Caso especial: algún extremo ya es raíz
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
                Dt.Columns.Add("xr", "xr");
                Dt.Columns.Add("fxr", "f(xr)");
                Dt.Columns.Add("fxa", "f(xa)");

                Dt.Rows.Add("0",
                    Math.Round(a, cantidadDec),
                    Math.Round(b, cantidadDec),
                    "-", "-", "-");

                double xr = a;
                double fxr = fa;

                for (int i = 1; i <= maxIter; i++)
                {
                    fa = mf.Evaluar(expresion, a);
                    fb = mf.Evaluar(expresion, b);

                    // Denominador de la fórmula de falsa posición
                    double denominador = fa - fb;
                    if (Math.Abs(denominador) < 1e-14)
                    {
                        MessageBox.Show(
                            $"f(a) y f(b) son prácticamente iguales en la iteración {i}.\n" +
                            "El método no puede continuar (denominador ≈ 0).");
                        txtResultado.Text = "Error";
                        return;
                    }

                    xr = b - (fb * (a - b)) / denominador;
                    fxr = mf.Evaluar(expresion, xr);

                    Dt.Rows.Add(
                        i.ToString(),
                        Math.Round(a, cantidadDec),
                        Math.Round(b, cantidadDec),
                        Math.Round(xr, cantidadDec),
                        Math.Round(fxr, cantidadDec),
                        Math.Round(fa, cantidadDec));

                    if (Math.Abs(fxr) < tol)
                    {
                        txtResultado.Text = Math.Round(xr, cantidadDec).ToString();
                        return;
                    }

                    if (fa * fxr < 0)
                        b = xr;
                    else
                        a = xr;
                }

                txtResultado.Text = Math.Round(xr, cantidadDec).ToString();
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