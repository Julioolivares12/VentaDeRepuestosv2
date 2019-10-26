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
        Double descuento = 0.00;
        String id_venta;
        String tracking;
        String iduser = "56f0cf9c-e0d0-4390-96f9-b7cc76725809";
        String idcliente = "aa84542e-b5c5-43e4-ae1a-3bc7dcc602af";
        String idrepuesto = "aa84542e-b5c5-43e4-ae1a-3bc7dcc602af";
        String nrodoc;
        String idTipoDoc;
        String fechaventa;





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
            txtFecha.Text = DateTime.Now.ToString("ddMMyyyy");

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
                  //  MessageBox.Show("Articulo no encontrado o no registrado", "Sin Resultados");
                   
                    fila.CreateCells(dgvItems);
                    fila.Cells[0].Value = "10000002555";
                    fila.Cells[1].Value = "Repuesto de Prueba";
                    fila.Cells[2].Value = "1";
                    fila.Cells[3].Value = "0";
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
                pagosYvueltos("TOMAR", cmbMetodo1.Text, txtTomar.Text);
                
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
                pagosYvueltos("DAR", cmbMetodo2.Text, txtDar.Text);

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

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnPagarImprimir_Click(object sender, EventArgs e)
        {
            id_venta = DateTime.Now.ToString("ddMMyyyy")+txtTracking.Text;
            //user defaul
            //cliente defaul
            //repuesto defaul
            nrodoc = txtTracking.Text;
            idTipoDoc = "1";
            tracking = txtTracking.Text;
            fechaventa = DateTime.Now.ToString("dd/MM/yyyy");
            DateTime fecha2 = DateTime.Now;

            var mod = new Venta();
            mod.ID_VENTA = id_venta;
            mod.ID_USUARIO = iduser;
            mod.ID_CLIENTE = idcliente;
            mod.ID_REPUESTOS = idrepuesto;
            mod.NRODOC = tracking;
            mod.NRO_CF = tracking;
            mod.ID_TIPODOC = idTipoDoc;
            mod.FECHA_VENTA = fecha2;
            mod.SUBTOTAL = subTotal;
            mod.DESCUENTO = descuento;
            mod.IVA = iva;
            mod.MONTOTOTAL = montoTotal;
            Int32 contador = 0;
            var r0 = Consultas2.InsertarVenta(mod);
            if (r0)
            {
                MessageBox.Show("Venta realizada con exito Trackin number" + tracking);
            }
            else
            {
                MessageBox.Show("ocurrio un error");
            }
            /*
            foreach (DataGridViewRow row in dgvPagos.Rows)
            {
                var mod3 = new Pagos();
                mod3.ID_PAGO = id_venta + "_"+contador+tracking;
                mod3.ID_VENTA = id_venta;
                mod3.TIPO = dgvPagos.Rows[contador].Cells[0].Value.ToString();
                mod3.METODO = dgvPagos.Rows[contador].Cells[1].Value.ToString();
                mod3.VALOR = Convert.ToDouble(dgvPagos.Rows[contador].Cells[2].Value.ToString());
                contador++;

                var r = Consultas2.InsertarPago(mod3);
                if (r)
                {
                    // MessageBox.Show("creado con exito");
                }
                else
                {
                    MessageBox.Show("ocurrio un error");
                }

            }

            contador = 0;
            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                var mod2 = new DetalleVenta();
                mod2.ID_DETALLEVENTA = id_venta + contador;
                mod2.ID_VENTA = id_venta;
                mod2.ID_REPUESTO = row.Cells[0].Value.ToString();
                mod2.CANTIDAD = Convert.ToInt32(dgvItems.Rows[contador].Cells[2].Value.ToString());
                mod2.PRECIOUNITARIO = Convert.ToDouble(dgvItems.Rows[contador].Cells[4].Value.ToString());
                mod2.SUBTOTALREPUESTO = Convert.ToDouble(dgvItems.Rows[contador].Cells[5].Value.ToString());
                mod2.DESCUENTO = Convert.ToDouble(dgvItems.Rows[contador].Cells[3].Value.ToString());
                mod2.IVA = Convert.ToDouble(dgvItems.Rows[contador].Cells[5].Value.ToString()) /1.13;
                mod2.TOTALREPUESTO = Convert.ToDouble(dgvItems.Rows[contador].Cells[5].Value.ToString());
                contador++;
                var r = Consultas2.InsertarDetalle(mod2);
                if (r)
                {
                   // MessageBox.Show("creado con exito");
                }
                else
                {
                    MessageBox.Show("ocurrio un error");
                }

            }
            */
            
            
         
        }

        private void txtItem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
