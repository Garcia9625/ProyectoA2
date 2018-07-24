using DO.Modapie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace BS.Modapie
{
    public class Mantenimiento : IMantenimiento
    {
        private static Mantenimiento instancia;

        public static Mantenimiento Instancia
        {
            get
            {
                if (instancia == null)
                {
                    return new Mantenimiento();
                }
                return instancia;
            }
            set
            {
                if (instancia == null)
                {
                    instancia = value;
                }
            }
        }

        public Usuario obtenerUsuarioUser(string username)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    Usuario usuario = DAL.Modapie.Mantenimiento.Instancia.obtenerUsuarioUser(username);
                    scope.Complete();
                    return usuario;
                }
            }
            catch (Exception ee)
            {
                DialogResult d = MessageBox.Show(ee.Message.ToString());
                return null;

            }
        }

        
        public int validarLogin(string username, string contrasena)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    int respuesta = DAL.Modapie.Mantenimiento.Instancia.validarLogin(username, contrasena);
                    scope.Complete();
                    return respuesta;
                }
            }
            catch (Exception ee)
            {
                DialogResult d = MessageBox.Show(ee.Message.ToString());
                return 3;

            }
        }


        public void InsertarCAlxMayor(ClienteAlxMayor CAXM)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Modapie.Mantenimiento.Instancia.InsertarCAlxMayor(CAXM);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public List<ClienteAlxMayor> MostarCAXM()
        {
            List<ClienteAlxMayor> lista = new List<ClienteAlxMayor>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = DAL.Modapie.Mantenimiento.Instancia.MostarCAXM();
                    scope.Complete();
                }
                return lista;
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public void InsertarEmpleado(Empleado empleado)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Modapie.Mantenimiento.Instancia.InsertarEmpleado(empleado);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public List<Empleado> MostrarEmpleado()
        {
            List<Empleado> lista = new List<Empleado>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = DAL.Modapie.Mantenimiento.Instancia.MostrarEmpleado();
                    scope.Complete();
                }
                return lista;
            }
            catch (Exception ee)
            {
                throw;
            }
        }
    }
}
