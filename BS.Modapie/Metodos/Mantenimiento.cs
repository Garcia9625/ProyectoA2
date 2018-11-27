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
        public void InsertarClienteAlxMayor(ClientePorMayor clientealxMayor)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Modapie.Mantenimiento.Instancia.InsertarClienteAlxMayor(clientealxMayor);
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

        public ClientePorMayor buscarClienteAlxMayor(string nombre)
        {
            ClientePorMayor cad = new ClientePorMayor();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    cad = DAL.Modapie.Mantenimiento.Instancia.buscarClienteAlxMayor(nombre);
                    scope.Complete();
                    return cad;
                }
            }
            catch (Exception ee)
            {
                DialogResult d = MessageBox.Show(ee.Message.ToString());
                return null;
            }
        }

        public void InsertarCAlxMayor(ClientePorMayor CAXM)
        {
            throw new NotImplementedException();
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

        public void ActualizarEmpleado(Empleado empleado)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Modapie.Mantenimiento.Instancia.ActualizarEmpleado(empleado);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        #endregion

        #region InventarioAlxMayor
        public List<InventarioAlxMayor> MostrarProductos()
        {

            List<InventarioAlxMayor> lista = new List<InventarioAlxMayor>();
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

        public List<InventarioAlxMayor> obtenerListaInventarioAlxMayor()
        {

            List<InventarioAlxMayor> lista = new List<InventarioAlxMayor>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = DAL.Modapie.Mantenimiento.Instancia.obtenerListaInventarioAlxMayor();
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

        public InventarioAlxMayor obtenerLote(int id)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    InventarioAlxMayor prod = DAL.Modapie.Mantenimiento.Instancia.obtenerLote(id);
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

        public void EliminarProdXMayor(int id)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Modapie.Mantenimiento.Instancia.EliminarProdXMayor(id);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {
                DialogResult d = MessageBox.Show(ee.Message.ToString(), "error");
            }
        }

        #endregion

        #region ClienteAlDetalle

        public void InsertarClienteAlDetalle(ClienteAlDetalle clienteAlDetalle)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Modapie.Mantenimiento.Instancia.InsertarClienteAlDetalle(clienteAlDetalle);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public ClienteAlDetalle buscarCAD(string dni)
        {
            ClienteAlDetalle cad = new ClienteAlDetalle();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    cad= DAL.Modapie.Mantenimiento.Instancia.buscarCAD(dni);
                    scope.Complete();
                    return cad;
                }
            }
            catch (Exception ee)
            {
                DialogResult d = MessageBox.Show(ee.Message.ToString());
                return null;
            }
        }

        public List<ClienteAlDetalle> MostrarClienteXDetalle()
        {
            List<ClienteAlDetalle> lista = new List<ClienteAlDetalle>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = DAL.Modapie.Mantenimiento.Instancia.MostrarClienteXDetalle();
                    scope.Complete();
                }
                return lista;
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public void EditarCAD(ClienteAlDetalle CAD)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Modapie.Mantenimiento.Instancia.EditarCAD(CAD);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {
                throw;
            }
        }
        #endregion

        #region VentaAlxMayor

        public void InsertarVentaAlxMayor(VentaAlxMayor ventaAlxMayor)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Modapie.Mantenimiento.Instancia.InsertarVentaAlxMayor(ventaAlxMayor);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public VentaAlxMayor buscarUltimaVenta()
        {
            VentaAlxMayor ventaAlxMayor = new VentaAlxMayor();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    ventaAlxMayor = DAL.Modapie.Mantenimiento.Instancia.buscarUltimaVenta();
                    scope.Complete();
                    return ventaAlxMayor;
                }
            }
            catch (Exception ee)
            {
                //DialogResult d = MessageBox.Show(ee.Message.ToString());
                return null;
            }
        }
        #endregion

        #region DescripcionVentaAlxMayor

        public void InsertarDescripcionVentaAlxMayor(DescripcionVentaAlxMayor descripcionVentaAlxMayor)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Modapie.Mantenimiento.Instancia.InsertarDescripcionVentaAlxMayor(descripcionVentaAlxMayor);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {
                throw;
            }
        }
        #endregion

        #region DescripcionVentaAlDetalle
        public void InsertarDescripcionVentaAlDetalle(DescripcionVentaXDetalle descripcionVentaDetalle)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Modapie.Mantenimiento.Instancia.InsertarDescripcionVentaAlDetalle(descripcionVentaDetalle);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {
                throw;
            }
        }
        #endregion

        #region VentaAlDetalle
        public void InsertarVentaDetalle(VentaAlDetalle ventaDetalle)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Modapie.Mantenimiento.Instancia.InsertarVentaDetalle(ventaDetalle);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public VentaAlDetalle buscarUltimaVentaDetalle()
        {
            VentaAlDetalle ventaAlDetalle = new VentaAlDetalle();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    ventaAlDetalle = DAL.Modapie.Mantenimiento.Instancia.buscarUltimaVentaDetalle();
                    scope.Complete();
                    return ventaAlDetalle;
                }
            }
            catch (Exception ee)
            {
                DialogResult d = MessageBox.Show(ee.Message.ToString());
                return null;
            }
        }
        #endregion

        #region Usuario
        public void iInsertarUsuario(Usuario usuario)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Modapie.Mantenimiento.Instancia.InsertarUsuario(usuario);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {
                DialogResult d = MessageBox.Show(ee.Message.ToString(), "error");
            }
        }

        public List<Usuario> MostrarUsuario()
        {
            List<Usuario> lista = new List<Usuario>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = DAL.Modapie.Mantenimiento.Instancia.MostrarUsuario();
                    scope.Complete();
                }
                return lista;
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public Usuario BuscarUsuario(string idEmpleado)
        {

            Usuario usuario = new Usuario();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    usuario = DAL.Modapie.Mantenimiento.Instancia.BuscarUsuario(idEmpleado);
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

            public void ModificarUsuario(Usuario user)
            {
                try
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        DAL.Modapie.Mantenimiento.Instancia.ModificarUsuario(user);
                        scope.Complete();
                    }
                }
                catch (Exception ee)
                {
                    throw;
                }
            

        }

        public string BuscarCorreo(string username)
        {
            string correo;
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    correo = DAL.Modapie.Mantenimiento.Instancia.BuscarCorreo(username);
                    scope.Complete();
                    return correo;
                }
            }
            catch (Exception ee)
            {
                DialogResult d = MessageBox.Show(ee.Message.ToString());
                return null;
            }
        }

        public void ModificarUsuarioContrasena(string user, string password)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Modapie.Mantenimiento.Instancia.ModificarUsuarioContrasena(user, password);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        #endregion

        #region ProductoDetalle

        public void InsertarProductoDetalle(ProductoDetalle productoDetalle)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Modapie.Mantenimiento.Instancia.InsertarProductoDetalle(productoDetalle);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public List<ProductoDetalle> MostrarproductoDetalle()
        {
            List<ProductoDetalle> lista = new List<ProductoDetalle>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = DAL.Modapie.Mantenimiento.Instancia.MostrarproductoDetalle();
                    scope.Complete();
                }
                return lista;
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public ProductoDetalle buscarproductoDetalle(string codigo)
        {
            ProductoDetalle pd = new ProductoDetalle();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    pd = DAL.Modapie.Mantenimiento.Instancia.buscarproductoDetalle(codigo);
                    scope.Complete();
                    return pd;
                }
            }
            catch (Exception ee)
            {
                DialogResult d = MessageBox.Show(ee.Message.ToString());
                return null;
            }
        }

        public void EditarproductoDetalle(ProductoDetalle productoDetalle)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Modapie.Mantenimiento.Instancia.EditarproductoDetalle(productoDetalle);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public ProductoDetalle MostrarUnproductoDetalle(int idProducto)
        {
            ProductoDetalle pd = new ProductoDetalle();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    pd = DAL.Modapie.Mantenimiento.Instancia.MostrarUnproductoDetalle(idProducto);
                    scope.Complete();
                    return pd;
                }
            }
            catch (Exception ee)
            {
                DialogResult d = MessageBox.Show(ee.Message.ToString());
                return null;
            }
        }


        #endregion

        #region Apartados
        public void InsertarApartado(Apartados apartado)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Modapie.Mantenimiento.Instancia.InsertarApartado(apartado);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public void InsertarDescripcionApartado(DescripcionApartados descripcionApartado)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Modapie.Mantenimiento.Instancia.InsertarDescripcionApartado(descripcionApartado);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public Apartados buscarUltimoApartado()
        {
            Apartados apartados = new Apartados();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    apartados = DAL.Modapie.Mantenimiento.Instancia.buscarUltimoApartados();
                    scope.Complete();
                    return apartados;
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
