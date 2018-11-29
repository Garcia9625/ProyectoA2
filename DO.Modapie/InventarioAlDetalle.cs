using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO.Modapie
{
    public class InventarioAlDetalle
    {
        public int IdProducto { get; set; }

        public string Codigo { get; set; }

        public string Color { get; set; }

        public float PrecioUnitario { get; set; }

        public double Talla { get; set; }

        public string Descripcion { get; set; }

        public int Cantidad { get; set; }

        public bool Estado { get; set; }

        public void InventarioDetalle(int idP, int can)
        {
            IdProducto = idP;
            Cantidad = can;
        }

    }
}
