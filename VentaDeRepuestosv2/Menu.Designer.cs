namespace VentaDeRepuestosv2
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.puntoDeVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelosDeVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clasesDeVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partesDeVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.puntoDeVentaToolStripMenuItem,
            this.mantenimientosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(843, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // puntoDeVentaToolStripMenuItem
            // 
            this.puntoDeVentaToolStripMenuItem.Name = "puntoDeVentaToolStripMenuItem";
            this.puntoDeVentaToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.puntoDeVentaToolStripMenuItem.Text = "punto de venta";
            this.puntoDeVentaToolStripMenuItem.Click += new System.EventHandler(this.PuntoDeVentaToolStripMenuItem_Click);
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoEmpleadosToolStripMenuItem,
            this.modelosDeVehiculoToolStripMenuItem,
            this.clasesDeVehiculoToolStripMenuItem,
            this.tiposDeVehiculosToolStripMenuItem,
            this.partesDeVehiculosToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.mantenimientosToolStripMenuItem.Text = "mantenimientos";
            // 
            // mantenimientoEmpleadosToolStripMenuItem
            // 
            this.mantenimientoEmpleadosToolStripMenuItem.Name = "mantenimientoEmpleadosToolStripMenuItem";
            this.mantenimientoEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.mantenimientoEmpleadosToolStripMenuItem.Text = "Mantenimiento empleados";
            this.mantenimientoEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.MantenimientoEmpleadosToolStripMenuItem_Click);
            // 
            // modelosDeVehiculoToolStripMenuItem
            // 
            this.modelosDeVehiculoToolStripMenuItem.Name = "modelosDeVehiculoToolStripMenuItem";
            this.modelosDeVehiculoToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.modelosDeVehiculoToolStripMenuItem.Text = "Modelos de vehiculo";
            this.modelosDeVehiculoToolStripMenuItem.Click += new System.EventHandler(this.ModelosDeVehiculoToolStripMenuItem_Click);
            // 
            // clasesDeVehiculoToolStripMenuItem
            // 
            this.clasesDeVehiculoToolStripMenuItem.Name = "clasesDeVehiculoToolStripMenuItem";
            this.clasesDeVehiculoToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.clasesDeVehiculoToolStripMenuItem.Text = "Clases de vehiculo";
            this.clasesDeVehiculoToolStripMenuItem.Click += new System.EventHandler(this.ClasesDeVehiculoToolStripMenuItem_Click);
            // 
            // tiposDeVehiculosToolStripMenuItem
            // 
            this.tiposDeVehiculosToolStripMenuItem.Name = "tiposDeVehiculosToolStripMenuItem";
            this.tiposDeVehiculosToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.tiposDeVehiculosToolStripMenuItem.Text = "Tipos de vehiculos";
            this.tiposDeVehiculosToolStripMenuItem.Click += new System.EventHandler(this.TiposDeVehiculosToolStripMenuItem_Click);
            // 
            // partesDeVehiculosToolStripMenuItem
            // 
            this.partesDeVehiculosToolStripMenuItem.Name = "partesDeVehiculosToolStripMenuItem";
            this.partesDeVehiculosToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.partesDeVehiculosToolStripMenuItem.Text = "Partes de vehiculos";
            this.partesDeVehiculosToolStripMenuItem.Click += new System.EventHandler(this.PartesDeVehiculosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.salirToolStripMenuItem.Text = "salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Location = new System.Drawing.Point(0, 536);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(843, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem puntoDeVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelosDeVehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clasesDeVehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partesDeVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}



