using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFinalMN
{
    public partial class FrmPrincipal : Form
    {
        public static string FX;
        private UCFUNC ucFunc;
        private UserControl controlActualPanel2;

        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void MoverIndicador(Control boton)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                   
                    c.Font = new Font(c.Font, FontStyle.Regular);
                    c.BackColor = Color.FromArgb(239, 244, 248);
                }
            }

            boton.Font = new Font(boton.Font,FontStyle.Bold);
            boton.BackColor = Color.FromArgb(221, 228, 233);
            pSelect.Visible = true;
            pSelect.Left = boton.Left;
            pSelect.Width = boton.Width;
            pSelect.Height = 15;
            pSelect.SendToBack();
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null, panel2, new object[] { true });
        }
        private void BtnFuncion_Click(object sender, EventArgs e)
        {
           
            panel2.SuspendLayout();
            MoverIndicador(BtnFuncion);
            try
            {
                if (ucFunc == null)
                {
                    ucFunc = new UCFUNC();
                    ucFunc.Dock = DockStyle.Fill;
                    panel2.Controls.Add(ucFunc);
                    ucFunc.SelectFuncion();
                }
                if (controlActualPanel2 == ucFunc)
                {
                    ucFunc.Visible = !ucFunc.Visible;
                    return;
                }

                if (controlActualPanel2 != null && controlActualPanel2 != ucFunc)
                {
                    panel2.Controls.Remove(controlActualPanel2);
                    controlActualPanel2.Dispose();
                }

                controlActualPanel2 = ucFunc;

                ucFunc.Visible = true;
                ucFunc.BringToFront();
            }
            finally
            {
                panel2.ResumeLayout();
            }
        }

        private void MostrarEnPanel2(UserControl nuevoControl)
        {
            panel2.SuspendLayout();

            try
            {

                if (controlActualPanel2 == nuevoControl)
                {
                    nuevoControl.Visible = !nuevoControl.Visible;
                    return;
                }
                if (ucFunc != null)
                    ucFunc.Visible = false;
                if (controlActualPanel2 != null && controlActualPanel2 != ucFunc)
                {
                    panel2.Controls.Remove(controlActualPanel2);
                    controlActualPanel2.Dispose();
                }

                controlActualPanel2 = nuevoControl;

                nuevoControl.Dock = DockStyle.Fill;

                if (!panel2.Controls.Contains(nuevoControl))
                    panel2.Controls.Add(nuevoControl);

                nuevoControl.Visible = true;
                nuevoControl.BringToFront();
            }
            finally
            {
                panel2.ResumeLayout();
            }
        }

        private void BtnBiseccion_Click(object sender, EventArgs e)
        {
            
            MostrarEnPanel2(new UCBiseccion());
            MoverIndicador(BtnBiseccion);
        }

        private void BtnFalsaPoscicion_Click(object sender, EventArgs e)
        {
           
            MostrarEnPanel2(new UCFalsaPos());
            MoverIndicador(BtnFalsaPoscicion);
        }

        private void BtnSecante_Click(object sender, EventArgs e)
        {
            MostrarEnPanel2(new UCSecante());
            MoverIndicador(BtnSecante);
        }

        private void BtnNewtonR_Click(object sender, EventArgs e)
        {
            MostrarEnPanel2(new UCNewtonRaphson());
            MoverIndicador(BtnNewtonR);
        }
    }
}