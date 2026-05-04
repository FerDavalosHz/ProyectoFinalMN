namespace ProyectoFinalMN
{
    partial class UCSecante
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
            this.TxtX1 = new System.Windows.Forms.TextBox();
            this.TxtX0 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.las = new System.Windows.Forms.Label();
            this.DtgDatos = new System.Windows.Forms.DataGridView();
            this.Raiz = new System.Windows.Forms.Label();
            this.TxtRaiz = new System.Windows.Forms.TextBox();
            this.pGrafica = new System.Windows.Forms.Panel();
            this.BtnGraficar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(205, 219);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(75, 23);
            this.BtnCalcular.TabIndex = 35;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click_1);
            // 
            // TxtIter
            // 
            this.TxtIter.Location = new System.Drawing.Point(213, 167);
            this.TxtIter.Name = "TxtIter";
            this.TxtIter.Size = new System.Drawing.Size(67, 20);
            this.TxtIter.TabIndex = 34;
            // 
            // lasdal
            // 
            this.lasdal.AutoSize = true;
            this.lasdal.Location = new System.Drawing.Point(57, 170);
            this.lasdal.Name = "lasdal";
            this.lasdal.Size = new System.Drawing.Size(150, 13);
            this.lasdal.TabIndex = 33;
            this.lasdal.Text = "Maximo numero de iteraciones";
            // 
            // TxtTolerancia
            // 
            this.TxtTolerancia.Location = new System.Drawing.Point(149, 120);
            this.TxtTolerancia.Name = "TxtTolerancia";
            this.TxtTolerancia.Size = new System.Drawing.Size(131, 20);
            this.TxtTolerancia.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Tolerancia %*";
            // 
            // TxtX1
            // 
            this.TxtX1.Location = new System.Drawing.Point(149, 87);
            this.TxtX1.Name = "TxtX1";
            this.TxtX1.Size = new System.Drawing.Size(131, 20);
            this.TxtX1.TabIndex = 30;
            // 
            // TxtX0
            // 
            this.TxtX0.Location = new System.Drawing.Point(149, 46);
            this.TxtX0.Name = "TxtX0";
            this.TxtX0.Size = new System.Drawing.Size(131, 20);
            this.TxtX0.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "X1. *";
            // 
            // las
            // 
            this.las.AutoSize = true;
            this.las.Location = new System.Drawing.Point(54, 49);
            this.las.Name = "las";
            this.las.Size = new System.Drawing.Size(30, 13);
            this.las.TabIndex = 27;
            this.las.Text = "X0. *";
            // 
            // DtgDatos
            // 
            this.DtgDatos.AllowUserToAddRows = false;
            this.DtgDatos.AllowUserToDeleteRows = false;
            this.DtgDatos.AllowUserToResizeColumns = false;
            this.DtgDatos.AllowUserToResizeRows = false;
            this.DtgDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDatos.Location = new System.Drawing.Point(373, 25);
            this.DtgDatos.Name = "DtgDatos";
            this.DtgDatos.Size = new System.Drawing.Size(652, 333);
            this.DtgDatos.TabIndex = 26;
            // 
            // Raiz
            // 
            this.Raiz.AutoSize = true;
            this.Raiz.Location = new System.Drawing.Point(388, 377);
            this.Raiz.Name = "Raiz";
            this.Raiz.Size = new System.Drawing.Size(28, 13);
            this.Raiz.TabIndex = 25;
            this.Raiz.Text = "Raiz";
            // 
            // TxtRaiz
            // 
            this.TxtRaiz.Location = new System.Drawing.Point(422, 364);
            this.TxtRaiz.Multiline = true;
            this.TxtRaiz.Name = "TxtRaiz";
            this.TxtRaiz.ReadOnly = true;
            this.TxtRaiz.Size = new System.Drawing.Size(165, 37);
            this.TxtRaiz.TabIndex = 24;
            // 
            // pGrafica
            // 
            this.pGrafica.Location = new System.Drawing.Point(373, 408);
            this.pGrafica.Name = "pGrafica";
            this.pGrafica.Size = new System.Drawing.Size(652, 286);
            this.pGrafica.TabIndex = 36;
            // 
            // BtnGraficar
            // 
            this.BtnGraficar.Location = new System.Drawing.Point(908, 365);
            this.BtnGraficar.Name = "BtnGraficar";
            this.BtnGraficar.Size = new System.Drawing.Size(117, 37);
            this.BtnGraficar.TabIndex = 37;
            this.BtnGraficar.Text = "Graficar";
            this.BtnGraficar.UseVisualStyleBackColor = true;
            this.BtnGraficar.Visible = false;
            this.BtnGraficar.Click += new System.EventHandler(this.BtnGraficar_Click);
            // 
            // UCSecante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnGraficar);
            this.Controls.Add(this.pGrafica);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxtIter);
            this.Controls.Add(this.lasdal);
            this.Controls.Add(this.TxtTolerancia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtX1);
            this.Controls.Add(this.TxtX0);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.las);
            this.Controls.Add(this.DtgDatos);
            this.Controls.Add(this.Raiz);
            this.Controls.Add(this.TxtRaiz);
            this.Name = "UCSecante";
            this.Size = new System.Drawing.Size(1042, 718);
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
        private System.Windows.Forms.TextBox TxtX1;
        private System.Windows.Forms.TextBox TxtX0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label las;
        private System.Windows.Forms.DataGridView DtgDatos;
        private System.Windows.Forms.Label Raiz;
        private System.Windows.Forms.TextBox TxtRaiz;
        private System.Windows.Forms.Panel pGrafica;
        private System.Windows.Forms.Button BtnGraficar;
    }
}
