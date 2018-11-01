using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO.Modapie
{
    public class VentaAlDetalle
    {
        
        public int? IdVentaDetalle { get; set; }
        public string IdClienteDetalle { get; set; }
        public string IdEmpleado { get; set; }
        public double Total { get; set; }
    }
}
