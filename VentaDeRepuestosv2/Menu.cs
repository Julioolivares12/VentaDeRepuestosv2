﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentaDeRepuestosv2.Administrador;
using VentaDeRepuestosv2.Vendedor;

namespace VentaDeRepuestosv2
{
    public partial class Menu : Form
    {
        private int childFormNumber = 0;
        MantenimientoEmpleado empleados;
        MantenimientoModelosVehiculos mantenimientoModelosVehiculos;
             MantenimientoTiposVehiculos tiposVehiculos;
        MantenimientoPartesDeVehiculos partesDeVehiculos;
        MantenimientoClasesDeVehiculos clacesDeVehiculos;
        PuntoVenta puntoVenta;




        public Menu()
        {
            InitializeComponent();
        }
        public Menu(string perfil)
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MantenimientoEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (empleados == null)
            {
                empleados = new MantenimientoEmpleado();
                empleados.MdiParent = this;
                empleados.FormClosed += new FormClosedEventHandler(cerrarEmpleados);
                empleados.Show();
            }
            else
            {
                empleados.Activate();
            }
        }

        private void cerrarEmpleados(object sender, FormClosedEventArgs e)
        {
            empleados = null;
        }

        private void ModelosDeVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mantenimientoModelosVehiculos == null)
            {
                mantenimientoModelosVehiculos = new MantenimientoModelosVehiculos();
                mantenimientoModelosVehiculos.MdiParent = this;
                mantenimientoModelosVehiculos.FormClosed += new FormClosedEventHandler(cerrarModelosDeVehiculo);
                mantenimientoModelosVehiculos.Show();
            }
            else
            {
                mantenimientoModelosVehiculos.Activate();
            }
        }

        private void cerrarModelosDeVehiculo(object sender, FormClosedEventArgs e)
        {
            mantenimientoModelosVehiculos = null;
        }

        private void ClasesDeVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clacesDeVehiculos == null)
            {
                clacesDeVehiculos = new MantenimientoClasesDeVehiculos();
                clacesDeVehiculos.MdiParent = this;
                clacesDeVehiculos.FormClosed += new FormClosedEventHandler(cerrarClasesDevehiculos);
                clacesDeVehiculos.Show();
            }
            else
            {
                clacesDeVehiculos.Activate();
            }
        }

        private void cerrarClasesDevehiculos(object sender, FormClosedEventArgs e)
        {
            clacesDeVehiculos = null;
        }

        private void TiposDeVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tiposVehiculos == null)
            {
                tiposVehiculos = new MantenimientoTiposVehiculos();
                tiposVehiculos.MdiParent = this;
                tiposVehiculos.FormClosed += new FormClosedEventHandler(cerrarTiposVehiculos);
                tiposVehiculos.Show();
            }
            else
            {
                tiposVehiculos.Activate();
            }
        }

        private void cerrarTiposVehiculos(object sender, FormClosedEventArgs e)
        {
            tiposVehiculos = null;
        }

        private void PartesDeVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (partesDeVehiculos == null)
            {
                partesDeVehiculos = new MantenimientoPartesDeVehiculos();
                partesDeVehiculos.MdiParent = this;
                partesDeVehiculos.FormClosed += new FormClosedEventHandler(cerrarPartesDeVehiculos);
                partesDeVehiculos.Show();
            }
            else
            {
                partesDeVehiculos.Activate();
            }

        }

        private void cerrarPartesDeVehiculos(object sender, FormClosedEventArgs e)
        {
            partesDeVehiculos = null;
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void PuntoDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(puntoVenta== null)
            {
                puntoVenta = new PuntoVenta();
                puntoVenta.MdiParent = this;
                puntoVenta.FormClosed += new FormClosedEventHandler(cerrarPuntoVenta);
                puntoVenta.Show();
            }
        }

        private void cerrarPuntoVenta(object sender, FormClosedEventArgs e)
        {
            puntoVenta = null;
        }
    }
}
