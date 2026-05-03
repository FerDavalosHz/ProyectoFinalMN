using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Core;
using ProyectoFinalMN;

namespace ProyectoFinalMN
{
    public partial class UCFUNC : UserControl
    {
        WebView2 web;

        public UCFUNC()
        {
            InitializeComponent();
        }


        public async void SelectFuncion()
        {
            web = new WebView2();
            web.Dock = DockStyle.Fill;

            pEditor.Controls.Clear();
            pEditor.Controls.Add(web);

            await web.EnsureCoreWebView2Async(null);

            string ruta = Path.Combine(Application.StartupPath, "editor.html");

            web.Source = new Uri(ruta);

            web.CoreWebView2.WebMessageReceived += RecibirMensaje;
        }


        private void RecibirMensaje(object sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            string funcion = e.TryGetWebMessageAsString();
            FrmPrincipal.FX = funcion;
        }

          
        private void LblFuncion_Click(object sender, EventArgs e)
        {

        }
    }
}