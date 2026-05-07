namespace ProyectoFinalMN
{
    partial class UCFalsaPos
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
            this.DtgDatos = new System.Windows.Forms.DataGridView();
            this.Raiz = new System.Windows.Forms.Label();
            this.TxtRaiz = new System.Windows.Forms.TextBox();
            this.pGrafica = new System.Windows.Forms.Panel();
            this.BtnGraficar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rIA = new System.Windows.Forms.RichTextBox();
            this.las = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtInferior = new System.Windows.Forms.TextBox();
            this.TxtSuperior = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTolerancia = new System.Windows.Forms.TextBox();
            this.lasdal = new System.Windows.Forms.Label();
            this.TxtIter = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.gbParametros = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).BeginInit();
            this.gbParametros.SuspendLayout();
            this.SuspendLayout();
            // 
            // DtgDatos
            // 
            this.DtgDatos.AllowUserToAddRows = false;
            this.DtgDatos.AllowUserToDeleteRows = false;
            this.DtgDatos.AllowUserToResizeColumns = false;
            this.DtgDatos.AllowUserToResizeRows = false;
            this.DtgDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDatos.Location = new System.Drawing.Point(369, 19);
            this.DtgDatos.Name = "DtgDatos";
            this.DtgDatos.RowHeadersWidth = 51;
            this.DtgDatos.Size = new System.Drawing.Size(652, 333);
            this.DtgDatos.TabIndex = 14;
            // 
            // Raiz
            // 
            this.Raiz.AutoSize = true;
            this.Raiz.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Raiz.Location = new System.Drawing.Point(384, 371);
            this.Raiz.Name = "Raiz";
            this.Raiz.Size = new System.Drawing.Size(39, 19);
            this.Raiz.TabIndex = 13;
            this.Raiz.Text = "Raiz";
            // 
            // TxtRaiz
            // 
            this.TxtRaiz.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.TxtRaiz.Location = new System.Drawing.Point(427, 359);
            this.TxtRaiz.Multiline = true;
            this.TxtRaiz.Name = "TxtRaiz";
            this.TxtRaiz.ReadOnly = true;
            this.TxtRaiz.Size = new System.Drawing.Size(165, 37);
            this.TxtRaiz.TabIndex = 12;
            // 
            // pGrafica
            // 
            this.pGrafica.Location = new System.Drawing.Point(369, 401);
            this.pGrafica.Name = "pGrafica";
            this.pGrafica.Size = new System.Drawing.Size(652, 293);
            this.pGrafica.TabIndex = 24;
            // 
            // BtnGraficar
            // 
            this.BtnGraficar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.BtnGraficar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.BtnGraficar.ForeColor = System.Drawing.Color.White;
            this.BtnGraficar.Location = new System.Drawing.Point(904, 358);
            this.BtnGraficar.Name = "BtnGraficar";
            this.BtnGraficar.Size = new System.Drawing.Size(117, 37);
            this.BtnGraficar.TabIndex = 25;
            this.BtnGraficar.Text = "Graficar";
            this.BtnGraficar.UseVisualStyleBackColor = false;
            this.BtnGraficar.Visible = false;
            this.BtnGraficar.Click += new System.EventHandler(this.BtnGraficar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 22);
            this.label3.TabIndex = 27;
            this.label3.Text = "DETALLES DEL PROBLEMA";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // rIA
            // 
            this.rIA.BackColor = System.Drawing.Color.White;
            this.rIA.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rIA.Location = new System.Drawing.Point(24, 319);
            this.rIA.Name = "rIA";
            this.rIA.ReadOnly = true;
            this.rIA.Size = new System.Drawing.Size(326, 343);
            this.rIA.TabIndex = 26;
            this.rIA.Text = "";
            this.rIA.TextChanged += new System.EventHandler(this.rIA_TextChanged);
            // 
            // las
            // 
            this.las.AutoSize = true;
            this.las.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.las.Location = new System.Drawing.Point(17, 54);
            this.las.Name = "las";
            this.las.Size = new System.Drawing.Size(97, 15);
            this.las.TabIndex = 15;
            this.las.Text = "Limite inferior. *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Limite superior. *";
            // 
            // TxtInferior
            // 
            this.TxtInferior.Location = new System.Drawing.Point(116, 43);
            this.TxtInferior.Name = "TxtInferior";
            this.TxtInferior.Size = new System.Drawing.Size(131, 32);
            this.TxtInferior.TabIndex = 17;
            // 
            // TxtSuperior
            // 
            this.TxtSuperior.Location = new System.Drawing.Point(116, 84);
            this.TxtSuperior.Name = "TxtSuperior";
            this.TxtSuperior.Size = new System.Drawing.Size(131, 32);
            this.TxtSuperior.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tolerancia. *";
            // 
            // TxtTolerancia
            // 
            this.TxtTolerancia.Location = new System.Drawing.Point(116, 123);
            this.TxtTolerancia.Name = "TxtTolerancia";
            this.TxtTolerancia.Size = new System.Drawing.Size(131, 32);
            this.TxtTolerancia.TabIndex = 20;
            // 
            // lasdal
            // 
            this.lasdal.AutoSize = true;
            this.lasdal.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lasdal.Location = new System.Drawing.Point(20, 175);
            this.lasdal.Name = "lasdal";
            this.lasdal.Size = new System.Drawing.Size(170, 15);
            this.lasdal.TabIndex = 21;
            this.lasdal.Text = "Maximo numero de iteraciones";
            // 
            // TxtIter
            // 
            this.TxtIter.Location = new System.Drawing.Point(196, 167);
            this.TxtIter.Name = "TxtIter";
            this.TxtIter.Size = new System.Drawing.Size(53, 32);
            this.TxtIter.TabIndex = 22;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.BtnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCalcular.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.ForeColor = System.Drawing.Color.White;
            this.BtnCalcular.Location = new System.Drawing.Point(105, 215);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(97, 32);
            this.BtnCalcular.TabIndex = 23;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = false;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click_1);
            // 
            // gbParametros
            // 
            this.gbParametros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.gbParametros.Controls.Add(this.BtnCalcular);
            this.gbParametros.Controls.Add(this.las);
            this.gbParametros.Controls.Add(this.label1);
            this.gbParametros.Controls.Add(this.TxtInferior);
            this.gbParametros.Controls.Add(this.TxtSuperior);
            this.gbParametros.Controls.Add(this.TxtIter);
            this.gbParametros.Controls.Add(this.label2);
            this.gbParametros.Controls.Add(this.lasdal);
            this.gbParametros.Controls.Add(this.TxtTolerancia);
            this.gbParametros.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbParametros.ForeColor = System.Drawing.Color.White;
            this.gbParametros.Location = new System.Drawing.Point(24, 19);
            this.gbParametros.Margin = new System.Windows.Forms.Padding(2);
            this.gbParametros.Name = "gbParametros";
            this.gbParametros.Padding = new System.Windows.Forms.Padding(2);
            this.gbParametros.Size = new System.Drawing.Size(325, 262);
            this.gbParametros.TabIndex = 28;
            this.gbParametros.TabStop = false;
            this.gbParametros.Text = "Configuracion del metodo";
            // 
            // UCFalsaPos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rIA);
            this.Controls.Add(this.BtnGraficar);
            this.Controls.Add(this.pGrafica);
            this.Controls.Add(this.DtgDatos);
            this.Controls.Add(this.Raiz);
            this.Controls.Add(this.TxtRaiz);
            this.Controls.Add(this.gbParametros);
            this.Name = "UCFalsaPos";
            this.Size = new System.Drawing.Size(1042, 718);
            this.Load += new System.EventHandler(this.UCFalsaPos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).EndInit();
            this.gbParametros.ResumeLayout(false);
            this.gbParametros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DtgDatos;
        private System.Windows.Forms.Label Raiz;
        private System.Windows.Forms.TextBox TxtRaiz;
        private System.Windows.Forms.Panel pGrafica;
        private System.Windows.Forms.Button BtnGraficar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rIA;
        private System.Windows.Forms.Label las;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtInferior;
        private System.Windows.Forms.TextBox TxtSuperior;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTolerancia;
        private System.Windows.Forms.Label lasdal;
        private System.Windows.Forms.TextBox TxtIter;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.GroupBox gbParametros;
    }
}
