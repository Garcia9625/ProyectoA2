using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO.Modapie
{
    public class VentaXDetalle
    {
        public int IdDetalleVentaDetalle { get; set; }

        public int IdVentaDetalle { get; set; }

        public int IdProducto { get; set; }

        public int Cantidad { get; set; }

        public double PrecioUnitario { get; set; }

        public double Total { get; set; }
    }
}
