using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VentaDeRepuestosv2.Helpers;

namespace VentaDeRepuestosv2.Administrador
{
    public partial class MantenimientoPartesDeVehiculos : VentaDeRepuestosv2.formularioBase.Mantenimientos
    {
        public MantenimientoPartesDeVehiculos()
        {
            InitializeComponent();
            cargarDatos();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            var cr = new CrearParteDeVehiculo();
            cr.ShowDialog();
            cargarDatos();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            var i = getID();
            var actualizar = new CrearParteDeVehiculo(i);
            actualizar.ShowDialog();
            cargarDatos();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            var i = getID();
            if (!String.IsNullOrEmpty(i) && !String.IsNullOrWhiteSpace(i))
            {
                var rs = Consultas.EliminarParteVehiculo(i);
                MostrarMensaje.mostarMensaje(rs,Constantes.MENSAJEDEELIMINACION);
            }
            else
            {
                MessageBox.Show("debes seleccionar un elemento de la tabla");
            }
            


        }
        public override void cargarDatos()
        {
            base.cargarDatos();
            gridDatos.DataSource = Consultas.GetParteVehiculos();
        }
    }
}
