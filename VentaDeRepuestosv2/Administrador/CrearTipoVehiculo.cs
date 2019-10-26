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
    public partial class CrearTipoVehiculo : VentaDeRepuestosv2.formularioBase.CrearModeloVehiculo
    {
        public CrearTipoVehiculo()
        {
            InitializeComponent();
        }
        public CrearTipoVehiculo(string id)
        {
            if (!String.IsNullOrEmpty(id) && !String.IsNullOrWhiteSpace(id))
            {
                ID = id;
                var mod = Consultas.GetTipoVehiculoByID(id);
                txtDescripcion.Text = mod.DESCRIPCION;
                btnCrear.Text = "Actualizar";
            }
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            if (ID != null)
            {
                var mod = new TipoVehiculo();
                mod.ID = ID;
                mod.DESCRIPCION = txtDescripcion.Text;
                var r = Consultas.ActualizarTipoVehiculo(mod);
                if (r)
                {
                    MessageBox.Show("Actualizado");
                }
                else
                {
                    MessageBox.Show("Ocurrio un error");
                }
            }
            else
            {
                var mod = new TipoVehiculo();
                mod.ID = Guid.NewGuid().ToString();
                mod.DESCRIPCION = txtDescripcion.Text;
                var r = Consultas.InsertarTipoVehiculo(mod);

                if (r)
                {
                    MessageBox.Show("creado con exito");
                }
                else
                {
                    MessageBox.Show("ocurrio un error");
                }
            }
        }

        private void CrearTipoVehiculo_Load(object sender, EventArgs e)
        {

        }
    }
}
