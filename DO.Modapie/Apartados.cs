using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO.Modapie
{
    public class Apartados
    {
        public int IdApartado { get; set; }

        public string IdClienteDetalle { get; set; }

        public string IdEmpleado { get; set; }

        public double Total { get; set; }

        public double Saldo { get; set; }

        public bool Cancelado { get; set; }

        public bool Vencimiento { get; set; }

        public DateTime Ingreso { get; set; }

        public DateTime FechaVencimiento { get; set; }

    }
}
