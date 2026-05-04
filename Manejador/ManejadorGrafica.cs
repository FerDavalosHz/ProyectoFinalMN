using System.Collections.Generic;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Axes;
using OxyPlot.WindowsForms;


namespace Manejador
{
    public class ManejadorGrafica
    {
        private PlotView plotView;
        private ManejadorFuncion mf = new ManejadorFuncion();

        public void InicializarGrafica(Panel panel)
        {
            plotView = new PlotView();
            plotView.Dock = DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(plotView);
        }

        
        private List<double> ExtraerIteraciones(DataGridView Dt, string nombreColumna)
        {
            List<double> iteraciones = new List<double>();

            if (!Dt.Columns.Contains(nombreColumna)) return iteraciones;

            foreach (DataGridViewRow row in Dt.Rows)
            {
                object val = row.Cells[nombreColumna].Value;
                if (val != null && val.ToString() != "-")
                {
                    if (double.TryParse(val.ToString(), out double x))
                        iteraciones.Add(x);
                }
            }
            return iteraciones;
        }

        public void Graficar(string fun, double xMin, double xMax, double? raiz, DataGridView Dt, string columnaIteracion)
        {
            List<double> iteraciones = ExtraerIteraciones(Dt, columnaIteracion);
            GraficarInterno(fun, xMin, xMax, raiz, iteraciones);
        }

        
        public void Graficar(string fun, double xMin, double xMax, double? raiz = null)
        {
            GraficarInterno(fun, xMin, xMax, raiz, null);
        }

        private void GraficarInterno(string fun, double xMin, double xMax, double? raiz, List<double> iteraciones)
        {
            string expresion = mf.ProcesarFuncion(fun);

            var model = new PlotModel { Title = "f(x)" };

            model.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Title = "x",
                MajorGridlineStyle = LineStyle.Dot
            });
            model.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                Title = "f(x)",
                MajorGridlineStyle = LineStyle.Dot
            });

            
            var serie = new LineSeries
            {
                Title = "f(x)",
                Color = OxyColors.RoyalBlue,
                StrokeThickness = 2
            };

            int puntos = 500;
            double paso = (xMax - xMin) / puntos;
            for (int i = 0; i <= puntos; i++)
            {
                double x = xMin + i * paso;
                try
                {
                    double y = mf.Evaluar(expresion, x);
                    if (!double.IsNaN(y) && !double.IsInfinity(y))
                        serie.Points.Add(new DataPoint(x, y));
                }
                catch { }
            }
            model.Series.Add(serie);

           
            var ejeX = new LineSeries
            {
                Color = OxyColors.Black,
                StrokeThickness = 1
            };
            ejeX.Points.Add(new DataPoint(xMin, 0));
            ejeX.Points.Add(new DataPoint(xMax, 0));
            model.Series.Add(ejeX);

            
            if (iteraciones != null && iteraciones.Count > 0)
            {
                var puntosIter = new ScatterSeries
                {
                    Title = "Iteraciones",
                    MarkerType = MarkerType.Triangle,
                    MarkerSize = 5,
                    MarkerFill = OxyColors.Orange
                };

                foreach (double xi in iteraciones)
                {
                    try
                    {
                        double yi = mf.Evaluar(expresion, xi);
                        if (!double.IsNaN(yi) && !double.IsInfinity(yi))
                        {
                            puntosIter.Points.Add(new ScatterPoint(xi, yi));

                           
                            var lineaIter = new LineSeries
                            {
                                Color = OxyColor.FromAColor(80, OxyColors.Orange),
                                StrokeThickness = 1,
                                LineStyle = LineStyle.Dash
                            };
                            lineaIter.Points.Add(new DataPoint(xi, 0));
                            lineaIter.Points.Add(new DataPoint(xi, yi));
                            model.Series.Add(lineaIter);
                        }
                    }
                    catch { }
                }
                model.Series.Add(puntosIter);
            }

           
            if (raiz.HasValue)
            {
                var puntoRaiz = new ScatterSeries
                {
                    Title = $"Raíz ≈ {raiz.Value:F4}",
                    MarkerType = MarkerType.Circle,
                    MarkerSize = 7,
                    MarkerFill = OxyColors.Red
                };
                puntoRaiz.Points.Add(new ScatterPoint(raiz.Value, 0));
                model.Series.Add(puntoRaiz);
            }

            plotView.Model = model;
        }
    }
}