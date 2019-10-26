using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaDeRepuestosv2.Modelos
{
    class Pagos
    {
        public string ID_PAGO { get; set; }
        public string ID_VENTA { get; set; }
        public string TIPO { get; set; }
        public string METODO { get; set; }
        public double VALOR { get; set; }
    }
}
