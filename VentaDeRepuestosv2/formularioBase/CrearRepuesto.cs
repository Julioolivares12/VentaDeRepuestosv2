using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentaDeRepuestosv2.formularioBase
{
    public partial class CrearRepuesto : Form
    {
        public CrearRepuesto()
        {
            InitializeComponent();
        }

        public virtual void cargarMarcas()
        {
            cbMarcaVehiculo.ValueMember = "ID_MARCAVEH";
            cbMarcaVehiculo.DisplayMember = "DESCRIPCION";
            cbMarcaVehiculo.DataSource = Consultas.getMarcas();
        }
        public virtual void cargarPartes()
        {
            cbParteVehiculo.ValueMember = "ID_PARTEVEH";
            cbParteVehiculo.DisplayMember = "DESCRIPCION";
            cbParteVehiculo.DataSource = Consultas.getPartes();
        }

        private void CbParteVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
