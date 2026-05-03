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
            this.Raiz = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtRaiz
            // 
            this.TxtRaiz.Location = new System.Drawing.Point(398, 370);
            this.TxtRaiz.Multiline = true;
            this.TxtRaiz.Name = "TxtRaiz";
            this.TxtRaiz.ReadOnly = true;
            this.TxtRaiz.Size = new System.Drawing.Size(165, 37);
            this.TxtRaiz.TabIndex = 0;
            // 
            // Raiz
            // 
            this.Raiz.AutoSize = true;
            this.Raiz.Location = new System.Drawing.Point(364, 383);
            this.Raiz.Name = "Raiz";
            this.Raiz.Size = new System.Drawing.Size(28, 13);
            this.Raiz.TabIndex = 1;
            this.Raiz.Text = "Raiz";
            // 
            // DtgDatos
            // 
            this.DtgDatos.AllowUserToAddRows = false;
            this.DtgDatos.AllowUserToDeleteRows = false;
            this.DtgDatos.AllowUserToResizeColumns = false;
            this.DtgDatos.AllowUserToResizeRows = false;
            this.DtgDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDatos.Location = new System.Drawing.Point(367, 15);
            this.DtgDatos.Name = "DtgDatos";
            this.DtgDatos.Size = new System.Drawing.Size(652, 333);
            this.DtgDatos.TabIndex = 2;
            // 
            // las
            // 
            this.las.AutoSize = true;
            this.las.Location = new System.Drawing.Point(30, 55);
            this.las.Name = "las";
            this.las.Size = new System.Drawing.Size(78, 13);
            this.las.TabIndex = 3;
            this.las.Text = "Limite inferior. *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Limite superior. *";
            // 
            // TxtInferior
            // 
            this.TxtInferior.Location = new System.Drawing.Point(125, 52);
            this.TxtInferior.Name = "TxtInferior";
            this.TxtInferior.Size = new System.Drawing.Size(131, 20);
            this.TxtInferior.TabIndex = 5;
            // 
            // TxtSuperior
            // 
            this.TxtSuperior.Location = new System.Drawing.Point(125, 93);
            this.TxtSuperior.Name = "TxtSuperior";
            this.TxtSuperior.Size = new System.Drawing.Size(131, 20);
            this.TxtSuperior.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tolerancia. *";
            // 
            // TxtTolerancia
            // 
            this.TxtTolerancia.Location = new System.Drawing.Point(125, 126);
            this.TxtTolerancia.Name = "TxtTolerancia";
            this.TxtTolerancia.Size = new System.Drawing.Size(131, 20);
            this.TxtTolerancia.TabIndex = 8;
            // 
            // lasdal
            // 
            this.lasdal.AutoSize = true;
            this.lasdal.Location = new System.Drawing.Point(33, 176);
            this.lasdal.Name = "lasdal";
            this.lasdal.Size = new System.Drawing.Size(150, 13);
            this.lasdal.TabIndex = 9;
            this.lasdal.Text = "Maximo numero de iteraciones";
            // 
            // TxtIter
            // 
            this.TxtIter.Location = new System.Drawing.Point(189, 173);
            this.TxtIter.Name = "TxtIter";
            this.TxtIter.Size = new System.Drawing.Size(67, 20);
            this.TxtIter.TabIndex = 10;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(181, 225);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(75, 23);
            this.BtnCalcular.TabIndex = 11;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // UCBiseccion
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
            this.Name = "UCBiseccion";
            this.Size = new System.Drawing.Size(1042, 697);
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtRaiz;
        private System.Windows.Forms.Label Raiz;
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
    }
}
