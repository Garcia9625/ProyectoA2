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
            string conexion = "Provider = Microsoft.Jet.OleDb.4.0;Data Source = C:/Users/ricar/Desktop/Prueba.xlsx;Extended Properties = \"Excel 8.0;HDR = Yes\"";

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
    }
}
