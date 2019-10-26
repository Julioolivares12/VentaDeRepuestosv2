using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VentaDeRepuestosv2.Helpers;
using VentaDeRepuestosv2.Modelos;

namespace VentaDeRepuestosv2.Administrador
{
    public partial class CrearRepuesto : VentaDeRepuestosv2.formularioBase.CrearRepuesto
    {
        public string Marca { get; set; }
        public string Parte { get; set; }
        public CrearRepuesto()
        {
            InitializeComponent();
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            var mod = new Repuesto();
            mod.ID = Guid.NewGuid().ToString();
            mod.ID_MARCAVEH = Marca;
            mod.ID_PARTEVEH = Parte;
            mod.Nombe = txtRepuesto.Text.Trim();
            mod.Descripcion = txtDescripcion.Text;
            mod.Descuento = Convert.ToDouble(txtDescuento.Text);
            mod.PrecioCompra = Convert.ToDouble(txtPrecioCompra.Text);
            mod.PrecioVenta = Convert.ToDouble(txtPrecioVenta.Text);
            mod.NumChasis = Convert.ToInt32(txtNumChasis.Text);
            mod.NumMotor = Convert.ToInt32(txtNumMotor.Text);
            mod.NumVin = Convert.ToInt32(txtNumVIN.Text);

            var rs = Consultas.InsertarRepuesto(mod);
            MostrarMensaje.mostarMensaje(rs,Constantes.MENSAJEDEEXITO);
            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CbParteVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var i = cbParteVehiculo.SelectedIndex;
            Parte = cbParteVehiculo.Items[i].ToString();
        }

        private void CbMarcaVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var i = cbMarcaVehiculo.SelectedIndex;
            Marca = cbMarcaVehiculo.Items[i].ToString();
        }

        private void CrearRepuesto_Load(object sender, EventArgs e)
        {
            cargarMarcas();
            cargarPartes();
        }
    }
}
