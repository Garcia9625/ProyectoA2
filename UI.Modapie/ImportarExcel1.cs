using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace UI.Modapie
{
    public partial class ImportarExcel1 : Form
    {
        public ImportarExcel1()
        {
            InitializeComponent();
        }

       

        private void BTN_ImportExcel_Click(object sender, EventArgs e)
        {
            string conexion = "Provider = Microsoft.Jet.OleDb.4.0;Data Source = D:/Users/Esteban/Desktop/Prueba.xlsx;Extended Properties = \"Excel 8.0;HDR = Yes\"";

            OleDbConnection conector = default(OleDbConnection);
            conector = new OleDbConnection(conexion);
            conector.Open();

           OleDbCommand consulta = default(OleDbCommand);
            consulta = new OleDbCommand("select * from [Hoja1$]", conector);
        
            OleDbDataAdapter adaptador = new OleDbDataAdapter();
            adaptador.SelectCommand = consulta;

            DataSet ds = new DataSet();

            adaptador.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

            conector.Close();
            
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form login = new Login();
            this.Hide();
            login.Show();
        }

        private void ImportarExcel1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            string conexion = "Provider = Microsoft.Jet.OleDb.4.0;Data Source = D:/Users/Esteban/Desktop/Prueba.xlsx;Extended Properties = \"Excel 8.0;HDR = Yes\"";

            OleDbConnection conector = default(OleDbConnection);
            conector = new OleDbConnection(conexion);
            conector.Open();

            OleDbCommand consulta = default(OleDbCommand);
            consulta = new OleDbCommand("select * from [Hoja1$]", conector);

            OleDbDataAdapter adaptador = new OleDbDataAdapter();
            adaptador.SelectCommand = consulta;

            DataSet ds = new DataSet();

            adaptador.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

            conector.Close();



            /////////////////////////////////////////////////////////////////
            SqlConnection conexion_receptora = new SqlConnection("Data Source=.;Initial Catalog=DBMODAPIE;Integrated Security=True");
            conexion_receptora.Open();
            SqlBulkCopy exportar = default(SqlBulkCopy);
            exportar = new SqlBulkCopy(conexion_receptora);
            exportar.DestinationTableName = "InventarioAlxMayor";
           
            exportar.WriteToServer(ds.Tables[0]);
            conexion_receptora.Close();
            MessageBox.Show("Importacion exitosa");




        }
    }
}
