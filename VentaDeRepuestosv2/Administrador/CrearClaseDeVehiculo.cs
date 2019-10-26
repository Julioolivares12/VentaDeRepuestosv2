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
    public partial class CrearClaseDeVehiculo : VentaDeRepuestosv2.Administrador.CrearTipoVehiculo
    {
       
        public CrearClaseDeVehiculo()
        {
            InitializeComponent();
        }
        public CrearClaseDeVehiculo(string id)
        {
            InitializeComponent();
            if (!String.IsNullOrEmpty(id) && !String.IsNullOrWhiteSpace(id))
            {
                ID = id;
                btnCrear.Text = "Actualizar";
                var mod = Consultas.GetClaseDeVehiculoByID(id);
                txtDescripcion.Text = mod.Descripcion;
            }
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(ID) && !String.IsNullOrWhiteSpace(ID))
            {
                var mod = new ClaseDeVehiculo();
                mod.ID = ID;
                mod.Descripcion = txtDescripcion.Text;
                var rs = Consultas.ActualizarClaseVehiculo(mod);
                MostrarMensaje.mostarMensaje(rs,Constantes.MENSAJEDEACTUALIZACION);
                this.Close();
            }
            else
            {
                var mod = new ClaseDeVehiculo();
                mod.ID = Guid.NewGuid().ToString();
                mod.Descripcion = txtDescripcion.Text;
                var rs = Consultas.InsertarClaseVehiculo(mod);
                MostrarMensaje.mostarMensaje(rs,Constantes.MENSAJEDEEXITO);
                this.Close();
            }
        }

        private void CrearClaseDeVehiculo_Load(object sender, EventArgs e)
        {

        }
    }
}
