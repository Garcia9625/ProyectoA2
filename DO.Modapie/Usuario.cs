using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO.Modapie
{
    public class Usuario
    {
        private int IdUsuario;
        private int IdEmpleado;
        private string Username;
        private string Password;
        private int Rol;

        //prueba de subida

        public int idUsuario
        {
            get { return IdUsuario; }
            set { IdUsuario = value; }
        }

        public int idEmpleado
        {
            get { return IdEmpleado; }
            set { IdEmpleado = value; }
        }

        public int rol
        {
            get { return Rol; }
            set { Rol = value; }
        }

        public string username
        {
            get { return Username; }
            set { Username = value; }
        }

        public string password
        {
            get { return Password; }
            set { Password = value; }
        }
    }
}
