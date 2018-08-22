using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO.Modapie
{
    public class ClienteAlDetalle
    {
        private string Dni;
        private string Nombre;
        private string Apellido1;
        private string Apellido2;

        private string Celular;
        private string Telefono;
        private string Correo;

        public ClienteAlDetalle(string dni, string nombre, string apellido1, string apellido2, string celular, string telefono, string correo)
        {
            Dni = dni;
            Nombre = nombre;
            Apellido1 = apellido1;
            Apellido2 = apellido2;
            Celular = celular;
            Telefono = telefono;
            Correo = correo;
        }

        public ClienteAlDetalle()
        {
        }

        public string Dni1 { get => Dni; set => Dni = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellido11 { get => Apellido1; set => Apellido1 = value; }
        public string Apellido21 { get => Apellido2; set => Apellido2 = value; }
        public string Celular1 { get => Celular; set => Celular = value; }
        public string Telefono1 { get => Telefono; set => Telefono = value; }
        public string Correo1 { get => Correo; set => Correo = value; }
    }
}
