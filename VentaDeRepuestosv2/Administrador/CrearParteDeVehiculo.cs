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
    public partial class CrearParteDeVehiculo : VentaDeRepuestosv2.formularioBase.CrearModeloVehiculo
    {
        public CrearParteDeVehiculo()
        {
            InitializeComponent();
        }
        public CrearParteDeVehiculo(string id)
        {
            if (!String.IsNullOrEmpty(id) && !String.IsNullOrWhiteSpace(id))
            {
                ID = id;
                btnCrear.Text = "Actualizar";
                var mod = Consultas.GetParteVehiculo(id);
                txtDescripcion.Text = mod.DESCRIPCION;
            }
        }
        private void BtnCrear_Click(object sender, EventArgs e)
        {
            if (ID != null)
            {

                var mod = new ParteVehiculo();
                mod.ID = ID;
                mod.DESCRIPCION = txtDescripcion.Text;
                var rs = Consultas.ActualizarParteVehiculo(mod);
                MostrarMensaje.mostarMensaje(rs, Constantes.MENSAJEDEACTUALIZACION);
            }
            else
            {
                var mod = new ParteVehiculo();
                mod.ID = Guid.NewGuid().ToString();
                mod.DESCRIPCION = txtDescripcion.Text;
                var rs = Consultas.InsertarParteVehiculo(mod);
                MostrarMensaje.mostarMensaje(rs, Constantes.MENSAJEDEEXITO);
            }
        }
    }
}
