namespace VentaDeRepuestosv2.formularioBase
{
    partial class CrearRepuesto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbParteVehiculo = new System.Windows.Forms.ComboBox();
            this.cbMarcaVehiculo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRepuesto = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtNumMotor = new System.Windows.Forms.TextBox();
            this.txtNumChasis = new System.Windows.Forms.TextBox();
            this.txtNumVIN = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(502, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parte de vehiculo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(502, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca vehiculo";
            // 
            // cbParteVehiculo
            // 
            this.cbParteVehiculo.FormattingEnabled = true;
            this.cbParteVehiculo.Location = new System.Drawing.Point(677, 45);
            this.cbParteVehiculo.Name = "cbParteVehiculo";
            this.cbParteVehiculo.Size = new System.Drawing.Size(184, 24);
            this.cbParteVehiculo.TabIndex = 2;
            this.cbParteVehiculo.SelectedIndexChanged += new System.EventHandler(this.CbParteVehiculo_SelectedIndexChanged);
            // 
            // cbMarcaVehiculo
            // 
            this.cbMarcaVehiculo.FormattingEnabled = true;
            this.cbMarcaVehiculo.Location = new System.Drawing.Point(677, 86);
            this.cbMarcaVehiculo.Name = "cbMarcaVehiculo";
            this.cbMarcaVehiculo.Size = new System.Drawing.Size(184, 24);
            this.cbMarcaVehiculo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Precio compra";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Precio de venta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Descuento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Numero motor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Numero Chasis";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 351);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Numero VIN";
            // 
            // txtRepuesto
            // 
            this.txtRepuesto.Location = new System.Drawing.Point(225, 45);
            this.txtRepuesto.Name = "txtRepuesto";
            this.txtRepuesto.Size = new System.Drawing.Size(184, 22);
            this.txtRepuesto.TabIndex = 12;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(225, 87);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(184, 22);
            this.txtDescripcion.TabIndex = 13;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(225, 128);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(184, 22);
            this.txtPrecioCompra.TabIndex = 14;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(225, 170);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(184, 22);
            this.txtPrecioVenta.TabIndex = 15;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(225, 217);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(184, 22);
            this.txtDescuento.TabIndex = 16;
            // 
            // txtNumMotor
            // 
            this.txtNumMotor.Location = new System.Drawing.Point(225, 264);
            this.txtNumMotor.Name = "txtNumMotor";
            this.txtNumMotor.Size = new System.Drawing.Size(184, 22);
            this.txtNumMotor.TabIndex = 17;
            // 
            // txtNumChasis
            // 
            this.txtNumChasis.Location = new System.Drawing.Point(225, 310);
            this.txtNumChasis.Name = "txtNumChasis";
            this.txtNumChasis.Size = new System.Drawing.Size(184, 22);
            this.txtNumChasis.TabIndex = 18;
            // 
            // txtNumVIN
            // 
            this.txtNumVIN.Location = new System.Drawing.Point(225, 351);
            this.txtNumVIN.Name = "txtNumVIN";
            this.txtNumVIN.Size = new System.Drawing.Size(184, 22);
            this.txtNumVIN.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnCrear);
            this.panel1.Location = new System.Drawing.Point(296, 519);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 97);
            this.panel1.TabIndex = 20;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(292, 24);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(157, 51);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(94, 24);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(157, 51);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(505, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 17);
            this.label11.TabIndex = 33;
            this.label11.Text = "Nuevo Repuesto";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtNumVIN);
            this.panel2.Controls.Add(this.cbParteVehiculo);
            this.panel2.Controls.Add(this.txtNumChasis);
            this.panel2.Controls.Add(this.cbMarcaVehiculo);
            this.panel2.Controls.Add(this.txtNumMotor);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtDescuento);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtPrecioVenta);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtPrecioCompra);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtDescripcion);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtRepuesto);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(88, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(953, 426);
            this.panel2.TabIndex = 34;
            // 
            // CrearRepuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 677);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Name = "CrearRepuesto";
            this.Text = "CrearRepuesto";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbParteVehiculo;
        public System.Windows.Forms.ComboBox cbMarcaVehiculo;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtRepuesto;
        public System.Windows.Forms.TextBox txtDescripcion;
        public System.Windows.Forms.TextBox txtPrecioCompra;
        public System.Windows.Forms.TextBox txtPrecioVenta;
        public System.Windows.Forms.TextBox txtDescuento;
        public System.Windows.Forms.TextBox txtNumMotor;
        public System.Windows.Forms.TextBox txtNumChasis;
        public System.Windows.Forms.TextBox txtNumVIN;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnCrear;
        public System.Windows.Forms.Panel panel2;
    }
}