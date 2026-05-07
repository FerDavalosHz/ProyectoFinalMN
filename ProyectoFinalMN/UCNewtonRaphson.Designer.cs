namespace ProyectoFinalMN
{
    partial class UCNewtonRaphson
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
            this.TxtX0 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.las = new System.Windows.Forms.Label();
            this.DtgDatos = new System.Windows.Forms.DataGridView();
            this.Raiz = new System.Windows.Forms.Label();
            this.TxtRaiz = new System.Windows.Forms.TextBox();
            this.pGrafica = new System.Windows.Forms.Panel();
            this.BtnGraficar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rIA = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.AutoSize = true;
            this.BtnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(146)))), ((int)(((byte)(154)))));
            this.BtnCalcular.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.Location = new System.Drawing.Point(7, 219);
            this.BtnCalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(423, 59);
            this.BtnCalcular.TabIndex = 23;
            this.BtnCalcular.Text = "CALCULAR";
            this.BtnCalcular.UseVisualStyleBackColor = false;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // TxtIter
            // 
            this.TxtIter.Location = new System.Drawing.Point(304, 159);
            this.TxtIter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtIter.Name = "TxtIter";
            this.TxtIter.Size = new System.Drawing.Size(88, 34);
            this.TxtIter.TabIndex = 22;
            // 
            // lasdal
            // 
            this.lasdal.AutoSize = true;
            this.lasdal.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lasdal.Location = new System.Drawing.Point(51, 162);
            this.lasdal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lasdal.Name = "lasdal";
            this.lasdal.Size = new System.Drawing.Size(222, 19);
            this.lasdal.TabIndex = 21;
            this.lasdal.Text = "Maximo numero de iteraciones";
            // 
            // TxtTolerancia
            // 
            this.TxtTolerancia.Location = new System.Drawing.Point(219, 102);
            this.TxtTolerancia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtTolerancia.Name = "TxtTolerancia";
            this.TxtTolerancia.Size = new System.Drawing.Size(173, 34);
            this.TxtTolerancia.TabIndex = 18;
            // 
            // TxtX0
            // 
            this.TxtX0.Location = new System.Drawing.Point(219, 51);
            this.TxtX0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtX0.Name = "TxtX0";
            this.TxtX0.Size = new System.Drawing.Size(173, 34);
            this.TxtX0.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tolerancia %   .*";
            // 
            // las
            // 
            this.las.AutoSize = true;
            this.las.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.las.Location = new System.Drawing.Point(47, 54);
            this.las.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.las.Name = "las";
            this.las.Size = new System.Drawing.Size(47, 19);
            this.las.TabIndex = 15;
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
            this.DtgDatos.Location = new System.Drawing.Point(477, 18);
            this.DtgDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DtgDatos.Name = "DtgDatos";
            this.DtgDatos.RowHeadersWidth = 51;
            this.DtgDatos.Size = new System.Drawing.Size(653, 687);
            this.DtgDatos.TabIndex = 14;
            // 
            // Raiz
            // 
            this.Raiz.AutoSize = true;
            this.Raiz.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Raiz.Location = new System.Drawing.Point(90, 16);
            this.Raiz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Raiz.Name = "Raiz";
            this.Raiz.Size = new System.Drawing.Size(55, 25);
            this.Raiz.TabIndex = 13;
            this.Raiz.Text = "Raiz";
            // 
            // TxtRaiz
            // 
            this.TxtRaiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(235)))), ((int)(((byte)(202)))));
            this.TxtRaiz.Location = new System.Drawing.Point(153, 16);
            this.TxtRaiz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtRaiz.Multiline = true;
            this.TxtRaiz.Name = "TxtRaiz";
            this.TxtRaiz.ReadOnly = true;
            this.TxtRaiz.Size = new System.Drawing.Size(219, 27);
            this.TxtRaiz.TabIndex = 12;
            // 
            // pGrafica
            // 
            this.pGrafica.Location = new System.Drawing.Point(1156, 18);
            this.pGrafica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pGrafica.Name = "pGrafica";
            this.pGrafica.Size = new System.Drawing.Size(513, 798);
            this.pGrafica.TabIndex = 24;
            // 
            // BtnGraficar
            // 
            this.BtnGraficar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(146)))), ((int)(((byte)(154)))));
            this.BtnGraficar.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGraficar.Location = new System.Drawing.Point(898, 576);
            this.BtnGraficar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnGraficar.Name = "BtnGraficar";
            this.BtnGraficar.Size = new System.Drawing.Size(156, 46);
            this.BtnGraficar.TabIndex = 25;
            this.BtnGraficar.Text = "GRAFICAR";
            this.BtnGraficar.UseVisualStyleBackColor = false;
            this.BtnGraficar.Visible = false;
            this.BtnGraficar.Click += new System.EventHandler(this.BtnGraficar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 364);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(335, 26);
            this.label3.TabIndex = 27;
            this.label3.Text = "DETALLES DEL PROBLEMA";
            // 
            // rIA
            // 
            this.rIA.BackColor = System.Drawing.Color.White;
            this.rIA.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rIA.Location = new System.Drawing.Point(31, 395);
            this.rIA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rIA.Name = "rIA";
            this.rIA.ReadOnly = true;
            this.rIA.Size = new System.Drawing.Size(433, 421);
            this.rIA.TabIndex = 26;
            this.rIA.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.BtnCalcular);
            this.groupBox1.Controls.Add(this.TxtIter);
            this.groupBox1.Controls.Add(this.lasdal);
            this.groupBox1.Controls.Add(this.TxtTolerancia);
            this.groupBox1.Controls.Add(this.TxtX0);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.las);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 285);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuracion de Metodo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Raiz);
            this.panel1.Controls.Add(this.TxtRaiz);
            this.panel1.Location = new System.Drawing.Point(477, 741);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 64);
            this.panel1.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(481, 713);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "RESULTADO";
            // 
            // UCNewtonRaphson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rIA);
            this.Controls.Add(this.pGrafica);
            this.Controls.Add(this.DtgDatos);
            this.Controls.Add(this.BtnGraficar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UCNewtonRaphson";
            this.Size = new System.Drawing.Size(1691, 828);
            this.Load += new System.EventHandler(this.UCNewtonRaphson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.TextBox TxtIter;
        private System.Windows.Forms.Label lasdal;
        private System.Windows.Forms.TextBox TxtTolerancia;
        private System.Windows.Forms.TextBox TxtX0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label las;
        private System.Windows.Forms.DataGridView DtgDatos;
        private System.Windows.Forms.Label Raiz;
        private System.Windows.Forms.TextBox TxtRaiz;
        private System.Windows.Forms.Panel pGrafica;
        private System.Windows.Forms.Button BtnGraficar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rIA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}
