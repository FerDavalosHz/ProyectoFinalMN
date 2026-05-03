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
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.TxtIter = new System.Windows.Forms.TextBox();
            this.lasdal = new System.Windows.Forms.Label();
            this.TxtTolerancia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSuperior = new System.Windows.Forms.TextBox();
            this.TxtInferior = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.las = new System.Windows.Forms.Label();
            this.DtgDatos = new System.Windows.Forms.DataGridView();
            this.Raiz = new System.Windows.Forms.Label();
            this.TxtRaiz = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(201, 213);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(75, 23);
            this.BtnCalcular.TabIndex = 23;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click_1);
            // 
            // TxtIter
            // 
            this.TxtIter.Location = new System.Drawing.Point(209, 161);
            this.TxtIter.Name = "TxtIter";
            this.TxtIter.Size = new System.Drawing.Size(67, 20);
            this.TxtIter.TabIndex = 22;
            // 
            // lasdal
            // 
            this.lasdal.AutoSize = true;
            this.lasdal.Location = new System.Drawing.Point(53, 164);
            this.lasdal.Name = "lasdal";
            this.lasdal.Size = new System.Drawing.Size(150, 13);
            this.lasdal.TabIndex = 21;
            this.lasdal.Text = "Maximo numero de iteraciones";
            // 
            // TxtTolerancia
            // 
            this.TxtTolerancia.Location = new System.Drawing.Point(145, 114);
            this.TxtTolerancia.Name = "TxtTolerancia";
            this.TxtTolerancia.Size = new System.Drawing.Size(131, 20);
            this.TxtTolerancia.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tolerancia. *";
            // 
            // TxtSuperior
            // 
            this.TxtSuperior.Location = new System.Drawing.Point(145, 81);
            this.TxtSuperior.Name = "TxtSuperior";
            this.TxtSuperior.Size = new System.Drawing.Size(131, 20);
            this.TxtSuperior.TabIndex = 18;
            // 
            // TxtInferior
            // 
            this.TxtInferior.Location = new System.Drawing.Point(145, 40);
            this.TxtInferior.Name = "TxtInferior";
            this.TxtInferior.Size = new System.Drawing.Size(131, 20);
            this.TxtInferior.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Limite superior. *";
            // 
            // las
            // 
            this.las.AutoSize = true;
            this.las.Location = new System.Drawing.Point(50, 43);
            this.las.Name = "las";
            this.las.Size = new System.Drawing.Size(78, 13);
            this.las.TabIndex = 15;
            this.las.Text = "Limite inferior. *";
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
            this.DtgDatos.Size = new System.Drawing.Size(652, 333);
            this.DtgDatos.TabIndex = 14;
            // 
            // Raiz
            // 
            this.Raiz.AutoSize = true;
            this.Raiz.Location = new System.Drawing.Point(384, 371);
            this.Raiz.Name = "Raiz";
            this.Raiz.Size = new System.Drawing.Size(28, 13);
            this.Raiz.TabIndex = 13;
            this.Raiz.Text = "Raiz";
            // 
            // TxtRaiz
            // 
            this.TxtRaiz.Location = new System.Drawing.Point(418, 358);
            this.TxtRaiz.Multiline = true;
            this.TxtRaiz.Name = "TxtRaiz";
            this.TxtRaiz.ReadOnly = true;
            this.TxtRaiz.Size = new System.Drawing.Size(165, 37);
            this.TxtRaiz.TabIndex = 12;
            // 
            // UCFalsaPos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxtIter);
            this.Controls.Add(this.lasdal);
            this.Controls.Add(this.TxtTolerancia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtSuperior);
            this.Controls.Add(this.TxtInferior);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.las);
            this.Controls.Add(this.DtgDatos);
            this.Controls.Add(this.Raiz);
            this.Controls.Add(this.TxtRaiz);
            this.Name = "UCFalsaPos";
            this.Size = new System.Drawing.Size(1042, 697);
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.TextBox TxtIter;
        private System.Windows.Forms.Label lasdal;
        private System.Windows.Forms.TextBox TxtTolerancia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSuperior;
        private System.Windows.Forms.TextBox TxtInferior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label las;
        private System.Windows.Forms.DataGridView DtgDatos;
        private System.Windows.Forms.Label Raiz;
        private System.Windows.Forms.TextBox TxtRaiz;
    }
}
