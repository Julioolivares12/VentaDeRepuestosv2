using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentaDeRepuestosv2.Helpers;

namespace VentaDeRepuestosv2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var pass = Encriptar.encriptarPassword(txtPassword.Text.Trim());
            var login = Consultas.Login(txtCorreo.Text.Trim(), pass);
            if (login != null)
            {
                this.Hide();
                new Menu(login.Perfil).Show();
            }
            else
            {
                MessageBox.Show("error correo o contraseña incorrectos");
            }
        }
    }
}
