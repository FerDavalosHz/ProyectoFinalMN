using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejador
{
    public class ManejadorFalsaPosicion
    {
        public void CalcularFalsaPosicion(string fun, double a, double b, double tol, int maxIter, DataGridView Dt, TextBox txtResultado, int cantidadDec = 4)
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
                Dt.Columns.Add("xr", "xr");
                Dt.Columns.Add("f(xr)", "f(xr)");
                Dt.Columns.Add("f(xa)", "f(xa)");

                double fa = mf.Evaluar(expresion, a);
                double fb = mf.Evaluar(expresion, b);

                if (fa * fb > 0)
                {
                    MessageBox.Show($"El intervalo no contiene raíz\nf(a)={fa}, f(b)={fb}");
                    txtResultado.Text = "Error";
                    return;
                }

         
                Dt.Rows.Add(
                    "0",
                    Math.Round(a, cantidadDec).ToString(),
                    Math.Round(b, cantidadDec).ToString(),
                    "-",
                    "-",
                    "-"
                );

                double xr = 0;
                double fxr = 0;

                for (int i = 1; i <= maxIter; i++)
                {
                    fa = mf.Evaluar(expresion, a);
                    fb = mf.Evaluar(expresion, b);

                    xr = b - (fb * (a - b)) / (fa - fb);
                    fxr = mf.Evaluar(expresion, xr);

                    Dt.Rows.Add(
                        i.ToString(),
                        Math.Round(a, cantidadDec).ToString(),
                        Math.Round(b, cantidadDec).ToString(),
                        Math.Round(xr, cantidadDec).ToString(),
                        Math.Round(fxr, cantidadDec).ToString(),
                        Math.Round(fa, cantidadDec).ToString()
                    );

                    if (Math.Abs(fxr) < tol)
                    {
                        txtResultado.Text = Math.Round(xr, cantidadDec).ToString();
                        return;
                    }

                    // Actualizar intervalo igual que bisección
                    if (fa * fxr < 0)
                        b = xr;
                    else
                        a = xr;
                }

                txtResultado.Text = Math.Round(xr, cantidadDec).ToString();
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
