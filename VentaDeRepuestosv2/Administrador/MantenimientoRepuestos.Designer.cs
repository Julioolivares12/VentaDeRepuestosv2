namespace VentaDeRepuestosv2.Administrador
{
    partial class MantenimientoRepuestos
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
            this.txtNumVin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumChasis = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNumMotor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVentaRespuest = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecioVentaResp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecioCompraResp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescripRepuest = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombRepuest = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbParteVehi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMarcaVehi = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(593, 234);
            this.panel1.Size = new System.Drawing.Size(280, 76);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // txtNumVin
            // 
            this.txtNumVin.Location = new System.Drawing.Point(443, 12);
            this.txtNumVin.Name = "txtNumVin";
            this.txtNumVin.Size = new System.Drawing.Size(150, 20);
            this.txtNumVin.TabIndex = 144;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(338, 16);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 143;
            this.label8.Text = "Numero Vin";
            // 
            // txtNumChasis
            // 
            this.txtNumChasis.Location = new System.Drawing.Point(443, 95);
            this.txtNumChasis.Name = "txtNumChasis";
            this.txtNumChasis.Size = new System.Drawing.Size(150, 20);
            this.txtNumChasis.TabIndex = 142;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(338, 99);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 141;
            this.label11.Text = "Numero Chasis";
            // 
            // txtNumMotor
            // 
            this.txtNumMotor.Location = new System.Drawing.Point(443, 51);
            this.txtNumMotor.Name = "txtNumMotor";
            this.txtNumMotor.Size = new System.Drawing.Size(150, 20);
            this.txtNumMotor.TabIndex = 140;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 55);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 139;
            this.label6.Text = "Numero Motor";
            // 
            // txtVentaRespuest
            // 
            this.txtVentaRespuest.Location = new System.Drawing.Point(150, 174);
            this.txtVentaRespuest.Name = "txtVentaRespuest";
            this.txtVentaRespuest.Size = new System.Drawing.Size(150, 20);
            this.txtVentaRespuest.TabIndex = 138;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 178);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 137;
            this.label7.Text = "Descuento";
            // 
            // txtPrecioVentaResp
            // 
            this.txtPrecioVentaResp.Location = new System.Drawing.Point(150, 136);
            this.txtPrecioVentaResp.Name = "txtPrecioVentaResp";
            this.txtPrecioVentaResp.Size = new System.Drawing.Size(150, 20);
            this.txtPrecioVentaResp.TabIndex = 136;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 135;
            this.label4.Text = "Precio Venta";
            // 
            // txtPrecioCompraResp
            // 
            this.txtPrecioCompraResp.Location = new System.Drawing.Point(150, 94);
            this.txtPrecioCompraResp.Name = "txtPrecioCompraResp";
            this.txtPrecioCompraResp.Size = new System.Drawing.Size(150, 20);
            this.txtPrecioCompraResp.TabIndex = 134;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 133;
            this.label5.Text = "Precio Compra";
            // 
            // txtDescripRepuest
            // 
            this.txtDescripRepuest.Location = new System.Drawing.Point(150, 54);
            this.txtDescripRepuest.Name = "txtDescripRepuest";
            this.txtDescripRepuest.Size = new System.Drawing.Size(150, 20);
            this.txtDescripRepuest.TabIndex = 132;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 131;
            this.label3.Text = "Descripcion";
            // 
            // txtNombRepuest
            // 
            this.txtNombRepuest.Location = new System.Drawing.Point(150, 12);
            this.txtNombRepuest.Name = "txtNombRepuest";
            this.txtNombRepuest.Size = new System.Drawing.Size(150, 20);
            this.txtNombRepuest.TabIndex = 130;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 129;
            this.label2.Text = "Nombre Repuesto";
            // 
            // cbParteVehi
            // 
            this.cbParteVehi.FormattingEnabled = true;
            this.cbParteVehi.Items.AddRange(new object[] {
            "C",
            "S"});
            this.cbParteVehi.Location = new System.Drawing.Point(443, 134);
            this.cbParteVehi.Margin = new System.Windows.Forms.Padding(2);
            this.cbParteVehi.Name = "cbParteVehi";
            this.cbParteVehi.Size = new System.Drawing.Size(150, 21);
            this.cbParteVehi.TabIndex = 128;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 127;
            this.label1.Text = "Parte Vehiculo";
            // 
            // cbMarcaVehi
            // 
            this.cbMarcaVehi.FormattingEnabled = true;
            this.cbMarcaVehi.Items.AddRange(new object[] {
            "C",
            "S"});
            this.cbMarcaVehi.Location = new System.Drawing.Point(443, 178);
            this.cbMarcaVehi.Margin = new System.Windows.Forms.Padding(2);
            this.cbMarcaVehi.Name = "cbMarcaVehi";
            this.cbMarcaVehi.Size = new System.Drawing.Size(156, 21);
            this.cbMarcaVehi.TabIndex = 126;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(338, 178);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 125;
            this.label10.Text = "Marca Vehiculo";
            // 
            // MantenimientoRepuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(874, 416);
            this.Controls.Add(this.txtNumVin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNumChasis);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNumMotor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtVentaRespuest);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrecioVentaResp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrecioCompraResp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescripRepuest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombRepuest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbParteVehi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMarcaVehi);
            this.Controls.Add(this.label10);
            this.Name = "MantenimientoRepuestos";
            this.Load += new System.EventHandler(this.MantenimientoRepuestos_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.cbMarcaVehi, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cbParteVehi, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtNombRepuest, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtDescripRepuest, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtPrecioCompraResp, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtPrecioVentaResp, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtVentaRespuest, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtNumMotor, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.txtNumChasis, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtNumVin, 0);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumVin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumChasis;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNumMotor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVentaRespuest;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrecioVentaResp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecioCompraResp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescripRepuest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombRepuest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbParteVehi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMarcaVehi;
        private System.Windows.Forms.Label label10;
    }
}
