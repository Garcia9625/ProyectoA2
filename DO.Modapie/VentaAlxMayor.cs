using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO.Modapie
{
    public class VentaAlxMayor
    {

        public int IdVentaMayor { get; set; }
        public int IdClienteMayor{ get; set; }
        public string IdEmpleado { get; set; }
        public double Total { get; set; }
        public bool Estado { get; set; }
        public double SaldoPendiente { get; set; }
        public double TotalAbonado { get; set; }
        public double UltimoAbono { get; set; }
        public DateTime FechaVenta { get; set; }
    }
}
