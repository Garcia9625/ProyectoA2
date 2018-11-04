using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO.Modapie
{
    public class ProductoDetalle
    {
        public int IdProducto { get; set; }
        
        public string Codigo { get; set; }

        public float PrecioUnitario { get; set; }

        public string Color { get; set; }

        public float Talla { get; set; }

        public string Descripcion { get; set; }

        public int Cantidad { get; set; }

        public Boolean Estado { get; set; }
    }
}