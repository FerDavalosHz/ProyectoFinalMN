using System;
using System.Windows.Forms;

namespace ProyectoFinalMN
{
    public partial class FrmPrincipal : Form
    {
        
        public static string FX = "x^2 + x";

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnFuncion_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.BringToFront();

            UCFUNC uc = new UCFUNC();
            uc.Dock = DockStyle.Fill;

            panel1.Controls.Add(uc);
            uc.BringToFront();

            uc.SelectFuncion(); 
        }

        private void BtnBiseccion_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.BringToFront();

            UCBiseccion uc = new UCBiseccion();
            uc.Dock = DockStyle.Fill;

            panel2.Controls.Add(uc);
            uc.BringToFront();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}