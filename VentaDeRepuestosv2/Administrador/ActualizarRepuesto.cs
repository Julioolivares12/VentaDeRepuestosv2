using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VentaDeRepuestosv2.Modelos;

namespace VentaDeRepuestosv2.Administrador
{
    public partial class ActualizarRepuesto : VentaDeRepuestosv2.formularioBase.CrearRepuesto
    {
        public string Marca { get; set; }
        public string Parte { get; set; }
        public ActualizarRepuesto()
        {
            InitializeComponent();
        }
        public ActualizarRepuesto(string id)
        {
            InitializeComponent();
            if(!String.IsNullOrEmpty(id) && !String.IsNullOrWhiteSpace(id))
            {
                var mod = Consultas.GetRepuestoByID(id);
                
                txtDescripcion.Text = mod.Descripcion;
                txtDescuento.Text = mod.Descuento.ToString();
                txtNumChasis.Text = mod.NumChasis.ToString();
                txtNumMotor.Text = mod.NumMotor.ToString();
                txtNumVIN.Text = mod.NumVin.ToString();
                txtPrecioCompra.Text = mod.PrecioCompra.ToString();
                txtPrecioVenta.Text = mod.PrecioVenta.ToString();
                txtRepuesto.Text = mod.Nombe;
                txtParteActual.Text = mod.ID_PARTEVEH;
                txtMarcaActual.Text = mod.ID_MARCAVEH;


            }
        }

        private void ActualizarRepuesto_Load(object sender, EventArgs e)
        {
            cargarMarcas();
            cargarPartes();
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            var mod =new Repuesto();

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
    }
}
