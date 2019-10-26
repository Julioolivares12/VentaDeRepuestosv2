using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaDeRepuestosv2.Modelos
{
    class DetalleVenta
    {
        public string ID_DETALLEVENTA { get; set; }
        public string ID_VENTA { get; set; }
        public string ID_REPUESTO { get; set; }
        public int CANTIDAD { get; set; }
        public double PRECIOUNITARIO { get; set; }
        public double SUBTOTALREPUESTO { get; set; }
        public double DESCUENTO { get; set; }
        public double IVA { get; set; }
        public double TOTALREPUESTO { get; set; }

    }
}
