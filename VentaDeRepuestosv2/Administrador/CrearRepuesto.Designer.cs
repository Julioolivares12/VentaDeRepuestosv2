namespace VentaDeRepuestosv2.Administrador
{
    partial class CrearRepuesto
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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbParteVehiculo
            // 
            this.cbParteVehiculo.Size = new System.Drawing.Size(184, 24);
            this.cbParteVehiculo.SelectedIndexChanged += new System.EventHandler(this.CbParteVehiculo_SelectedIndexChanged);
            // 
            // cbMarcaVehiculo
            // 
            this.cbMarcaVehiculo.Size = new System.Drawing.Size(184, 24);
            this.cbMarcaVehiculo.SelectedIndexChanged += new System.EventHandler(this.CbMarcaVehiculo_SelectedIndexChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // CrearRepuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1256, 677);
            this.Name = "CrearRepuesto";
            this.Load += new System.EventHandler(this.CrearRepuesto_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
