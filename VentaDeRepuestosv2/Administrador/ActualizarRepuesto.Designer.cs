namespace VentaDeRepuestosv2.Administrador
{
    partial class ActualizarRepuesto
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
            this.txtParteActual = new System.Windows.Forms.TextBox();
            this.txtMarcaActual = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(449, 45);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(449, 86);
            // 
            // cbParteVehiculo
            // 
            this.cbParteVehiculo.Location = new System.Drawing.Point(585, 42);
            this.cbParteVehiculo.Size = new System.Drawing.Size(184, 24);
            this.cbParteVehiculo.SelectedIndexChanged += new System.EventHandler(this.CbParteVehiculo_SelectedIndexChanged);
            // 
            // cbMarcaVehiculo
            // 
            this.cbMarcaVehiculo.Location = new System.Drawing.Point(585, 79);
            this.cbMarcaVehiculo.Size = new System.Drawing.Size(184, 24);
            this.cbMarcaVehiculo.SelectedIndexChanged += new System.EventHandler(this.CbMarcaVehiculo_SelectedIndexChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Text = "Actualizar";
            this.btnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtMarcaActual);
            this.panel2.Controls.Add(this.txtParteActual);
            this.panel2.Controls.SetChildIndex(this.label10, 0);
            this.panel2.Controls.SetChildIndex(this.label9, 0);
            this.panel2.Controls.SetChildIndex(this.txtRepuesto, 0);
            this.panel2.Controls.SetChildIndex(this.label8, 0);
            this.panel2.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.panel2.Controls.SetChildIndex(this.label7, 0);
            this.panel2.Controls.SetChildIndex(this.txtPrecioCompra, 0);
            this.panel2.Controls.SetChildIndex(this.label6, 0);
            this.panel2.Controls.SetChildIndex(this.txtPrecioVenta, 0);
            this.panel2.Controls.SetChildIndex(this.label5, 0);
            this.panel2.Controls.SetChildIndex(this.txtDescuento, 0);
            this.panel2.Controls.SetChildIndex(this.label4, 0);
            this.panel2.Controls.SetChildIndex(this.txtNumMotor, 0);
            this.panel2.Controls.SetChildIndex(this.cbMarcaVehiculo, 0);
            this.panel2.Controls.SetChildIndex(this.txtNumChasis, 0);
            this.panel2.Controls.SetChildIndex(this.cbParteVehiculo, 0);
            this.panel2.Controls.SetChildIndex(this.txtNumVIN, 0);
            this.panel2.Controls.SetChildIndex(this.label2, 0);
            this.panel2.Controls.SetChildIndex(this.label1, 0);
            this.panel2.Controls.SetChildIndex(this.label3, 0);
            this.panel2.Controls.SetChildIndex(this.txtParteActual, 0);
            this.panel2.Controls.SetChildIndex(this.txtMarcaActual, 0);
            // 
            // txtParteActual
            // 
            this.txtParteActual.Location = new System.Drawing.Point(798, 42);
            this.txtParteActual.Name = "txtParteActual";
            this.txtParteActual.Size = new System.Drawing.Size(100, 22);
            this.txtParteActual.TabIndex = 20;
            // 
            // txtMarcaActual
            // 
            this.txtMarcaActual.Location = new System.Drawing.Point(798, 79);
            this.txtMarcaActual.Name = "txtMarcaActual";
            this.txtMarcaActual.Size = new System.Drawing.Size(100, 22);
            this.txtMarcaActual.TabIndex = 21;
            // 
            // ActualizarRepuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1256, 677);
            this.Name = "ActualizarRepuesto";
            this.Load += new System.EventHandler(this.ActualizarRepuesto_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMarcaActual;
        private System.Windows.Forms.TextBox txtParteActual;
    }
}
