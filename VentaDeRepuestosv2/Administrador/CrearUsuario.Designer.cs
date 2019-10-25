namespace VentaDeRepuestosv2.Administrador
{
    partial class CrearUsuario
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
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCrear.FlatAppearance.BorderSize = 2;
            this.btnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // cbPerfil
            // 
            this.cbPerfil.Size = new System.Drawing.Size(230, 24);
            this.cbPerfil.SelectedIndexChanged += new System.EventHandler(this.CbPerfil_SelectedIndexChanged);
            // 
            // cbCargo
            // 
            this.cbCargo.Size = new System.Drawing.Size(230, 24);
            this.cbCargo.SelectedIndexChanged += new System.EventHandler(this.CbCargo_SelectedIndexChanged);
            // 
            // cbEstadoCivil
            // 
            this.cbEstadoCivil.Size = new System.Drawing.Size(74, 24);
            this.cbEstadoCivil.SelectedIndexChanged += new System.EventHandler(this.CbEstadoCivil_SelectedIndexChanged);
            // 
            // cbSexo
            // 
            this.cbSexo.Size = new System.Drawing.Size(74, 24);
            this.cbSexo.SelectedIndexChanged += new System.EventHandler(this.CbSexo_SelectedIndexChanged);
            // 
            // CrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "CrearUsuario";
            this.Load += new System.EventHandler(this.CrearUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
