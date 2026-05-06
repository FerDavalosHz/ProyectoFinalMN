namespace ProyectoFinalMN
{
    partial class UCFUNC
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
            this.pEditor = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pEditor
            // 
            this.pEditor.Location = new System.Drawing.Point(0, 0);
            this.pEditor.Name = "pEditor";
            this.pEditor.Size = new System.Drawing.Size(1268, 673);
            this.pEditor.TabIndex = 0;
            // 
            // UCFUNC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pEditor);
            this.Name = "UCFUNC";
            this.Size = new System.Drawing.Size(1268, 673);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pEditor;
    }
}
