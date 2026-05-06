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
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnNewtonR = new System.Windows.Forms.Button();
            this.BtnSecante = new System.Windows.Forms.Button();
            this.BtnFalsaPoscicion = new System.Windows.Forms.Button();
            this.BtnBiseccion = new System.Windows.Forms.Button();
            this.BtnFuncion = new System.Windows.Forms.Button();
            this.pSelect = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 187);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1268, 673);
            this.panel2.TabIndex = 3;
            // 
            // BtnNewtonR
            // 
            this.BtnNewtonR.FlatAppearance.BorderSize = 0;
            this.BtnNewtonR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewtonR.Image = global::ProyectoFinalMN.Properties.Resources.icons8_gráfico_combinado_48;
            this.BtnNewtonR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNewtonR.Location = new System.Drawing.Point(654, 1);
            this.BtnNewtonR.Name = "BtnNewtonR";
            this.BtnNewtonR.Size = new System.Drawing.Size(183, 59);
            this.BtnNewtonR.TabIndex = 6;
            this.BtnNewtonR.Text = "NEWTON RAPHSON";
            this.BtnNewtonR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNewtonR.UseVisualStyleBackColor = true;
            this.BtnNewtonR.Click += new System.EventHandler(this.BtnNewtonR_Click);
            // 
            // BtnSecante
            // 
            this.BtnSecante.FlatAppearance.BorderSize = 0;
            this.BtnSecante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSecante.Image = global::ProyectoFinalMN.Properties.Resources.icons8_plot_50;
            this.BtnSecante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSecante.Location = new System.Drawing.Point(505, 1);
            this.BtnSecante.Name = "BtnSecante";
            this.BtnSecante.Size = new System.Drawing.Size(149, 59);
            this.BtnSecante.TabIndex = 5;
            this.BtnSecante.Text = "SECANTE";
            this.BtnSecante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSecante.UseVisualStyleBackColor = true;
            this.BtnSecante.Click += new System.EventHandler(this.BtnSecante_Click);
            // 
            // BtnFalsaPoscicion
            // 
            this.BtnFalsaPoscicion.FlatAppearance.BorderSize = 0;
            this.BtnFalsaPoscicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFalsaPoscicion.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.BtnFalsaPoscicion.Image = global::ProyectoFinalMN.Properties.Resources.icons8_grafico_50;
            this.BtnFalsaPoscicion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFalsaPoscicion.Location = new System.Drawing.Point(170, 1);
            this.BtnFalsaPoscicion.Name = "BtnFalsaPoscicion";
            this.BtnFalsaPoscicion.Size = new System.Drawing.Size(170, 59);
            this.BtnFalsaPoscicion.TabIndex = 4;
            this.BtnFalsaPoscicion.Text = "FALSA POSICION ";
            this.BtnFalsaPoscicion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnFalsaPoscicion.UseVisualStyleBackColor = true;
            this.BtnFalsaPoscicion.Click += new System.EventHandler(this.BtnFalsaPoscicion_Click);
            // 
            // BtnBiseccion
            // 
            this.BtnBiseccion.FlatAppearance.BorderSize = 0;
            this.BtnBiseccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBiseccion.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.BtnBiseccion.Image = global::ProyectoFinalMN.Properties.Resources.icons8_cortar_48;
            this.BtnBiseccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBiseccion.Location = new System.Drawing.Point(340, 1);
            this.BtnBiseccion.Name = "BtnBiseccion";
            this.BtnBiseccion.Size = new System.Drawing.Size(165, 59);
            this.BtnBiseccion.TabIndex = 2;
            this.BtnBiseccion.Text = "BISECCION     ";
            this.BtnBiseccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBiseccion.UseVisualStyleBackColor = true;
            this.BtnBiseccion.Click += new System.EventHandler(this.BtnBiseccion_Click);
            // 
            // BtnFuncion
            // 
            this.BtnFuncion.FlatAppearance.BorderSize = 0;
            this.BtnFuncion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFuncion.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFuncion.Image = global::ProyectoFinalMN.Properties.Resources.icons8_inscripción_50;
            this.BtnFuncion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFuncion.Location = new System.Drawing.Point(0, 1);
            this.BtnFuncion.Name = "BtnFuncion";
            this.BtnFuncion.Size = new System.Drawing.Size(170, 59);
            this.BtnFuncion.TabIndex = 1;
            this.BtnFuncion.Text = "F(X) DEFINICION";
            this.BtnFuncion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnFuncion.UseVisualStyleBackColor = true;
            this.BtnFuncion.Click += new System.EventHandler(this.BtnFuncion_Click);
            // 
            // pSelect
            // 
            this.pSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(146)))), ((int)(((byte)(154)))));
            this.pSelect.Location = new System.Drawing.Point(3, 57);
            this.pSelect.Name = "pSelect";
            this.pSelect.Size = new System.Drawing.Size(170, 8);
            this.pSelect.TabIndex = 0;
            this.pSelect.Visible = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pSelect);
            this.Controls.Add(this.BtnNewtonR);
            this.Controls.Add(this.BtnSecante);
            this.Controls.Add(this.BtnFalsaPoscicion);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BtnBiseccion);
            this.Controls.Add(this.BtnFuncion);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Button BtnFalsaPoscicion;
        private System.Windows.Forms.Button BtnSecante;
        private System.Windows.Forms.Button BtnNewtonR;
        private System.Windows.Forms.Panel pSelect;
    }
}

