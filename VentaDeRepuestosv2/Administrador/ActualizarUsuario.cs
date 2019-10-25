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
    public partial class ActualizarUsuario : VentaDeRepuestosv2.formularioBase.CrearEmpleado
    {
        string ID_USUARIO;
        public ActualizarUsuario()
        {
            InitializeComponent();
        }
        public ActualizarUsuario(string id)
        {
            InitializeComponent();
            if (id != null)
            {
                ID_USUARIO = id;
            }
        }
        public void carDatos()
        {
            var query = "SELECT U.ID_USUARIO U.PRIMERNOMBRE,U.SEGUNDONOMBRE,U.PRIMERAPELLIDO,U.SEGUNDOAPELLIDO,U.DIRECCION,U.TELEFONO" +
                ",U.FECHANAC,U.SEXO,U.ESTADO_CIVIL,U.EMAIL, P.NOMBRE AS PERFIL,C.NOMBRE AS CARGO FROM USUARIOS AS U INNER JOIN PERFIL AS P" +
                " ON U.ID_PERFIL = P.ID_PERFIL INNER JOIN CARGOS AS C ON U.ID_CARGO = C.ID_CARGO WHERE U.ID_USUARIO=@ID_USUARIO";
            // SqlParameter parameter = new SqlParameter("@ID_USUARIO",ID_USUARIO);

            var result = Consultas.getEmpleadoByID(query, ID_USUARIO);
            // var result = Consultas.ExecuteReader(query,CommandType.Text,parameter);
            if (result.Read())
            {
                var usuario = new Usuario();
                usuario.ID = result.GetString(0);
                usuario.PrimerNombre = result.GetString(1);
                usuario.SegundoNombre = result.GetString(2);
                usuario.PrimerApellido = result.GetString(3);
                usuario.SegundoApellido = result.GetString(4);
                usuario.Direccion = result.GetString(5);
                usuario.Telefono = result.GetString(6);
                usuario.FechaNac = result.GetString(7);
                usuario.Sexo = Convert.ToChar(result.GetString(8));
                usuario.EstadoCivil = Convert.ToChar(result.GetString(9));
                usuario.Email = result.GetString(10);
                usuario.ID_PERFIL = result.GetString(11);
                usuario.ID_CARGO = result.GetString(12);

                txtPrimerNombre.Text = usuario.PrimerNombre;
                txtSegundoNombre.Text = usuario.SegundoNombre;
                txtPrimerApellido.Text = usuario.PrimerApellido;
                txtSegundoApellido.Text = usuario.SegundoApellido;
                txtDireccion.Text = usuario.Direccion;
                txtTelefono.Text = usuario.Telefono;
                txtFechaNac.Text = usuario.FechaNac;
                txtSexoActual.Text = usuario.Sexo.ToString();
                txtEstadoActual.Text = usuario.EstadoCivil.ToString();
                txtPerfilActual.Text = usuario.ID_PERFIL;
                txtCargoActual.Text = usuario.ID_CARGO;

            }
        }
        private void BtnCrear_Click(object sender, EventArgs e)
        {
            var mod = new Usuario();
            mod.ID = ID_USUARIO;
            mod.ID_CARGO = Id_cargo;
            mod.ID_PERFIL = Id_pefil;
            mod.PrimerNombre = txtPrimerNombre.Text;
            mod.SegundoNombre = txtSegundoNombre.Text;
            mod.PrimerApellido = txtPrimerApellido.Text;
            mod.SegundoApellido = txtSegundoApellido.Text;
            mod.Direccion = txtDireccion.Text;
            mod.Telefono = txtTelefono.Text;
            mod.FechaNac = txtFechaNac.Text;
            mod.Sexo = s;
            mod.EstadoCivil = est;
            

            var rs = Consultas.ActualizarUsuario(mod);
            if (rs>0)
            {
                
                MostrarMensaje.mostarMensaje(true,Constantes.MENSAJEDEACTUALIZACION);
            }
            else
            {
                MostrarMensaje.mostarMensaje(false,Constantes.MENSAJEDEERROR);
            }
        }

        private void TxtEstadoActual_TextChanged(object sender, EventArgs e)
        {

        }

        private void CbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var i = cbSexo.SelectedIndex;
            s = Convert.ToChar(cbSexo.Items[i].ToString());
        }

        private void CbEstadoCivil_SelectedIndexChanged(object sender, EventArgs e)
        {
            var i = cbEstadoCivil.SelectedIndex;
            est = Convert.ToChar(cbEstadoCivil.Items[i].ToString());
        }

        private void CbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Id_cargo = cbCargo.SelectedValue.ToString();
        }

        private void CbPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            Id_pefil = cbPerfil.SelectedValue.ToString();
        }

        private void ActualizarUsuario_Load(object sender, EventArgs e)
        {
            carDatos();
            cargarCargos();
            cargarPerfiles();
        }
    }
}
