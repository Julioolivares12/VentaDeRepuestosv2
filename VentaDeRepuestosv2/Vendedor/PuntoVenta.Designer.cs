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
            this.components = new System.ComponentModel.Container();
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
            this.btnDar = new System.Windows.Forms.Button();
            this.txtDar = new System.Windows.Forms.TextBox();
            this.txtTomar = new System.Windows.Forms.TextBox();
            this.btnTomar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbMetodo2 = new System.Windows.Forms.ComboBox();
            this.mETODOSDARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repuestosDataSet = new VentaDeRepuestosv2.repuestosDataSet();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbMetodo1 = new System.Windows.Forms.ComboBox();
            this.mETODOSTOMARBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.tIPODOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.mETODOSTOMARTableAdapter = new VentaDeRepuestosv2.repuestosDataSetTableAdapters.METODOSTOMARTableAdapter();
            this.mETODOSDARTableAdapter = new VentaDeRepuestosv2.repuestosDataSetTableAdapters.METODOSDARTableAdapter();
            this.tIPODOCTableAdapter = new VentaDeRepuestosv2.repuestosDataSetTableAdapters.TIPODOCTableAdapter();
            this.UPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCUENTO1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_UNITARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REMOVER = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mETODOSDARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repuestosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mETODOSTOMARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPODOCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPagar
            // 
            this.btnPagar.Enabled = false;
            this.btnPagar.Location = new System.Drawing.Point(662, 506);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(91, 23);
            this.btnPagar.TabIndex = 74;
            this.btnPagar.Text = "SOLO PAGAR";
            this.btnPagar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(758, 506);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(108, 23);
            this.btnLimpiar.TabIndex = 73;
            this.btnLimpiar.Text = "LIMPIAR TODO";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnPagarImprimir
            // 
            this.btnPagarImprimir.Enabled = false;
            this.btnPagarImprimir.Location = new System.Drawing.Point(539, 506);
            this.btnPagarImprimir.Name = "btnPagarImprimir";
            this.btnPagarImprimir.Size = new System.Drawing.Size(117, 23);
            this.btnPagarImprimir.TabIndex = 72;
            this.btnPagarImprimir.Text = "PAGAR E IMPRIMIR";
            this.btnPagarImprimir.UseVisualStyleBackColor = true;
            this.btnPagarImprimir.Click += new System.EventHandler(this.btnPagarImprimir_Click);
            // 
            // dgvPagos
            // 
            this.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TIPO,
            this.METODO,
            this.VALOR,
            this.QUITAR});
            this.dgvPagos.Location = new System.Drawing.Point(12, 474);
            this.dgvPagos.Name = "dgvPagos";
            this.dgvPagos.RowHeadersWidth = 51;
            this.dgvPagos.Size = new System.Drawing.Size(520, 98);
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
            this.txtConsolidado.Enabled = false;
            this.txtConsolidado.Location = new System.Drawing.Point(746, 421);
            this.txtConsolidado.Name = "txtConsolidado";
            this.txtConsolidado.Size = new System.Drawing.Size(121, 20);
            this.txtConsolidado.TabIndex = 70;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(632, 428);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 69;
            this.label12.Text = "CONSOLIDADO";
            // 
            // btnDar
            // 
            this.btnDar.Enabled = false;
            this.btnDar.Location = new System.Drawing.Point(359, 436);
            this.btnDar.Name = "btnDar";
            this.btnDar.Size = new System.Drawing.Size(114, 23);
            this.btnDar.TabIndex = 68;
            this.btnDar.Text = "DAR VUELTO";
            this.btnDar.UseVisualStyleBackColor = true;
            this.btnDar.Click += new System.EventHandler(this.btnDar_Click);
            // 
            // txtDar
            // 
            this.txtDar.Location = new System.Drawing.Point(88, 438);
            this.txtDar.Name = "txtDar";
            this.txtDar.Size = new System.Drawing.Size(121, 20);
            this.txtDar.TabIndex = 67;
            // 
            // txtTomar
            // 
            this.txtTomar.Location = new System.Drawing.Point(88, 408);
            this.txtTomar.Name = "txtTomar";
            this.txtTomar.Size = new System.Drawing.Size(121, 20);
            this.txtTomar.TabIndex = 66;
            // 
            // btnTomar
            // 
            this.btnTomar.Enabled = false;
            this.btnTomar.Location = new System.Drawing.Point(359, 406);
            this.btnTomar.Name = "btnTomar";
            this.btnTomar.Size = new System.Drawing.Size(117, 23);
            this.btnTomar.TabIndex = 65;
            this.btnTomar.Text = "TOMAR PAGO";
            this.btnTomar.UseVisualStyleBackColor = true;
            this.btnTomar.Click += new System.EventHandler(this.btnTomar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 438);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 64;
            this.label11.Text = "DAR";
            // 
            // cmbMetodo2
            // 
            this.cmbMetodo2.DataSource = this.mETODOSDARBindingSource;
            this.cmbMetodo2.DisplayMember = "METODO";
            this.cmbMetodo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetodo2.FormattingEnabled = true;
            this.cmbMetodo2.Location = new System.Drawing.Point(230, 438);
            this.cmbMetodo2.Name = "cmbMetodo2";
            this.cmbMetodo2.Size = new System.Drawing.Size(121, 21);
            this.cmbMetodo2.TabIndex = 63;
            this.cmbMetodo2.ValueMember = "ID_METODO";
            // 
            // mETODOSDARBindingSource
            // 
            this.mETODOSDARBindingSource.DataMember = "METODOSDAR";
            this.mETODOSDARBindingSource.DataSource = this.repuestosDataSet;
            // 
            // repuestosDataSet
            // 
            this.repuestosDataSet.DataSetName = "repuestosDataSet";
            this.repuestosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 411);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 62;
            this.label10.Text = "TOMAR";
            // 
            // cmbMetodo1
            // 
            this.cmbMetodo1.DataSource = this.mETODOSTOMARBindingSource;
            this.cmbMetodo1.DisplayMember = "METODO";
            this.cmbMetodo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetodo1.FormattingEnabled = true;
            this.cmbMetodo1.Location = new System.Drawing.Point(230, 408);
            this.cmbMetodo1.Name = "cmbMetodo1";
            this.cmbMetodo1.Size = new System.Drawing.Size(121, 21);
            this.cmbMetodo1.TabIndex = 61;
            this.cmbMetodo1.ValueMember = "ID_METODO";
            // 
            // mETODOSTOMARBindingSource
            // 
            this.mETODOSTOMARBindingSource.DataMember = "METODOSTOMAR";
            this.mETODOSTOMARBindingSource.DataSource = this.repuestosDataSet;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(746, 332);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(121, 20);
            this.txtSubtotal.TabIndex = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(652, 339);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 59;
            this.label9.Text = "SUBTOTAL: $";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Enabled = false;
            this.txtMontoTotal.Location = new System.Drawing.Point(746, 358);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(121, 20);
            this.txtMontoTotal.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(632, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 57;
            this.label8.Text = "MONTO TOTAL: $";
            // 
            // txtIva
            // 
            this.txtIva.Enabled = false;
            this.txtIva.Location = new System.Drawing.Point(746, 306);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(121, 20);
            this.txtIva.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(692, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "IVA: $";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(38, 306);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(494, 96);
            this.richTextBox1.TabIndex = 54;
            this.richTextBox1.Text = "";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(617, 107);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(121, 20);
            this.txtDescuento.TabIndex = 52;
            // 
            // btnClienteNuevo
            // 
            this.btnClienteNuevo.BackgroundImage = global::VentaDeRepuestosv2.Properties.Resources.plus;
            this.btnClienteNuevo.Location = new System.Drawing.Point(285, 52);
            this.btnClienteNuevo.Name = "btnClienteNuevo";
            this.btnClienteNuevo.Size = new System.Drawing.Size(34, 31);
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
            this.DESCUENTO1,
            this.PRECIO_UNITARIO,
            this.PRECIO_TOTAL,
            this.REMOVER});
            this.dgvItems.Location = new System.Drawing.Point(12, 150);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.Size = new System.Drawing.Size(880, 150);
            this.dgvItems.TabIndex = 53;
            // 
            // btnBuscarItem
            // 
            this.btnBuscarItem.BackgroundImage = global::VentaDeRepuestosv2.Properties.Resources.lupa1;
            this.btnBuscarItem.Location = new System.Drawing.Point(440, 102);
            this.btnBuscarItem.Name = "btnBuscarItem";
            this.btnBuscarItem.Size = new System.Drawing.Size(36, 34);
            this.btnBuscarItem.TabIndex = 50;
            this.btnBuscarItem.UseVisualStyleBackColor = true;
            this.btnBuscarItem.Click += new System.EventHandler(this.BtnBuscarItem_Click);
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(154, 111);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(280, 20);
            this.txtItem.TabIndex = 49;
            this.txtItem.TextChanged += new System.EventHandler(this.txtItem_TextChanged);
            this.txtItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItem_KeyDown);
            this.txtItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItem_KeyPress);
            this.txtItem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtItem_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "BUSCAR REPUESTO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(496, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "DESCUENTO GLOBAL";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackgroundImage = global::VentaDeRepuestosv2.Properties.Resources.lupa1;
            this.btnBuscarCliente.Location = new System.Drawing.Point(245, 52);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(34, 35);
            this.btnBuscarCliente.TabIndex = 46;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(617, 21);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(121, 20);
            this.txtFecha.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(535, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "FECHA VENTA";
            // 
            // txtTracking
            // 
            this.txtTracking.Location = new System.Drawing.Point(374, 21);
            this.txtTracking.Name = "txtTracking";
            this.txtTracking.Size = new System.Drawing.Size(121, 20);
            this.txtTracking.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "TRACKING N°";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(118, 61);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(121, 20);
            this.txtCliente.TabIndex = 41;
            this.txtCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCliente_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "CLIENTE";
            // 
            // cmbDocumento
            // 
            this.cmbDocumento.DataSource = this.tIPODOCBindingSource;
            this.cmbDocumento.DisplayMember = "DESCRIPCION";
            this.cmbDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDocumento.FormattingEnabled = true;
            this.cmbDocumento.Location = new System.Drawing.Point(118, 21);
            this.cmbDocumento.Name = "cmbDocumento";
            this.cmbDocumento.Size = new System.Drawing.Size(121, 21);
            this.cmbDocumento.TabIndex = 38;
            this.cmbDocumento.ValueMember = "ID_TIPODOC";
            // 
            // tIPODOCBindingSource
            // 
            this.tIPODOCBindingSource.DataMember = "TIPODOC";
            this.tIPODOCBindingSource.DataSource = this.repuestosDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "DOCUMENTO";
            // 
            // mETODOSTOMARTableAdapter
            // 
            this.mETODOSTOMARTableAdapter.ClearBeforeFill = true;
            // 
            // mETODOSDARTableAdapter
            // 
            this.mETODOSDARTableAdapter.ClearBeforeFill = true;
            // 
            // tIPODOCTableAdapter
            // 
            this.tIPODOCTableAdapter.ClearBeforeFill = true;
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
            // DESCUENTO1
            // 
            this.DESCUENTO1.HeaderText = "DESCUENTO";
            this.DESCUENTO1.Name = "DESCUENTO1";
            // 
            // PRECIO_UNITARIO
            // 
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
            // PuntoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 593);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnPagarImprimir);
            this.Controls.Add(this.dgvPagos);
            this.Controls.Add(this.txtConsolidado);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnDar);
            this.Controls.Add(this.txtDar);
            this.Controls.Add(this.txtTomar);
            this.Controls.Add(this.btnTomar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbMetodo2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbMetodo1);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PuntoVenta";
            this.Text = "PuntoVenta";
            this.Load += new System.EventHandler(this.PuntoVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mETODOSDARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repuestosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mETODOSTOMARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPODOCBindingSource)).EndInit();
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
        private System.Windows.Forms.Button btnDar;
        private System.Windows.Forms.TextBox txtDar;
        private System.Windows.Forms.TextBox txtTomar;
        private System.Windows.Forms.Button btnTomar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbMetodo2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbMetodo1;
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
        private repuestosDataSet repuestosDataSet;
        private System.Windows.Forms.BindingSource mETODOSTOMARBindingSource;
        private repuestosDataSetTableAdapters.METODOSTOMARTableAdapter mETODOSTOMARTableAdapter;
        private System.Windows.Forms.BindingSource mETODOSDARBindingSource;
        private repuestosDataSetTableAdapters.METODOSDARTableAdapter mETODOSDARTableAdapter;
        private System.Windows.Forms.BindingSource tIPODOCBindingSource;
        private repuestosDataSetTableAdapters.TIPODOCTableAdapter tIPODOCTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCUENTO1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_UNITARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_TOTAL;
        private System.Windows.Forms.DataGridViewButtonColumn REMOVER;
    }
}