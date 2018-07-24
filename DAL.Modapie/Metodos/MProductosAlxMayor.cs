using DO.Modapie;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Modapie.Interfaces;


namespace DAL.Modapie.Metodos
{
    class MProductosAlxMayor : IProductosAlxMayor

    {
        public IProductosAlxMayor MostrarProductosM(int idLote)
        {
            DbConnection conn = null;
            DbCommand comm = null;
            IProductosAlxMayor producto;

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
                param1.DbType = System.Data.DbType.String;
                param1.Value = idLote;

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
                   producto = new MProductosAlxMayor
                    {


                       
                        idUsuario = Convert.ToInt32(dataReader["IdUsuario"].ToString()),
                        idEmpleado = Convert.ToInt32(dataReader["IdEmpleado"].ToString()),
                        username = dataReader["Username"].ToString(),
                        password = dataReader["Password"].ToString(),
                        rol = Convert.ToInt32(dataReader["Rol"])
                    };
                }
                return producto;
            }
            catch (Exception ee)
            {
                DialogResult d = MessageBox.Show(ee.Message.ToString());

                return null;
            }
        }
    }
}
