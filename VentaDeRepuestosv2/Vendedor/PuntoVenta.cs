﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentaDeRepuestosv2.Vendedor
{
    public partial class PuntoVenta : Form
    {
        public PuntoVenta()
        {
            InitializeComponent();
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {

        }

        private void BtnClienteNuevo_Click(object sender, EventArgs e)
        {

        }

        private void BtnBuscarItem_Click(object sender, EventArgs e)
        {

        }

        private void PuntoVenta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'repuestosDataSet.TIPODOC' table. You can move, or remove it, as needed.
            this.tIPODOCTableAdapter.Fill(this.repuestosDataSet.TIPODOC);
            // TODO: This line of code loads data into the 'repuestosDataSet.METODOSDAR' table. You can move, or remove it, as needed.
            this.mETODOSDARTableAdapter.Fill(this.repuestosDataSet.METODOSDAR);
            // TODO: This line of code loads data into the 'repuestosDataSet.METODOSTOMAR' table. You can move, or remove it, as needed.
            this.mETODOSTOMARTableAdapter.Fill(this.repuestosDataSet.METODOSTOMAR);

        }
    }
}
