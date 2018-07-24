using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO.Modapie
{
    public class Empleado
    {

        public string Dni { get; set; }

        public string Nombre { get; set; }

        public string Apellido1 { get; set; }

        public string Apellido2 { get; set; }

        public string Celular { get; set; }

        public string Telefono { get; set; }

        public string Correo { get; set; }

        public string DireccionDomicilio { get; set; }

        public double SalarioMensual { get; set; }

        public DateTime FechaContratacion { get; set; }

        public DateTime FechaSalida { get; set; }

        public bool Estado { get; set; }

    }
}
