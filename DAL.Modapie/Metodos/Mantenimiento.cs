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


        public void InsertarCAlxMayor(ClienteAlxMayor CAXM)
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

        public List<ClienteAlxMayor> MostarCAXM()
        {
            List<ClienteAlxMayor> lista = new List<ClienteAlxMayor>();
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
                    ClienteAlxMayor CAXM;
                    while (dataReader.Read())
                    {
                        CAXM = new ClienteAlxMayor
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
    }
}
