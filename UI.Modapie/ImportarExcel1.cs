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
            try
            {
                string path;
                OpenFileDialog file = new OpenFileDialog();
                if (file.ShowDialog() == DialogResult.OK)
                {
                    path = file.FileName;
                    txtPath.Text = path;
                }
                string conexion = "Provider = Microsoft.Jet.OleDb.4.0;Data Source = "+txtPath.Text+";Extended Properties = \"Excel 8.0;HDR = Yes\"";

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
            }catch(Exception ee)
            {
                MessageBox.Show("Ha ocurrido un error en la importación del excel");
            }
            
            
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form login = new Login();
            this.Hide();
            login.Show();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                string conexion = "Provider = Microsoft.Jet.OleDb.4.0;Data Source = " + txtPath.Text + ";Extended Properties = \"Excel 8.0;HDR = Yes\"";

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

                Boolean Estado = true;
                consulta.CommandText = "Insert Into InventarioAlxMayor(Estado) Values (@Estado)";
                consulta.Parameters.AddWithValue("@Estado", Estado);

                exportar.WriteToServer(ds.Tables[0]);
                conexion_receptora.Close();
                MessageBox.Show("Importación exitosa");
            }
            catch(Exception ee)
        
            {
                MessageBox.Show("No se ha importado, revise si el excel está abierto");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MenuAdmin ma = new MenuAdmin();
            this.Dispose();
            ma.Show();
        }
    }
}
