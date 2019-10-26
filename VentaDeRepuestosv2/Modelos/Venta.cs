using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaDeRepuestosv2.Modelos
{
    class Venta
    {
        public string ID_VENTA { get; set; }
        public string ID_USUARIO { get; set; }
        public string ID_CLIENTE { get; set; }
        public string ID_REPUESTOS { get; set; }
        public string NRODOC { get; set; }
        public string ID_TIPODOC { get; set; }
        public string NRO_CF { get; set; }
        public DateTime FECHA_VENTA { get; set; }
        public double SUBTOTAL { get; set; }
        public double DESCUENTO { get; set; }
        public double IVA { get; set; }
        public double MONTOTOTAL { get; set; }
    }
}
