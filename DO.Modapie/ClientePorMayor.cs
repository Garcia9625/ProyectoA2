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
        private string NombreJuridico;
        private string NombreFisico;
        private string NombreFantasia;

        public int idCliente
        {
            get { return IdCliente; }
            set { IdCliente = value; }
        }

        public string nombreJuridico
        {
            get { return NombreJuridico; }
            set { NombreJuridico = value; }
        }

        public string nombreFisico
        {
            get { return NombreFisico; }
            set { NombreFisico = value; }
        }

        public string nombreFantasia
        {
            get { return NombreFantasia; }
            set { NombreFantasia = value; }
        }
    }
}
