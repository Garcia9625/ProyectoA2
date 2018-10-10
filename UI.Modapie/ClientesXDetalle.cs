using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Modapie
{
    public partial class ClientesXDetalle : Form
    {
        public ClientesXDetalle()
        {
            InitializeComponent();
        }

        DataSet resultados = new DataSet();
        DataView mifiltro;
        public void leer_datos(string query, ref DataSet dstprincipal, string tabla)
        {
            try
            {
                string cadena = "Data Source=.;Initial Catalog=DBMODAPIE;Integrated Security=True";
                SqlConnection cn = new SqlConnection(cadena);
                SqlCommand cmd = new SqlCommand(query, cn);
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dstprincipal, tabla);
                da.Dispose();
                cn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string salida_datos = "";
            string[] palabras_busqueda = this.textBox1.Text.Split(' ');

            foreach (string palabra in palabras_busqueda)
            {
                if (salida_datos.Length == 0)
                {
                    salida_datos = "(Dni LIKE '%" + palabra + "%' OR Nombre LIKE '%" + palabra + "%' OR Apellido1 LIKE '%" + palabra + "%' OR Apellido2 LIKE '%" + palabra + "%')";
                }
                else
                {
                    salida_datos += "AND (Dni LIKE '%" + palabra + "%' OR Nombre LIKE '%" + palabra + "%' OR Apellido1 LIKE '%" + palabra + "%' OR Apellido2 LIKE '%" + palabra + "%')";
                }
            }

            this.mifiltro.RowFilter = salida_datos;
        }

        private void ClientesXDetalle_Load(object sender, EventArgs e)
        {
            this.leer_datos("SELECT * FROM ClienteAlDetalle", ref resultados, "ClienteAlDetalle");
            this.mifiltro = ((DataTable)resultados.Tables["ClienteAlDetalle"]).DefaultView;
            this.dataGridView1.DataSource = mifiltro;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.IdClienteDetalle = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Program.Nombre = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Program.Apellido1 = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Program.Apellido2 = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
