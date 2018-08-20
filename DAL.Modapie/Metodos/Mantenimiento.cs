using DO.Modapie;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL.Modapie
{
    public class Mantenimiento : IMantenimiento
    {
        private static Mantenimiento instancia;

        public Mantenimiento()
        {
        }

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
        public int validarLogin(string username, string password)
        {
            DbConnection conn = null;
            DbCommand comm = null;
            int respuesta = 2;

            try
            {

                DbProviderFactory factory = DbProviderFactories.GetFactory(Conexion.Default.proveedor);

                //Creacion de la connection
                conn = factory.CreateConnection();
                conn.ConnectionString = Conexion.Default.connection;
                comm = factory.CreateCommand();

                //Creacion de parametros
                DbParameter param1 = factory.CreateParameter();
                DbParameter param2 = factory.CreateParameter();
                DbParameter param3 = factory.CreateParameter();

                //Carga de parametros
                param1.ParameterName = "@Username";
                param1.DbType = System.Data.DbType.String;
                param1.Value = username;
                param1.Direction = ParameterDirection.Input;

                param2.ParameterName = "@Password";
                param2.DbType = System.Data.DbType.String;
                param2.Value = password;
                param2.Direction = ParameterDirection.Input;


                param3.DbType = System.Data.DbType.Int32;
                param3.Direction = ParameterDirection.ReturnValue;

                //Abrir connection
                comm.Connection = conn;
                conn.Open();

                //Ejecuta funcion
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.CommandText = "dbo.Validacion_Login";
                comm.Parameters.Add(param1);
                comm.Parameters.Add(param2);
                comm.Parameters.Add(param3);

                comm.ExecuteNonQuery();

                if (param3.Value != DBNull.Value)
                {
                    respuesta = (Int32)param3.Value;
                }
                return respuesta;
            }
            catch (Exception ee)
            {
                DialogResult d = MessageBox.Show(ee.Message.ToString());

                return 3;
            }
        }

        public Usuario obtenerUsuarioUser(string username)
        {
            DbConnection conn = null;
            DbCommand comm = null;
            Usuario usuario;

            try
            {

                DbProviderFactory factory = DbProviderFactories.GetFactory(Conexion.Default.proveedor);

                //Creacion de la connection
                conn = factory.CreateConnection();
                conn.ConnectionString = Conexion.Default.connection;
                comm = factory.CreateCommand();

                //Creacion de parametros
                DbParameter param1 = factory.CreateParameter();


                //Carga de parametros
                param1.ParameterName = "@Username";
                param1.DbType = System.Data.DbType.String;
                param1.Value = username;

                //Abrir connection
                comm.Connection = conn;
                conn.Open();

                //Ejecuta SP
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.CommandText = "validarUser";
                comm.Parameters.Add(param1);

                using (IDataReader dataReader = comm.ExecuteReader())
                {
                    dataReader.Read();
                    usuario = new Usuario
                    {
                        idUsuario = Convert.ToInt32(dataReader["IdUsuario"].ToString()),
                        idEmpleado = Convert.ToInt32(dataReader["IdEmpleado"].ToString()),
                        username = dataReader["Username"].ToString(),
                        password = dataReader["Password"].ToString(),
                        rol = Convert.ToInt32(dataReader["Rol"])
                    };
                }
                return usuario;
            }
            catch (Exception ee)
            {
                DialogResult d = MessageBox.Show(ee.Message.ToString());

                return null;
            }
        }

        public int validarRol(string username)
        {
            DbConnection conn = null;
            DbCommand comm = null;
            int respuesta = 0;

            try
            {

                DbProviderFactory factory = DbProviderFactories.GetFactory(Conexion.Default.proveedor);

                //Creacion de la connection
                conn = factory.CreateConnection();
                conn.ConnectionString = Conexion.Default.connection;
                comm = factory.CreateCommand();

                //Creacion de parametros
                DbParameter param1 = factory.CreateParameter();
                DbParameter param2 = factory.CreateParameter();

                //Carga de parametros
                param1.ParameterName = "@Username";
                param1.DbType = System.Data.DbType.String;
                param1.Value = username;
                param1.Direction = ParameterDirection.Input;

                param2.DbType = System.Data.DbType.Int32;
                param2.Direction = ParameterDirection.ReturnValue;

                //Abrir connection
                comm.Connection = conn;
                conn.Open();

                //Ejecuta funcion
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.CommandText = "dbo.Rol";
                comm.Parameters.Add(param1);
                comm.Parameters.Add(param2);

                comm.ExecuteNonQuery();

                if (param2.Value != DBNull.Value)
                {
                    respuesta = (Int32)param2.Value;
                }
                return respuesta;
            }
            catch (Exception ee)
            {
                DialogResult d = MessageBox.Show(ee.Message.ToString());

                return 0;
            }
        }
        #endregion


        #region ClienteAlxMayor
        public void InsertarCAlxMayor(ClientePorMayor CAXM)
        {
            DbProviderFactory factory = DbProviderFactories.GetFactory(Conexion.Default.proveedor);
            DbConnection conn = null;
            DbCommand comm = null;

            try
            {
                conn = factory.CreateConnection();
                conn.ConnectionString = Conexion.Default.connection;
                comm = factory.CreateCommand();

                DbParameter param2 = factory.CreateParameter();
                DbParameter param3 = factory.CreateParameter();
                DbParameter param4 = factory.CreateParameter();

                //Carga de Parametros

                param2.ParameterName = "@NombreJuridico";
                param2.DbType = System.Data.DbType.String;
                param2.Value = CAXM.nombreJuridico;

                param3.ParameterName = "@NombreFisico";
                param3.DbType = System.Data.DbType.String;
                param3.Value = CAXM.nombreFisico;

                param4.ParameterName = "@NombreFantasia";
                param4.DbType = System.Data.DbType.String;
                param4.Value = CAXM.nombreFantasia;

                //Abrir Coneccion 
                comm.Connection = conn;
                conn.Open();

                //Ejecutar Store Procedure
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.CommandText = "sp_InsertarCAXM";
                comm.Parameters.Add(param2);
                comm.Parameters.Add(param3);
                comm.Parameters.Add(param4);
                comm.ExecuteNonQuery();
            }
            catch (Exception ee)
            {
                throw;
            }
            finally
            {
                comm.Dispose();
                conn.Dispose();
            }
        }

        public List<ClientePorMayor> MostarCAXM()
        {
            List<ClientePorMayor> lista = new List<ClientePorMayor>();
            DbConnection conn = null;
            DbCommand comm = null;
            try
            {
                DbProviderFactory factory = DbProviderFactories.GetFactory(Conexion.Default.proveedor);

                //Creacion de la connection
                conn = factory.CreateConnection();
                conn.ConnectionString = Conexion.Default.connection;
                comm = factory.CreateCommand();

                //Abrir connection
                comm.Connection = conn;
                conn.Open();

                //Ejecuta SP
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.CommandText = "sp_MostrarCAXM";

                using (IDataReader dataReader = comm.ExecuteReader())
                {
                    ClientePorMayor CAXM;
                    while (dataReader.Read())
                    {
                        CAXM = new ClientePorMayor
                        {
                            idCliente = Convert.ToInt32(dataReader["IdCliente"].ToString()),
                            nombreJuridico = dataReader["NombreJuridico"].ToString(),
                            nombreFisico = dataReader["NombreFisico"].ToString(),
                            nombreFantasia = dataReader["NombreFantasia"].ToString()

                        };
                        lista.Add(CAXM);
                    }
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
            DbProviderFactory factory = DbProviderFactories.GetFactory(Conexion.Default.proveedor);
            DbConnection conn = null;
            DbCommand comm = null;

            try
            {
                conn = factory.CreateConnection();
                conn.ConnectionString = Conexion.Default.connection;
                comm = factory.CreateCommand();

                DbParameter param1 = factory.CreateParameter();
                DbParameter param2 = factory.CreateParameter();
                DbParameter param3 = factory.CreateParameter();
                DbParameter param4 = factory.CreateParameter();


                //Carga de Parametros
                param1.ParameterName = "@IdCliente";
                param1.DbType = System.Data.DbType.Int32;
                param1.Value = CAXM.idCliente;

                param2.ParameterName = "@NombreJuridico";
                param2.DbType = System.Data.DbType.String;
                param2.Value = CAXM.nombreJuridico;

                param3.ParameterName = "@NombreFisico";
                param3.DbType = System.Data.DbType.String;
                param3.Value = CAXM.nombreFisico;

                param4.ParameterName = "@NombreFantasia";
                param4.DbType = System.Data.DbType.String;
                param4.Value = CAXM.nombreFantasia;

                //Abrir Coneccion 
                comm.Connection = conn;
                conn.Open();

                //Ejecutar Store Procedure
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.CommandText = "sp_Editar";
                comm.Parameters.Add(param1);
                comm.Parameters.Add(param2);
                comm.Parameters.Add(param3);
                comm.Parameters.Add(param4);
                comm.ExecuteNonQuery();
            }
            catch (Exception ee)
            {
                throw;
            }
            finally
            {
                comm.Dispose();
                conn.Dispose();
            }
        }

        public void Borrar(ClientePorMayor CAXM)
        {
            DbProviderFactory factory = DbProviderFactories.GetFactory(Conexion.Default.proveedor);
            DbConnection conn = null;
            DbCommand comm = null;

            try
            {
                conn = factory.CreateConnection();
                conn.ConnectionString = Conexion.Default.connection;
                comm = factory.CreateCommand();

                DbParameter param1 = factory.CreateParameter();

                //Carga de Parametros
                param1.ParameterName = "@IdCliente";
                param1.DbType = System.Data.DbType.Int32;
                param1.Value = CAXM.idCliente;

                //Abrir Coneccion 
                comm.Connection = conn;
                conn.Open();

                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.CommandText = "sp_EliminarCAXM";
                comm.Parameters.Add(param1);
                comm.ExecuteNonQuery();
            }
            catch (Exception ee)
            {
                throw;
            }
            finally
            {
                comm.Dispose();
                conn.Dispose();
            }
        }


        #endregion

        #region Empleado
        /*Gestion Empleado*/

        public void InsertarEmpleado(Empleado emp)
        {
            DbProviderFactory factory = DbProviderFactories.GetFactory(Conexion.Default.proveedor);
            DbConnection conn = null;
            DbCommand comm = null;

            try
            {
                conn = factory.CreateConnection();
                conn.ConnectionString = Conexion.Default.connection;
                comm = factory.CreateCommand();

                DbParameter param1 = factory.CreateParameter();
                DbParameter param2 = factory.CreateParameter();
                DbParameter param3 = factory.CreateParameter();
                DbParameter param4 = factory.CreateParameter();
                DbParameter param5 = factory.CreateParameter();
                DbParameter param6 = factory.CreateParameter();
                DbParameter param7 = factory.CreateParameter();
                DbParameter param8 = factory.CreateParameter();
                DbParameter param9 = factory.CreateParameter();
                DbParameter param10 = factory.CreateParameter();
                DbParameter param11 = factory.CreateParameter();

                //Carga de Parametros

                param1.ParameterName = "@Dni";
                param1.DbType = System.Data.DbType.String;
                param1.Value = emp.Dni;

                param2.ParameterName = "@Nombre";
                param2.DbType = System.Data.DbType.String;
                param2.Value = emp.Nombre;

                param3.ParameterName = "@Apellido1";
                param3.DbType = System.Data.DbType.String;
                param3.Value = emp.Apellido1;

                param4.ParameterName = "@Apellido2";
                param4.DbType = System.Data.DbType.String;
                param4.Value = emp.Apellido2;

                param5.ParameterName = "@Celular";
                param5.DbType = System.Data.DbType.String;
                param5.Value = emp.Celular;

                param6.ParameterName = "@Telefono";
                param6.DbType = System.Data.DbType.String;
                param6.Value = emp.Telefono;

                param7.ParameterName = "@Correo";
                param7.DbType = System.Data.DbType.String;
                param7.Value = emp.Correo;

                param8.ParameterName = "@DireccionDomicilio";
                param8.DbType = System.Data.DbType.String;
                param8.Value = emp.DireccionDomicilio;

                param9.ParameterName = "@SalarioMensual";
                param9.DbType = System.Data.DbType.Double;
                param9.Value = emp.SalarioMensual;

                param10.ParameterName = "@FechaContratacion";
                param10.DbType = System.Data.DbType.DateTime;
                param10.Value = emp.FechaContratacion;

                param11.ParameterName = "@Estado";
                param11.DbType = System.Data.DbType.Boolean;
                param11.Value = emp.Estado;

                //Abrir Coneccion 
                comm.Connection = conn;
                conn.Open();

                //Ejecutar Store Procedure
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.CommandText = "sp_InsertarEmpleado";
                comm.Parameters.Add(param1);
                comm.Parameters.Add(param2);
                comm.Parameters.Add(param3);
                comm.Parameters.Add(param4);
                comm.Parameters.Add(param5);
                comm.Parameters.Add(param6);
                comm.Parameters.Add(param7);
                comm.Parameters.Add(param8);
                comm.Parameters.Add(param9);
                comm.Parameters.Add(param10);
                comm.Parameters.Add(param11);
                comm.ExecuteNonQuery();
            }
            catch (Exception ee)
            {
                throw;
            }
            finally
            {
                comm.Dispose();
                conn.Dispose();
            }
        }

        public List<Empleado> MostrarEmpleado()
        {
            List<Empleado> lista = new List<Empleado>();
            DbConnection conn = null;
            DbCommand comm = null;
            try
            {
                DbProviderFactory factory = DbProviderFactories.GetFactory(Conexion.Default.proveedor);

                //Creacion de la connection
                conn = factory.CreateConnection();
                conn.ConnectionString = Conexion.Default.connection;
                comm = factory.CreateCommand();

                //Abrir connection
                comm.Connection = conn;
                conn.Open();

                //Ejecuta SP
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.CommandText = "sp_MostrarEmpleado";

                using (IDataReader dataReader = comm.ExecuteReader())
                {
                    Empleado emp;
                    while (dataReader.Read())
                    {
                        emp = new Empleado
                        {
                            Dni = dataReader["Dni"].ToString(),
                            Nombre = dataReader["Nombre"].ToString(),
                            Apellido1 = dataReader["Apellido1"].ToString(),
                            Apellido2 = dataReader["Apellido2"].ToString(),
                            Celular = dataReader["Celular"].ToString(),
                            Telefono = dataReader["Telefono"].ToString(),
                            Correo = dataReader["Correo"].ToString(),
                            DireccionDomicilio = dataReader["DireccionDomicilio"].ToString(),
                            SalarioMensual = Convert.ToDouble(dataReader["SalarioMensual"].ToString()),
                            /*FechaContratacion = Convert.ToDateTime(dataReader["FechaContratacion"]),
                            FechaSalida = Convert.ToDateTime(dataReader["FechaContratacion"]),*/
                            Estado = Convert.ToBoolean(dataReader["Estado"].ToString())

                        };
                        lista.Add(emp);
                    }
                }

                return lista;
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public Empleado buscarEmpleado(string dni)
        {
            Empleado emp = new Empleado();
            DbConnection conn = null;
            DbCommand comm = null;
            try
            {
                DbProviderFactory factory = DbProviderFactories.GetFactory(Conexion.Default.proveedor);

                //Creacion de la connection
                conn = factory.CreateConnection();
                conn.ConnectionString = Conexion.Default.connection;
                comm = factory.CreateCommand();

                //Creacion de parametros

                DbParameter param1 = factory.CreateParameter();

                param1.ParameterName = "@Dni";
                param1.DbType = System.Data.DbType.String;
                param1.Value = dni;

                //Abrir connection
                comm.Connection = conn;
                conn.Open();

                //Ejecuta SP
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.CommandText = "sp_BuscarEmpleado";
                comm.Parameters.Add(param1);

                using (IDataReader dataReader = comm.ExecuteReader())
                {
                    dataReader.Read();
                    emp = new Empleado
                    {
                        Dni = dataReader["Dni"].ToString(),
                        Nombre = dataReader["Nombre"].ToString(),
                        Apellido1 = dataReader["Apellido1"].ToString(),
                        Apellido2 = dataReader["Apellido2"].ToString(),
                        Celular = dataReader["Celular"].ToString(),
                        Telefono = dataReader["Telefono"].ToString(),
                        Correo = dataReader["Correo"].ToString(),
                        DireccionDomicilio = dataReader["DireccionDomicilio"].ToString(),
                        SalarioMensual = Convert.ToDouble(dataReader["SalarioMensual"].ToString()),
                        /*FechaContratacion = Convert.ToDateTime(dataReader["FechaContratacion"].ToString()),
                        FechaSalida = Convert.ToDateTime(dataReader["FechaContratacion"].ToString()),*/
                        Estado = Convert.ToBoolean(dataReader["Estado"].ToString())

                    };
                }

                return emp;
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public void ActualizarEmpleado(Empleado empleado)
        {
            DbProviderFactory factory = DbProviderFactories.GetFactory(Conexion.Default.proveedor);
            DbConnection conn = null;
            DbCommand comm = null;

            try
            {
                conn = factory.CreateConnection();
                conn.ConnectionString = Conexion.Default.connection;
                comm = factory.CreateCommand();

                DbParameter param1 = factory.CreateParameter();
                DbParameter param2 = factory.CreateParameter();
                DbParameter param3 = factory.CreateParameter();
                DbParameter param4 = factory.CreateParameter();
                DbParameter param5 = factory.CreateParameter();
                DbParameter param6 = factory.CreateParameter();
                DbParameter param7 = factory.CreateParameter();
                DbParameter param8 = factory.CreateParameter();
                DbParameter param9 = factory.CreateParameter();
                DbParameter param10 = factory.CreateParameter();
                DbParameter param11 = factory.CreateParameter();

                //Carga de Parametros

                param1.ParameterName = "@Dni";
                param1.DbType = System.Data.DbType.String;
                param1.Value = empleado.Dni;

                param2.ParameterName = "@Nombre";
                param2.DbType = System.Data.DbType.String;
                param2.Value = empleado.Nombre;

                param3.ParameterName = "@Apellido1";
                param3.DbType = System.Data.DbType.String;
                param3.Value = empleado.Apellido1;

                param4.ParameterName = "@Apellido2";
                param4.DbType = System.Data.DbType.String;
                param4.Value = empleado.Apellido2;

                param5.ParameterName = "@Celular";
                param5.DbType = System.Data.DbType.String;
                param5.Value = empleado.Celular;

                param6.ParameterName = "@Telefono";
                param6.DbType = System.Data.DbType.String;
                param6.Value = empleado.Telefono;

                param7.ParameterName = "@Correo";
                param7.DbType = System.Data.DbType.String;
                param7.Value = empleado.Correo;

                param8.ParameterName = "@DireccionDomicilio";
                param8.DbType = System.Data.DbType.String;
                param8.Value = empleado.DireccionDomicilio;

                param9.ParameterName = "@SalarioMensual";
                param9.DbType = System.Data.DbType.Double;
                param9.Value = empleado.SalarioMensual;

                param10.ParameterName = "@FechaContratacion";
                param10.DbType = System.Data.DbType.DateTime;
                param10.Value = empleado.FechaContratacion;

                param11.ParameterName = "@Estado";
                param11.DbType = System.Data.DbType.Boolean;
                param11.Value = empleado.Estado;

                //Abrir Coneccion 
                comm.Connection = conn;
                conn.Open();

                //Ejecutar Store Procedure
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.CommandText = "sp_ActualizarEmpleado";
                comm.Parameters.Add(param1);
                comm.Parameters.Add(param2);
                comm.Parameters.Add(param3);
                comm.Parameters.Add(param4);
                comm.Parameters.Add(param5);
                comm.Parameters.Add(param6);
                comm.Parameters.Add(param7);
                comm.Parameters.Add(param8);
                comm.Parameters.Add(param9);
                comm.Parameters.Add(param10);
                comm.Parameters.Add(param11);
                comm.ExecuteNonQuery();
            }
            catch (Exception ee)
            {
                throw;
            }
            finally
            {
                comm.Dispose();
                conn.Dispose();
            }
        }
        #endregion

        #region productosAlxMAYOR

        /*Gestion productos al x MAYOR*/
        public List<ProductosAlxMayor> MostrarProductos()
        {
            List<ProductosAlxMayor> lista = new List<ProductosAlxMayor>();
            DbConnection conn = null;
            DbCommand comm = null;
            try
            {
                DbProviderFactory factory = DbProviderFactories.GetFactory(Conexion.Default.proveedor);

                //Creacion de la connection
                conn = factory.CreateConnection();
                conn.ConnectionString = Conexion.Default.connection;
                comm = factory.CreateCommand();

                //Abrir connection
                comm.Connection = conn;
                conn.Open();

                //Ejecuta SP
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.CommandText = "MostrarProductoAlxMayor1";

                using (IDataReader dataReader = comm.ExecuteReader())
                {
                    ProductosAlxMayor pro;
                    while (dataReader.Read())
                    {
                        pro = new ProductosAlxMayor
                        {
                            IdLote1 = Convert.ToInt32(dataReader["IdLote"]),
                            EnvioOrden1 = Convert.ToInt32(dataReader["EnvioOrden"]),
                            Codigo1 = Convert.ToInt32(dataReader["Codigo"]),
                            Show1 = dataReader["Show"].ToString(),
                            Cliente1 = dataReader["Cliente"].ToString(),
                            Vendedor1 = Convert.ToInt32(dataReader["Vendedor"]),
                            Zona1 = Convert.ToInt32(dataReader["Zona"]),
                            Transporte1 = dataReader["Transporte"].ToString(),
                            Pedido1 = dataReader["Pedido"].ToString(),
                            Modelo1 = Convert.ToInt32(dataReader["Modelo"]),
                            Color1 = Convert.ToInt32(dataReader["Color"]),
                            Descripcion1 = dataReader["Descripcion"].ToString(),
                            Curva1 = dataReader["Curva"].ToString(),
                            Pares1 = Convert.ToInt32(dataReader["Pares"]),
                            Cajas1 = Convert.ToInt32(dataReader["Cajas"]),
                            Cif1 = Convert.ToInt32(dataReader["Cif"]),
                            TotalCIF1 = Convert.ToInt32(dataReader["TotalCIF"]),
                            PrecioUnitario1 = Convert.ToInt32(dataReader["PrecioUnitario"]),
                            SubTotal1 = Convert.ToInt32(dataReader["SubTotal"]),
                            TotalImpuestos1 = Convert.ToInt32(dataReader["TotalImpuestos"])
                        };
                        lista.Add(pro);
                    }
                }

                return lista;
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public ProductosAlxMayor obtenerLote(int id)
        {
            DbConnection conn = null;
            DbCommand comm = null;
            ProductosAlxMayor prod;

            try
            {

                DbProviderFactory factory = DbProviderFactories.GetFactory(Conexion.Default.proveedor);

                //Creacion de la connection
                conn = factory.CreateConnection();
                conn.ConnectionString = Conexion.Default.connection;
                comm = factory.CreateCommand();

                //Creacion de parametros
                DbParameter param1 = factory.CreateParameter();


                //Carga de parametros
                param1.ParameterName = "@IdLote";
                param1.DbType = System.Data.DbType.Int32;
                param1.Value = id;

                //Abrir connection
                comm.Connection = conn;
                conn.Open();

                //Ejecuta SP
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.CommandText = "MostrarProductoAlxMayor1";
                comm.Parameters.Add(param1);



                using (IDataReader dataReader = comm.ExecuteReader())
                {
                    dataReader.Read();
                    prod = new ProductosAlxMayor(
                           Convert.ToInt32(dataReader["IdLote"].ToString()),
                           Convert.ToInt32(dataReader["EnvioOrden"].ToString()),
                           Convert.ToInt32(dataReader["Codigo"].ToString()),
                           dataReader["Show"].ToString(),
                           dataReader["Cliente"].ToString(),
                           Convert.ToInt32(dataReader["Vendedor"].ToString()),
                           Convert.ToInt32(dataReader["Zona"].ToString()),
                           dataReader["Transporte"].ToString(),
                           dataReader["Pedido"].ToString(),
                           Convert.ToInt32(dataReader["Modelo"].ToString()),
                           Convert.ToInt32(dataReader["Color"].ToString()),
                           dataReader["Descripcion"].ToString(),
                           dataReader["Curva"].ToString(),
                           Convert.ToInt32(dataReader["Pares"].ToString()),
                           Convert.ToInt32(dataReader["Cajas"].ToString()),
                           Convert.ToInt32(dataReader["Cif"].ToString()),
                           Convert.ToInt32(dataReader["TotalCIF"].ToString()),
                           Convert.ToInt32(dataReader["PrecioUnitario"].ToString()),
                           Convert.ToInt32(dataReader["SubTotal"].ToString()),
                           Convert.ToInt32(dataReader["TotalImpuestos"].ToString())
                 );

                }

                return prod;
            }
            catch (Exception ee)
            {
                DialogResult d = MessageBox.Show(ee.Message.ToString(), "Error");

                return null;
            }
        }

        public void EliminarProdXMayor(int id)
        {
            DbConnection conn = null;
            DbCommand comm = null;
            try
            {

                DbProviderFactory factory = DbProviderFactories.GetFactory(Conexion.Default.proveedor);

                //Creacion de la connection
                conn = factory.CreateConnection();
                conn.ConnectionString = Conexion.Default.connection;
                comm = factory.CreateCommand();

                //Creacion de parametros
                DbParameter param1 = factory.CreateParameter();

                //Carga de parametros
                param1.ParameterName = "@ID";
                param1.DbType = System.Data.DbType.Int32;
                param1.Value = id;

                //Abrir connection
                comm.Connection = conn;
                conn.Open();

                //Ejecuta SP
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.CommandText = "sp_EliminarProdxMayor";
                comm.Parameters.Add(param1);


                comm.ExecuteNonQuery();
                DialogResult d = MessageBox.Show("Producto eliminado correctamente", "Notificacion");
            }
            catch (Exception ee)
            {
                DialogResult d = MessageBox.Show(ee.Message.ToString(), "Error");


            }
        }

        #endregion

        #region ClienteAlDetalle

        public void InsertarClienteAlDetalle(ClienteAlDetalle clienteAlDetalle)
        {
            DbProviderFactory factory = DbProviderFactories.GetFactory(Conexion.Default.proveedor);
            DbConnection conn = null;
            DbCommand comm = null;

            try
            {
                conn = factory.CreateConnection();
                conn.ConnectionString = Conexion.Default.connection;
                comm = factory.CreateCommand();

                DbParameter param1 = factory.CreateParameter();
                DbParameter param2 = factory.CreateParameter();
                DbParameter param3 = factory.CreateParameter();
                DbParameter param4 = factory.CreateParameter();
                DbParameter param5 = factory.CreateParameter();
                DbParameter param6 = factory.CreateParameter();
                DbParameter param7 = factory.CreateParameter();

                //Carga de Parametros

                param1.ParameterName = "@Dni";
                param1.DbType = System.Data.DbType.String;
                param1.Value = clienteAlDetalle.Dni1;

                param2.ParameterName = "@Nombre";
                param2.DbType = System.Data.DbType.String;
                param2.Value = clienteAlDetalle.Nombre1;

                param3.ParameterName = "@Apellido1";
                param3.DbType = System.Data.DbType.String;
                param3.Value = clienteAlDetalle.Apellido11;

                param4.ParameterName = "@Apellido2";
                param4.DbType = System.Data.DbType.String;
                param4.Value = clienteAlDetalle.Apellido21;

                param5.ParameterName = "@Celular";
                param5.DbType = System.Data.DbType.String;
                param5.Value = clienteAlDetalle.Celular1;

                param6.ParameterName = "@Telefono";
                param6.DbType = System.Data.DbType.String;
                param6.Value = clienteAlDetalle.Telefono1;

                param7.ParameterName = "@Correo";
                param7.DbType = System.Data.DbType.String;
                param7.Value = clienteAlDetalle.Correo1;

                //Abrir Coneccion 
                comm.Connection = conn;
                conn.Open();

                //Ejecutar Store Procedure
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.CommandText = "sp_InsertarCAD";
                comm.Parameters.Add(param1);
                comm.Parameters.Add(param2);
                comm.Parameters.Add(param3);
                comm.Parameters.Add(param4);
                comm.Parameters.Add(param5);
                comm.Parameters.Add(param6);
                comm.Parameters.Add(param7);
                comm.ExecuteNonQuery();
            }
            catch (Exception ee)
            {
                throw;
            }
            finally
            {
                comm.Dispose();
                conn.Dispose();
            }
        }




        public ClienteAlDetalle buscarCAD(string dni)
        {
            ClienteAlDetalle cad = new ClienteAlDetalle();
            DbConnection conn = null;
            DbCommand comm = null;
            try
            {
                DbProviderFactory factory = DbProviderFactories.GetFactory(Conexion.Default.proveedor);

                //Creacion de la connection
                conn = factory.CreateConnection();
                conn.ConnectionString = Conexion.Default.connection;
                comm = factory.CreateCommand();

                //Creacion de parametros

                DbParameter param1 = factory.CreateParameter();

                param1.ParameterName = "@Dni";
                param1.DbType = System.Data.DbType.String;
                param1.Value = dni;

                //Abrir connection
                comm.Connection = conn;
                conn.Open();

                //Ejecuta SP
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.CommandText = "sp_BuscarCAD";
                comm.Parameters.Add(param1);

                using (IDataReader dataReader = comm.ExecuteReader())
                {
                    dataReader.Read();
                    cad = new ClienteAlDetalle
                    {
                        Dni1 = dataReader["Dni"].ToString(),
                        Nombre1 = dataReader["Nombre"].ToString(),
                        Apellido11 = dataReader["Apellido1"].ToString(),
                        Apellido21 = dataReader["Apellido2"].ToString(),
                        Celular1 = dataReader["Celular"].ToString(),
                        Telefono1 = dataReader["Telefono"].ToString(),
                        Correo1 = dataReader["Correo"].ToString(),
                    };
                }

                return cad;
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public void Editar(ClienteAlDetalle CAXD)
        {

            DbProviderFactory factory = DbProviderFactories.GetFactory(Conexion.Default.proveedor);
            DbConnection conn = null;
            DbCommand comm = null;

            try
            {
                conn = factory.CreateConnection();
                conn.ConnectionString = Conexion.Default.connection;
                comm = factory.CreateCommand();

                DbParameter param1 = factory.CreateParameter();
                DbParameter param2 = factory.CreateParameter();
                DbParameter param3 = factory.CreateParameter();
                DbParameter param4 = factory.CreateParameter();
                DbParameter param5 = factory.CreateParameter();
                DbParameter param6 = factory.CreateParameter();
                DbParameter param7 = factory.CreateParameter();



                //Carga de Parametros
                param1.ParameterName = "@Dni";
                param1.DbType = System.Data.DbType.String;
                param1.Value = CAXD.Dni1;

                param2.ParameterName = "@Nombre";
                param2.DbType = System.Data.DbType.String;
                param2.Value = CAXD.Nombre1;

                param3.ParameterName = "@Apellido1";
                param3.DbType = System.Data.DbType.String;
                param3.Value = CAXD.Apellido11;

                param4.ParameterName = "@Apellido2";
                param4.DbType = System.Data.DbType.String;
                param4.Value = CAXD.Apellido21;

                param5.ParameterName = "@Celular";
                param5.DbType = System.Data.DbType.String;
                param5.Value = CAXD.Celular1;

                param6.ParameterName = "@Telefono";
                param6.DbType = System.Data.DbType.String;
                param6.Value = CAXD.Telefono1;

                param7.ParameterName = "@Correo";
                param7.DbType = System.Data.DbType.String;
                param7.Value = CAXD.Correo1;


                //Abrir Coneccion 
                comm.Connection = conn;
                conn.Open();

                //Ejecutar Store Procedure
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.CommandText = "sp_Editar";
                comm.Parameters.Add(param1);
                comm.Parameters.Add(param2);
                comm.Parameters.Add(param3);
                comm.Parameters.Add(param4);
                comm.Parameters.Add(param5);
                comm.Parameters.Add(param6);
                comm.Parameters.Add(param7);
                comm.ExecuteNonQuery();
            }
            catch (Exception ee)
            {
                throw;
            }
            finally
            {
                comm.Dispose();
                conn.Dispose();
            }
        }

        public List<ClienteAlDetalle> MostrarClienteXDetalle()
        {
            List<ClienteAlDetalle> lista = new List<ClienteAlDetalle>();
            DbConnection conn = null;
            DbCommand comm = null;
            try
            {
                DbProviderFactory factory = DbProviderFactories.GetFactory(Conexion.Default.proveedor);

                //Creacion de la connection
                conn = factory.CreateConnection();
                conn.ConnectionString = Conexion.Default.connection;
                comm = factory.CreateCommand();

                //Abrir connection
                comm.Connection = conn;
                conn.Open();

                //Ejecuta SP
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.CommandText = "MostrarCAD";

                using (IDataReader dataReader = comm.ExecuteReader())
                {
                    ClienteAlDetalle cad;
                    while (dataReader.Read())
                    {
                        cad = new ClienteAlDetalle
                        {
                            Dni1 = dataReader["Dni"].ToString(),
                            Nombre1 = dataReader["Nombre"].ToString(),
                            Apellido11 = dataReader["Apellido1"].ToString(),
                            Apellido21 = dataReader["Apellido2"].ToString(),
                            Celular1 = dataReader["Celular"].ToString(),
                            Telefono1 = dataReader["Telefono"].ToString(),
                            Correo1 = dataReader["Correo"].ToString()
                        };
                        lista.Add(cad);
                    }
                }
                return lista;
            }
            catch (Exception ee)
            {
                throw;
            }
        }
    }
    #endregion
}

