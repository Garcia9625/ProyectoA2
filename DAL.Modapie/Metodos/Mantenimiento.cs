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
                        password = dataReader["Password"].ToString()
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
    }
}
