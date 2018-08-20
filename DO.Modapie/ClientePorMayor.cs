using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO.Modapie
{
    public class ClientePorMayor
    {
        
            private int IdCliente;
            private string Nombre;

            public int idCliente
            {
                get { return IdCliente; }
                set { IdCliente = value; }
            }

            public string nombre
            {
                get { return Nombre; }
                set { Nombre = value; }
            }
        }
    }
