using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentaDeRepuestosv2.Modelos;

namespace VentaDeRepuestosv2.Administrador
{
    public partial class BuscarProductos : Form
    {
        public string ID_MARCA { get; set; }
        public string ID_PARTE { get; set; }

        Repuesto repuesto = new Repuesto();
        public BuscarProductos()
        {
            InitializeComponent();
        }

        private void BuscarProductos_Load(object sender, EventArgs e)
        {
            cargarMarcas();
            cargarPartes();
        }


        private void cargarMarcas()
        {
            cbMarca.DisplayMember = "DESCRIPCION";
            cbMarca.ValueMember = "ID_MARCAVEH";
            cbMarca.DataSource = Consultas.getMarcas();

        }

        private void cargarPartes()
        {
            cbPartes.ValueMember = "ID_PARTEVEH";
            cbPartes.DisplayMember = "DESCRIPCION";
            cbPartes.DataSource = Consultas.getPartes();
        }

        private void CbPartes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var i = cbPartes.SelectedIndex;
            ID_PARTE = cbPartes.Items[i].ToString();

        }

        private void CbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            var i = cbMarca.SelectedIndex;
            ID_MARCA = cbMarca.Items[i].ToString();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(ID_MARCA) && !String.IsNullOrWhiteSpace(ID_MARCA))
            {
                var mod = Consultas.GetRepuestoByID_Marca(ID_MARCA);
                gridDatos.DataSource = mod;
            }
            else if(!String.IsNullOrEmpty(ID_PARTE) && !String.IsNullOrWhiteSpace(ID_PARTE))
            {
                var mod = Consultas.GetRepuestoByID_Parte(ID_PARTE);
                gridDatos.DataSource =mod;
            }
            else if(!String.IsNullOrEmpty(ID_MARCA) && !String.IsNullOrWhiteSpace(ID_MARCA) && !String.IsNullOrEmpty(ID_PARTE) && !String.IsNullOrWhiteSpace(ID_PARTE))
            {
                gridDatos.DataSource = Consultas.GetRepuestosByID_MARCA_AND_ID_PARTE(ID_MARCA,ID_PARTE);
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            repuesto.ID    =  gridDatos.Rows[gridDatos.CurrentRow.Index].Cells[0].Value.ToString();
            repuesto.Nombe =  gridDatos.Rows[gridDatos.CurrentRow.Index].Cells[1].Value.ToString();
            repuesto.Descripcion =  gridDatos.Rows[gridDatos.CurrentRow.Index].Cells[2].Value.ToString();
            repuesto.PrecioCompra = Convert.ToDouble(gridDatos.Rows[gridDatos.CurrentRow.Index].Cells[3].Value.ToString());
            repuesto.PrecioVenta = Convert.ToDouble(gridDatos.Rows[gridDatos.CurrentRow.Index].Cells[4].Value.ToString());
            repuesto.NumMotor = Convert.ToInt32(gridDatos.Rows[gridDatos.CurrentRow.Index].Cells[5].Value.ToString());
            repuesto.NumChasis =  Convert.ToInt32(gridDatos.Rows[gridDatos.CurrentRow.Index].Cells[6].Value.ToString());
            repuesto.NumVin =  Convert.ToInt32(gridDatos.Rows[gridDatos.CurrentRow.Index].Cells[7].Value.ToString());
            repuesto.UPC =  gridDatos.Rows[gridDatos.CurrentRow.Index].Cells[8].Value.ToString();
            repuesto.Cantidad = Convert.ToInt32(gridDatos.Rows[gridDatos.CurrentRow.Index].Cells[9].Value.ToString());
            

            this.Close();
        }
    }
}
