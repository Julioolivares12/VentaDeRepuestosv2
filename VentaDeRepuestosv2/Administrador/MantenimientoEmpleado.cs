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
    public partial class MantenimientoEmpleado : VentaDeRepuestosv2.formularioBase.Mantenimientos
    {
        public MantenimientoEmpleado()
        {
            InitializeComponent();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            var cr = new CrearUsuario();
            cr.ShowDialog();
            cargarDatos();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            var id = getID();
            var ac = new ActualizarUsuario(id);
            ac.ShowDialog();
            cargarDatos();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            var i = getID();
            var rs = Consultas.EliminarUsuario(i);
            MostrarMensaje.mostarMensaje(rs,Constantes.MENSAJEDEELIMINACION);
        }

        private void MantenimientoEmpleado_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }
        public override void cargarDatos()
        {
            base.cargarDatos();
            gridDatos.DataSource = Consultas.getEmpleados();
        }
    }
}
