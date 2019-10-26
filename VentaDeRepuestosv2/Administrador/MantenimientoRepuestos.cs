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
    public partial class MantenimientoRepuestos : VentaDeRepuestosv2.formularioBase.Mantenimientos
    {
        public MantenimientoRepuestos()
        {
            InitializeComponent();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            var crear = new CrearRepuesto();
            crear.ShowDialog();
            cargarDatos();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            var i = getID();
            var actualizar = new ActualizarRepuesto(i);
            actualizar.ShowDialog();
            cargarDatos();

            
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            var i = getID();
            var rs = Consultas.EliminarRepuesto(i);
            MostrarMensaje.mostarMensaje(rs,Constantes.MENSAJEDEELIMINACION);
        }

        private void MantenimientoRepuestos_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }
        public override void cargarDatos()
        {
            base.cargarDatos();
            gridDatos.DataSource = Consultas.GetRepuestos();
        }
    }
}
