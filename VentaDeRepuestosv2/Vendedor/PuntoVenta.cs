using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentaDeRepuestosv2.Modelos;

namespace VentaDeRepuestosv2.Vendedor
{
    public partial class PuntoVenta : Form
    {
        Repuesto consultaItem;
       
        Double iva = 0.00;
        Double subTotal = 0.00;
        Double montoTotal = 0.00;
        Double consolidado = 0.00;
        Double tomar = 0.00;
        Double dar = 0.00;


        public PuntoVenta()
        {
            InitializeComponent();
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {

        }

        private void BtnClienteNuevo_Click(object sender, EventArgs e)
        {

        }

        private void BtnBuscarItem_Click(object sender, EventArgs e)
        {

        }

        private void PuntoVenta_Load(object sender, EventArgs e)
        {
            txtDar.Enabled = false;
            // TODO: This line of code loads data into the 'repuestosDataSet.TIPODOC' table. You can move, or remove it, as needed.
            this.tIPODOCTableAdapter.Fill(this.repuestosDataSet.TIPODOC);
            // TODO: This line of code loads data into the 'repuestosDataSet.METODOSDAR' table. You can move, or remove it, as needed.
            this.mETODOSDARTableAdapter.Fill(this.repuestosDataSet.METODOSDAR);
            // TODO: This line of code loads data into the 'repuestosDataSet.METODOSTOMAR' table. You can move, or remove it, as needed.
            this.mETODOSTOMARTableAdapter.Fill(this.repuestosDataSet.METODOSTOMAR);

        }
        private void habilitarVuelto()
        {
            txtConsolidado.Text = consolidado.ToString();
            txtDar.Text = (consolidado * -1).ToString();
            txtDar.Enabled = true;
            btnDar.Enabled = true;
            txtTomar.Text = "";
            txtTomar.Enabled = false;
            btnTomar.Enabled = false;
            
        }
        private void habilitarTomar()
        {
            txtConsolidado.Text = consolidado.ToString();
            txtTomar.Text = consolidado.ToString();
            txtTomar.Enabled = true;
            btnTomar.Enabled = true;

            btnDar.Enabled = false;
            txtDar.Text = "";
            txtDar.Enabled = false;
        }
        private void llenarTextos()
        {
            txtIva.Text = iva.ToString();
            txtSubtotal.Text = subTotal.ToString();
            txtMontoTotal.Text = montoTotal.ToString();
            txtConsolidado.Text = consolidado.ToString();
        }

        private void txtItem_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void txtItem_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void txtItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataGridViewRow fila = new DataGridViewRow();
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                consultaItem = Consultas2.GetRepuestoByUPC(txtItem.Text);
                string algo = consultaItem.UPC;

                if (txtItem.Text != algo)
                {
                    //MessageBox.Show("Articulo no encontrado o no registrado", "Sin Resultados");
                    fila.CreateCells(dgvItems);
                    fila.Cells[0].Value = "10000002555";
                    fila.Cells[1].Value = "Repuesto de Prueba";
                    fila.Cells[2].Value = "1";
                    fila.Cells[3].Value = "";
                    fila.Cells[4].Value = "50.00";
                    fila.Cells[5].Value = "50.00";
                    consolidado += 50;
                    iva += 5.75;
                    subTotal += 44.25;
                    montoTotal += 50;
                    llenarTextos();
                    habilitarTomar();
                    dgvItems.Rows.Add(fila);
                    txtItem.Text = "";
                }
                else
                {
                    fila.CreateCells(dgvItems);
                    fila.Cells[0].Value = consultaItem.UPC;
                    fila.Cells[1].Value = consultaItem.Nombe;
                    fila.Cells[2].Value = "1";
                    fila.Cells[3].Value = "" + consultaItem.Descuento;
                    fila.Cells[4].Value = "" + consultaItem.PrecioVenta;
                    fila.Cells[5].Value = "" + consultaItem.PrecioVenta;
                    consolidado += consultaItem.PrecioVenta;
                    iva += consultaItem.PrecioVenta / 1.13;
                    subTotal += consultaItem.PrecioVenta - (consultaItem.PrecioVenta / 1.13);
                    montoTotal += consultaItem.PrecioVenta;
                    llenarTextos();
                    habilitarTomar();
                    dgvItems.Rows.Add(fila);
                    txtItem.Text = "";
                }
            }
        }
        private void pagosYvueltos(String tipo, string metodo,string valor)
        {
            DataGridViewRow metods = new DataGridViewRow();
            metods.CreateCells(dgvPagos);
            metods.Cells[0].Value = tipo;
            metods.Cells[1].Value = metodo;
            metods.Cells[2].Value = valor;
            dgvPagos.Rows.Add(metods);
        }

        private void btnTomar_Click(object sender, EventArgs e)
        {

            string pattern = "^[0-9]+(\\,[0-9]{1,2})?$";
            if (Regex.IsMatch(this.txtTomar.Text, pattern))
            {
               tomar = Convert.ToDouble(txtTomar.Text);
               consolidado -= tomar;
                llenarTextos();
                pagosYvueltos("Tomar", cmbMetodo1.Text, txtTomar.Text);
                
                if(consolidado < 0.00)
                {
                    habilitarVuelto();
                }else if(consolidado > 0.00)
                {
                    habilitarTomar();
                }
                else
                {
                    btnPagarImprimir.Enabled = true;
                    btnPagar.Enabled = true;
                    iceTime();
                }

            }
            else
            {
                MessageBox.Show("Solo Numeros Porfavor");

            }


           

        }
        private void iceTime()
        {
            txtTomar.Text = "";
            txtDar.Text = "";
            txtTomar.Enabled = false;
            txtDar.Enabled = false;
            btnTomar.Enabled = false;
            btnDar.Enabled = false;
        }

        private void btnDar_Click(object sender, EventArgs e)
        {
            string pattern = "^[0-9]+(\\,[0-9]{1,2})?$";
            if (Regex.IsMatch(this.txtDar.Text, pattern))
            {
                dar = Convert.ToDouble(txtDar.Text);
                consolidado += dar;
                llenarTextos();
                pagosYvueltos("Dar", cmbMetodo2.Text, txtDar.Text);

                if (consolidado < 0.00)
                {
                    habilitarVuelto();
                }
                else if (consolidado > 0.00)
                {
                    habilitarTomar();
                }
                else
                {
                    btnPagarImprimir.Enabled = true;
                    btnPagar.Enabled = true;
                    iceTime();
                }

            }
            else
            {
                MessageBox.Show("Solo Numeros Porfavor");

            }
        }
    }
}
