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

        #region Login
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
        #endregion


        #region ClienteAlxMayor
        public void InsertarCAlxMayor(ClientePorMayor CAXM)
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

        public List<ClientePorMayor> MostarCAXM()
        {
            List<ClientePorMayor> lista = new List<ClientePorMayor>();
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

        public void Editar(ClientePorMayor CAXM)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Modapie.Mantenimiento.Instancia.Editar(CAXM);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public void Borrar(ClientePorMayor CAXM)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Modapie.Mantenimiento.Instancia.Borrar(CAXM);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {
                throw;
            }
        }



        #endregion


        #region Empleado
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
        
        public Empleado BuscarEmpleado(string dni)
        {
            Empleado empleado = new Empleado();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    empleado = DAL.Modapie.Mantenimiento.Instancia.buscarEmpleado(dni);
                    scope.Complete();
                    return empleado;
                }
            }
            catch (Exception ee)
            {
                DialogResult d = MessageBox.Show(ee.Message.ToString());
                return null;
            }
        }

        #endregion


        #region ProductoAlxMayor
        public List<ProductosAlxMayor> MostrarProductos()
        {

            List<ProductosAlxMayor> lista = new List<ProductosAlxMayor>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = DAL.Modapie.Mantenimiento.Instancia.MostrarProductos();
                    scope.Complete();
                }
                return lista;
            }
            catch (Exception ee)
            {
                DialogResult d = MessageBox.Show(ee.Message.ToString());
                return null;
            }
        }

        public ProductosAlxMayor obtenerLote(int id)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    ProductosAlxMayor prod = DAL.Modapie.Mantenimiento.Instancia.obtenerLote(id);
                    scope.Complete();
                    return prod;
                }
            }
            catch (Exception ee)
            {
                DialogResult d = MessageBox.Show(ee.Message.ToString());
                return null;
            }
        }

        #endregion
    }
}
