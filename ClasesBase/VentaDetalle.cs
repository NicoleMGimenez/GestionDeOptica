using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class VentaDetalle
    {
        public int DetalleNro { get; set; }
        public int NroVenta { get; set; }
        public string CodigoProd { get; set; }
        public string Precio { get; set; }
        public decimal Cantidad { get; set; }
        public string Total { get; set; }
    }
}
