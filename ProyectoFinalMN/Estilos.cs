using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ProyectoFinalMN
{
    public static class Estilos
    {
        private static GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);

            path.CloseFigure();
            return path;
        }
        public static void BotonRedondeado(Button btn, int radius)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;

            btn.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                Rectangle rect = btn.ClientRectangle;
                rect.Width -= 1;
                rect.Height -= 1;

                using (GraphicsPath path = GetRoundedPath(rect, radius))
                {
                    btn.Region = new Region(path);
                }
            };
        }
        public static void PanelRedondeado(Panel panel, int radius)
        {
            panel.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                Rectangle rect = panel.ClientRectangle;
                rect.Width -= 1;
                rect.Height -= 1;

                using (GraphicsPath path = GetRoundedPath(rect, radius))
                {
                    panel.Region = new Region(path);
                }
            };
        }
        public static Panel TextBoxRedondeado(TextBox txt, int radius)
        {
            Panel container = new Panel();
            container.BackColor = Color.Transparent;

            txt.BorderStyle = BorderStyle.None;

            container.Controls.Add(txt);
            txt.Location = new Point(5, 5);

            container.Size = new Size(txt.Width + 10, txt.Height + 10);

            container.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                Rectangle rect = container.ClientRectangle;
                rect.Width -= 1;
                rect.Height -= 1;

                using (GraphicsPath path = GetRoundedPath(rect, radius))
                {
                    container.Region = new Region(path);
                }
            };

            return container;
        }




        public static void EnchularGrid(DataGridView grid)
        {
            
            grid.Font = new Font("Times New Roman", 11);
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            
            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 11, FontStyle.Bold);
            grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid.DefaultCellStyle.BackColor = Color.White;
            grid.DefaultCellStyle.ForeColor = Color.Black;
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 220, 255);
            grid.DefaultCellStyle.SelectionForeColor = Color.Black; 
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245); 
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.GridColor = Color.LightGray;
            grid.BorderStyle = BorderStyle.None; 
            grid.RowHeadersVisible = false; 
            grid.RowTemplate.Height = 28; 
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false; 
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 230, 250); 
            grid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
           
           
        }



        public static void ResaltarUltimaFila(DataGridView grid)
        {
            if (grid.Rows.Count > 0)
            {
                int lastRow = grid.Rows.Count - 1;

                var estilo = new DataGridViewCellStyle();
                estilo.BackColor = Color.FromArgb(220, 230, 240); // gris azulado leve
                estilo.ForeColor = Color.Black;
                estilo.Font = new Font("Times New Roman", 11, FontStyle.Bold);

                grid.Rows[lastRow].DefaultCellStyle = estilo;
            }
        }
        public static void SeleccionarUltimaFila(DataGridView grid)
        {
            if (grid.Rows.Count > 0)
            {
                int lastRow = grid.Rows.Count - 1;
                grid.ClearSelection();
                grid.Rows[lastRow].Selected = true;
                grid.CurrentCell = grid.Rows[lastRow].Cells[3];
            }
        }




    }
}