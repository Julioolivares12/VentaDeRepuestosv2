namespace VentaDeRepuestosv2.Administrador
{
    partial class ActualizarUsuario
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
            this.txtEstadoActual = new System.Windows.Forms.TextBox();
            this.txtSexoActual = new System.Windows.Forms.TextBox();
            this.txtPerfilActual = new System.Windows.Forms.TextBox();
            this.txtCargoActual = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCrear.FlatAppearance.BorderSize = 2;
            this.btnCrear.Text = "Actualizar";
            this.btnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // cbPerfil
            // 
            this.cbPerfil.Size = new System.Drawing.Size(128, 24);
            this.cbPerfil.SelectedIndexChanged += new System.EventHandler(this.CbPerfil_SelectedIndexChanged);
            // 
            // cbCargo
            // 
            this.cbCargo.Size = new System.Drawing.Size(128, 24);
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
            // txtEstadoActual
            // 
            this.txtEstadoActual.Location = new System.Drawing.Point(283, 399);
            this.txtEstadoActual.Name = "txtEstadoActual";
            this.txtEstadoActual.Size = new System.Drawing.Size(52, 22);
            this.txtEstadoActual.TabIndex = 79;
            this.txtEstadoActual.TextChanged += new System.EventHandler(this.TxtEstadoActual_TextChanged);
            // 
            // txtSexoActual
            // 
            this.txtSexoActual.Location = new System.Drawing.Point(283, 351);
            this.txtSexoActual.Name = "txtSexoActual";
            this.txtSexoActual.Size = new System.Drawing.Size(52, 22);
            this.txtSexoActual.TabIndex = 78;
            // 
            // txtPerfilActual
            // 
            this.txtPerfilActual.Location = new System.Drawing.Point(652, 157);
            this.txtPerfilActual.Name = "txtPerfilActual";
            this.txtPerfilActual.Size = new System.Drawing.Size(148, 22);
            this.txtPerfilActual.TabIndex = 81;
            // 
            // txtCargoActual
            // 
            this.txtCargoActual.Location = new System.Drawing.Point(652, 102);
            this.txtCargoActual.Name = "txtCargoActual";
            this.txtCargoActual.Size = new System.Drawing.Size(148, 22);
            this.txtCargoActual.TabIndex = 80;
            // 
            // ActualizarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPerfilActual);
            this.Controls.Add(this.txtCargoActual);
            this.Controls.Add(this.txtEstadoActual);
            this.Controls.Add(this.txtSexoActual);
            this.Name = "ActualizarUsuario";
            this.Load += new System.EventHandler(this.ActualizarUsuario_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtPrimerNombre, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtSegundoNombre, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtPrimerApellido, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtSegundoApellido, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtDireccion, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtTelefono, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtFechaNac, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.cbSexo, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.cbEstadoCivil, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.txtEmail, 0);
            this.Controls.SetChildIndex(this.cbCargo, 0);
            this.Controls.SetChildIndex(this.cbPerfil, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.btnCrear, 0);
            this.Controls.SetChildIndex(this.txtSexoActual, 0);
            this.Controls.SetChildIndex(this.txtEstadoActual, 0);
            this.Controls.SetChildIndex(this.txtCargoActual, 0);
            this.Controls.SetChildIndex(this.txtPerfilActual, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEstadoActual;
        private System.Windows.Forms.TextBox txtSexoActual;
        private System.Windows.Forms.TextBox txtPerfilActual;
        private System.Windows.Forms.TextBox txtCargoActual;
    }
}
