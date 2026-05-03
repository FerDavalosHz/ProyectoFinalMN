namespace ProyectoFinalMN
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnFuncion = new System.Windows.Forms.Button();
            this.BtnBiseccion = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 187);
            this.panel1.TabIndex = 0;
            // 
            // BtnFuncion
            // 
            this.BtnFuncion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFuncion.Location = new System.Drawing.Point(12, 12);
            this.BtnFuncion.Name = "BtnFuncion";
            this.BtnFuncion.Size = new System.Drawing.Size(113, 59);
            this.BtnFuncion.TabIndex = 1;
            this.BtnFuncion.Text = "F(X)";
            this.BtnFuncion.UseVisualStyleBackColor = true;
            this.BtnFuncion.Click += new System.EventHandler(this.BtnFuncion_Click);
            // 
            // BtnBiseccion
            // 
            this.BtnBiseccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBiseccion.Location = new System.Drawing.Point(180, 12);
            this.BtnBiseccion.Name = "BtnBiseccion";
            this.BtnBiseccion.Size = new System.Drawing.Size(133, 59);
            this.BtnBiseccion.TabIndex = 2;
            this.BtnBiseccion.Text = "BISECCION";
            this.BtnBiseccion.UseVisualStyleBackColor = true;
            this.BtnBiseccion.Click += new System.EventHandler(this.BtnBiseccion_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(12, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1122, 650);
            this.panel2.TabIndex = 3;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 751);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BtnBiseccion);
            this.Controls.Add(this.BtnFuncion);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPrincipal";
            this.Text = "METODOS NUMERICOS";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnFuncion;
        private System.Windows.Forms.Button BtnBiseccion;
        private System.Windows.Forms.Panel panel2;
    }
}

