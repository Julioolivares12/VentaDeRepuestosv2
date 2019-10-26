using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaDeRepuestosv2.Modelos
{
    class Ventas
    {
        public string ID_VENTA { get; set; }
        public string ID_USUARIO { get; set; }
        public string ID_Cliente { get; set; }
        public string NRODOC { get; set; }
        public string ID_TIPODOC { get; set; }
        public string FECHAVENTA { get; set; }
        public string NRO_CF { get; set; }
        public double SUBTOTAL { get; set; }
        public double MONTOTOTAL { get; set; }
        public double IVA { get; set; }
        public double DESCUENTO { get; set; }
    }
}
