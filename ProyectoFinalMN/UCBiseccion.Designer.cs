namespace ProyectoFinalMN
{
    partial class UCBiseccion
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtRaiz = new System.Windows.Forms.TextBox();
            this.DtgDatos = new System.Windows.Forms.DataGridView();
            this.las = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtInferior = new System.Windows.Forms.TextBox();
            this.TxtSuperior = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTolerancia = new System.Windows.Forms.TextBox();
            this.lasdal = new System.Windows.Forms.Label();
            this.TxtIter = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.pGrafica = new System.Windows.Forms.Panel();
            this.BtnProblema = new System.Windows.Forms.Button();
            this.rIA = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtRaiz
            // 
            this.TxtRaiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(235)))), ((int)(((byte)(202)))));
            this.TxtRaiz.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRaiz.Location = new System.Drawing.Point(133, 8);
            this.TxtRaiz.Multiline = true;
            this.TxtRaiz.Name = "TxtRaiz";
            this.TxtRaiz.ReadOnly = true;
            this.TxtRaiz.Size = new System.Drawing.Size(217, 37);
            this.TxtRaiz.TabIndex = 0;
            this.TxtRaiz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DtgDatos
            // 
            this.DtgDatos.AllowUserToAddRows = false;
            this.DtgDatos.AllowUserToDeleteRows = false;
            this.DtgDatos.AllowUserToResizeColumns = false;
            this.DtgDatos.AllowUserToResizeRows = false;
            this.DtgDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDatos.Location = new System.Drawing.Point(364, 3);
            this.DtgDatos.Name = "DtgDatos";
            this.DtgDatos.Size = new System.Drawing.Size(490, 569);
            this.DtgDatos.TabIndex = 2;
            // 
            // las
            // 
            this.las.AutoSize = true;
            this.las.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.las.Location = new System.Drawing.Point(22, 42);
            this.las.Name = "las";
            this.las.Size = new System.Drawing.Size(92, 15);
            this.las.TabIndex = 3;
            this.las.Text = "Limite inferior. *";
            this.las.Click += new System.EventHandler(this.las_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Limite superior. *";
            // 
            // TxtInferior
            // 
            this.TxtInferior.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInferior.Location = new System.Drawing.Point(136, 40);
            this.TxtInferior.Name = "TxtInferior";
            this.TxtInferior.Size = new System.Drawing.Size(184, 20);
            this.TxtInferior.TabIndex = 5;
            // 
            // TxtSuperior
            // 
            this.TxtSuperior.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSuperior.Location = new System.Drawing.Point(136, 81);
            this.TxtSuperior.Name = "TxtSuperior";
            this.TxtSuperior.Size = new System.Drawing.Size(184, 20);
            this.TxtSuperior.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tolerancia. *";
            // 
            // TxtTolerancia
            // 
            this.TxtTolerancia.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTolerancia.Location = new System.Drawing.Point(136, 118);
            this.TxtTolerancia.Name = "TxtTolerancia";
            this.TxtTolerancia.Size = new System.Drawing.Size(184, 20);
            this.TxtTolerancia.TabIndex = 8;
            // 
            // lasdal
            // 
            this.lasdal.AutoSize = true;
            this.lasdal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lasdal.Location = new System.Drawing.Point(22, 164);
            this.lasdal.Name = "lasdal";
            this.lasdal.Size = new System.Drawing.Size(182, 15);
            this.lasdal.TabIndex = 9;
            this.lasdal.Text = "Maximo numero de iteraciones. *";
            // 
            // TxtIter
            // 
            this.TxtIter.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIter.Location = new System.Drawing.Point(200, 162);
            this.TxtIter.Name = "TxtIter";
            this.TxtIter.Size = new System.Drawing.Size(120, 20);
            this.TxtIter.TabIndex = 10;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(146)))), ((int)(((byte)(154)))));
            this.BtnCalcular.FlatAppearance.BorderSize = 0;
            this.BtnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalcular.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.Location = new System.Drawing.Point(6, 211);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(314, 45);
            this.BtnCalcular.TabIndex = 11;
            this.BtnCalcular.Text = "CALCULAR RAIZ";
            this.BtnCalcular.UseVisualStyleBackColor = false;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // pGrafica
            // 
            this.pGrafica.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pGrafica.Location = new System.Drawing.Point(875, 3);
            this.pGrafica.Name = "pGrafica";
            this.pGrafica.Size = new System.Drawing.Size(385, 648);
            this.pGrafica.TabIndex = 12;
            // 
            // BtnProblema
            // 
            this.BtnProblema.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnProblema.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProblema.Location = new System.Drawing.Point(389, 406);
            this.BtnProblema.Name = "BtnProblema";
            this.BtnProblema.Size = new System.Drawing.Size(159, 44);
            this.BtnProblema.TabIndex = 14;
            this.BtnProblema.Text = "Generar Problema";
            this.BtnProblema.UseVisualStyleBackColor = true;
            this.BtnProblema.Click += new System.EventHandler(this.BtnProblema_Click);
            // 
            // rIA
            // 
            this.rIA.BackColor = System.Drawing.Color.White;
            this.rIA.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rIA.Location = new System.Drawing.Point(19, 308);
            this.rIA.Name = "rIA";
            this.rIA.ReadOnly = true;
            this.rIA.Size = new System.Drawing.Size(326, 343);
            this.rIA.TabIndex = 15;
            this.rIA.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.las);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lasdal);
            this.groupBox1.Controls.Add(this.TxtInferior);
            this.groupBox1.Controls.Add(this.TxtSuperior);
            this.groupBox1.Controls.Add(this.TxtTolerancia);
            this.groupBox1.Controls.Add(this.TxtIter);
            this.groupBox1.Controls.Add(this.BtnCalcular);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 265);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuracion del metodo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "DETALLES DEL PROBLEMA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TxtRaiz);
            this.panel1.Location = new System.Drawing.Point(364, 600);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 51);
            this.panel1.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 22);
            this.label5.TabIndex = 20;
            this.label5.Text = "RAIZ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(360, 575);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "RESULTADO";
            // 
            // UCBiseccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rIA);
            this.Controls.Add(this.pGrafica);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DtgDatos);
            this.Controls.Add(this.BtnProblema);
            this.Controls.Add(this.panel1);
            this.Name = "UCBiseccion";
            this.Size = new System.Drawing.Size(1268, 673);
            this.Load += new System.EventHandler(this.UCBiseccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtRaiz;
        private System.Windows.Forms.DataGridView DtgDatos;
        private System.Windows.Forms.Label las;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtInferior;
        private System.Windows.Forms.TextBox TxtSuperior;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTolerancia;
        private System.Windows.Forms.Label lasdal;
        private System.Windows.Forms.TextBox TxtIter;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Panel pGrafica;
        private System.Windows.Forms.Button BtnProblema;
        private System.Windows.Forms.RichTextBox rIA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}
