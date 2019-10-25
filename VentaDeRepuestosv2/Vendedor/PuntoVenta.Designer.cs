namespace VentaDeRepuestosv2.Vendedor
{
    partial class PuntoVenta
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
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnPagarImprimir = new System.Windows.Forms.Button();
            this.dgvPagos = new System.Windows.Forms.DataGridView();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.METODO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUITAR = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtConsolidado = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbMetodo2 = new System.Windows.Forms.Button();
            this.txtDar = new System.Windows.Forms.TextBox();
            this.txtTomar = new System.Windows.Forms.TextBox();
            this.cmbMetodo1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.btnClienteNuevo = new System.Windows.Forms.Button();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.UPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCUENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_UNITARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REMOVER = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBuscarItem = new System.Windows.Forms.Button();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTracking = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDocumento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(882, 623);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(121, 28);
            this.btnPagar.TabIndex = 74;
            this.btnPagar.Text = "SOLO PAGAR";
            this.btnPagar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(1011, 623);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(144, 28);
            this.btnLimpiar.TabIndex = 73;
            this.btnLimpiar.Text = "LIMPIAR TODO";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnPagarImprimir
            // 
            this.btnPagarImprimir.Location = new System.Drawing.Point(718, 623);
            this.btnPagarImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btnPagarImprimir.Name = "btnPagarImprimir";
            this.btnPagarImprimir.Size = new System.Drawing.Size(156, 28);
            this.btnPagarImprimir.TabIndex = 72;
            this.btnPagarImprimir.Text = "PAGAR E IMPRIMIR";
            this.btnPagarImprimir.UseVisualStyleBackColor = true;
            // 
            // dgvPagos
            // 
            this.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TIPO,
            this.METODO,
            this.VALOR,
            this.QUITAR});
            this.dgvPagos.Location = new System.Drawing.Point(51, 583);
            this.dgvPagos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPagos.Name = "dgvPagos";
            this.dgvPagos.RowHeadersWidth = 51;
            this.dgvPagos.Size = new System.Drawing.Size(659, 121);
            this.dgvPagos.TabIndex = 71;
            // 
            // TIPO
            // 
            this.TIPO.Frozen = true;
            this.TIPO.HeaderText = "TIPO";
            this.TIPO.MinimumWidth = 6;
            this.TIPO.Name = "TIPO";
            this.TIPO.ReadOnly = true;
            this.TIPO.Width = 125;
            // 
            // METODO
            // 
            this.METODO.Frozen = true;
            this.METODO.HeaderText = "METODO";
            this.METODO.MinimumWidth = 6;
            this.METODO.Name = "METODO";
            this.METODO.ReadOnly = true;
            this.METODO.Width = 125;
            // 
            // VALOR
            // 
            this.VALOR.Frozen = true;
            this.VALOR.HeaderText = "VALOR";
            this.VALOR.MinimumWidth = 6;
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            this.VALOR.Width = 125;
            // 
            // QUITAR
            // 
            this.QUITAR.Frozen = true;
            this.QUITAR.HeaderText = "QUITAR";
            this.QUITAR.MinimumWidth = 6;
            this.QUITAR.Name = "QUITAR";
            this.QUITAR.ReadOnly = true;
            this.QUITAR.Width = 125;
            // 
            // txtConsolidado
            // 
            this.txtConsolidado.Location = new System.Drawing.Point(994, 518);
            this.txtConsolidado.Margin = new System.Windows.Forms.Padding(4);
            this.txtConsolidado.Name = "txtConsolidado";
            this.txtConsolidado.Size = new System.Drawing.Size(160, 22);
            this.txtConsolidado.TabIndex = 70;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(842, 527);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 17);
            this.label12.TabIndex = 69;
            this.label12.Text = "CONSOLIDADO";
            // 
            // cmbMetodo2
            // 
            this.cmbMetodo2.Location = new System.Drawing.Point(479, 537);
            this.cmbMetodo2.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMetodo2.Name = "cmbMetodo2";
            this.cmbMetodo2.Size = new System.Drawing.Size(152, 28);
            this.cmbMetodo2.TabIndex = 68;
            this.cmbMetodo2.Text = "DAR VUELTO";
            this.cmbMetodo2.UseVisualStyleBackColor = true;
            // 
            // txtDar
            // 
            this.txtDar.Location = new System.Drawing.Point(117, 539);
            this.txtDar.Margin = new System.Windows.Forms.Padding(4);
            this.txtDar.Name = "txtDar";
            this.txtDar.Size = new System.Drawing.Size(160, 22);
            this.txtDar.TabIndex = 67;
            // 
            // txtTomar
            // 
            this.txtTomar.Location = new System.Drawing.Point(117, 502);
            this.txtTomar.Margin = new System.Windows.Forms.Padding(4);
            this.txtTomar.Name = "txtTomar";
            this.txtTomar.Size = new System.Drawing.Size(160, 22);
            this.txtTomar.TabIndex = 66;
            // 
            // cmbMetodo1
            // 
            this.cmbMetodo1.Location = new System.Drawing.Point(479, 500);
            this.cmbMetodo1.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMetodo1.Name = "cmbMetodo1";
            this.cmbMetodo1.Size = new System.Drawing.Size(156, 28);
            this.cmbMetodo1.TabIndex = 65;
            this.cmbMetodo1.Text = "TOMAR PAGO";
            this.cmbMetodo1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 539);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 17);
            this.label11.TabIndex = 64;
            this.label11.Text = "DAR";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(306, 539);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(160, 24);
            this.comboBox3.TabIndex = 63;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 506);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 17);
            this.label10.TabIndex = 62;
            this.label10.Text = "TOMAR";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(306, 502);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 24);
            this.comboBox2.TabIndex = 61;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(994, 409);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(160, 22);
            this.txtSubtotal.TabIndex = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(870, 417);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 17);
            this.label9.TabIndex = 59;
            this.label9.Text = "SUBTOTAL: $";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Location = new System.Drawing.Point(994, 441);
            this.txtMontoTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(160, 22);
            this.txtMontoTotal.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(842, 449);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 17);
            this.label8.TabIndex = 57;
            this.label8.Text = "MONTO TOTAL: $";
            // 
            // txtIva
            // 
            this.txtIva.Location = new System.Drawing.Point(994, 377);
            this.txtIva.Margin = new System.Windows.Forms.Padding(4);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(160, 22);
            this.txtIva.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(923, 385);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 55;
            this.label7.Text = "IVA: $";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(51, 377);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(657, 117);
            this.richTextBox1.TabIndex = 54;
            this.richTextBox1.Text = "";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(823, 132);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(160, 22);
            this.txtDescuento.TabIndex = 52;
            // 
            // btnClienteNuevo
            // 
            this.btnClienteNuevo.BackgroundImage = global::VentaDeRepuestosv2.Properties.Resources.plus;
            this.btnClienteNuevo.Location = new System.Drawing.Point(380, 64);
            this.btnClienteNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnClienteNuevo.Name = "btnClienteNuevo";
            this.btnClienteNuevo.Size = new System.Drawing.Size(45, 38);
            this.btnClienteNuevo.TabIndex = 47;
            this.btnClienteNuevo.UseVisualStyleBackColor = true;
            this.btnClienteNuevo.Click += new System.EventHandler(this.BtnClienteNuevo_Click);
            // 
            // dgvItems
            // 
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UPC,
            this.DESCRIPCION,
            this.CANTIDAD,
            this.DESCUENTO,
            this.PRECIO_UNITARIO,
            this.PRECIO_TOTAL,
            this.REMOVER});
            this.dgvItems.Location = new System.Drawing.Point(39, 185);
            this.dgvItems.Margin = new System.Windows.Forms.Padding(4);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.Size = new System.Drawing.Size(1116, 185);
            this.dgvItems.TabIndex = 53;
            // 
            // UPC
            // 
            this.UPC.Frozen = true;
            this.UPC.HeaderText = "UPC";
            this.UPC.MinimumWidth = 6;
            this.UPC.Name = "UPC";
            this.UPC.ReadOnly = true;
            this.UPC.Width = 125;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.Frozen = true;
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.MinimumWidth = 6;
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            this.DESCRIPCION.Width = 125;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.Frozen = true;
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.MinimumWidth = 6;
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.Width = 125;
            // 
            // DESCUENTO
            // 
            this.DESCUENTO.Frozen = true;
            this.DESCUENTO.HeaderText = "DESCUENTO";
            this.DESCUENTO.MinimumWidth = 6;
            this.DESCUENTO.Name = "DESCUENTO";
            this.DESCUENTO.Width = 125;
            // 
            // PRECIO_UNITARIO
            // 
            this.PRECIO_UNITARIO.Frozen = true;
            this.PRECIO_UNITARIO.HeaderText = "PRECIO UNITARIO";
            this.PRECIO_UNITARIO.MinimumWidth = 6;
            this.PRECIO_UNITARIO.Name = "PRECIO_UNITARIO";
            this.PRECIO_UNITARIO.ReadOnly = true;
            this.PRECIO_UNITARIO.Width = 125;
            // 
            // PRECIO_TOTAL
            // 
            this.PRECIO_TOTAL.HeaderText = "PRECIO TOTAL";
            this.PRECIO_TOTAL.MinimumWidth = 6;
            this.PRECIO_TOTAL.Name = "PRECIO_TOTAL";
            this.PRECIO_TOTAL.Width = 125;
            // 
            // REMOVER
            // 
            this.REMOVER.HeaderText = "REMOVER";
            this.REMOVER.MinimumWidth = 6;
            this.REMOVER.Name = "REMOVER";
            this.REMOVER.Width = 125;
            // 
            // btnBuscarItem
            // 
            this.btnBuscarItem.BackgroundImage = global::VentaDeRepuestosv2.Properties.Resources.lupa1;
            this.btnBuscarItem.Location = new System.Drawing.Point(587, 126);
            this.btnBuscarItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarItem.Name = "btnBuscarItem";
            this.btnBuscarItem.Size = new System.Drawing.Size(48, 42);
            this.btnBuscarItem.TabIndex = 50;
            this.btnBuscarItem.UseVisualStyleBackColor = true;
            this.btnBuscarItem.Click += new System.EventHandler(this.BtnBuscarItem_Click);
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(206, 137);
            this.txtItem.Margin = new System.Windows.Forms.Padding(4);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(372, 22);
            this.txtItem.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 17);
            this.label5.TabIndex = 48;
            this.label5.Text = "BUSCAR REPUESTO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(662, 139);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 17);
            this.label6.TabIndex = 51;
            this.label6.Text = "DESCUENTO GLOBAL";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackgroundImage = global::VentaDeRepuestosv2.Properties.Resources.lupa1;
            this.btnBuscarCliente.Location = new System.Drawing.Point(327, 64);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(45, 43);
            this.btnBuscarCliente.TabIndex = 46;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(823, 26);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(4);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(160, 22);
            this.txtFecha.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(713, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "FECHA VENTA";
            // 
            // txtTracking
            // 
            this.txtTracking.Location = new System.Drawing.Point(499, 26);
            this.txtTracking.Margin = new System.Windows.Forms.Padding(4);
            this.txtTracking.Name = "txtTracking";
            this.txtTracking.Size = new System.Drawing.Size(160, 22);
            this.txtTracking.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "TRACKING N°";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(158, 75);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(160, 22);
            this.txtCliente.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "CLIENTE";
            // 
            // cmbDocumento
            // 
            this.cmbDocumento.FormattingEnabled = true;
            this.cmbDocumento.Location = new System.Drawing.Point(158, 26);
            this.cmbDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDocumento.Name = "cmbDocumento";
            this.cmbDocumento.Size = new System.Drawing.Size(160, 24);
            this.cmbDocumento.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "DOCUMENTO";
            // 
            // PuntoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 730);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnPagarImprimir);
            this.Controls.Add(this.dgvPagos);
            this.Controls.Add(this.txtConsolidado);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbMetodo2);
            this.Controls.Add(this.txtDar);
            this.Controls.Add(this.txtTomar);
            this.Controls.Add(this.cmbMetodo1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMontoTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIva);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.btnClienteNuevo);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.btnBuscarItem);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTracking);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDocumento);
            this.Controls.Add(this.label1);
            this.Name = "PuntoVenta";
            this.Text = "PuntoVenta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnPagarImprimir;
        private System.Windows.Forms.DataGridView dgvPagos;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn METODO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.DataGridViewButtonColumn QUITAR;
        private System.Windows.Forms.TextBox txtConsolidado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button cmbMetodo2;
        private System.Windows.Forms.TextBox txtDar;
        private System.Windows.Forms.TextBox txtTomar;
        private System.Windows.Forms.Button cmbMetodo1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Button btnClienteNuevo;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCUENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_UNITARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_TOTAL;
        private System.Windows.Forms.DataGridViewButtonColumn REMOVER;
        private System.Windows.Forms.Button btnBuscarItem;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTracking;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDocumento;
        private System.Windows.Forms.Label label1;
    }
}