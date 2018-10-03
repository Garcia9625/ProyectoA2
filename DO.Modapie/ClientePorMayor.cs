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
        private string Telefono;
        private string Correo;
        private string Cedula;
        private Boolean Estado;

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

        public string telefono
        {
            get { return Telefono; }
            set { Telefono = value; }
        }

        public string correo
        {
            get { return Correo; }
            set { Correo = value; }
        }
        public string cedula
        {
            get { return Cedula; }
            set { Cedula = value; }
        }
        public Boolean estado
        {
            get { return Estado; }
            set { Estado = value; }
        }

    }
}
