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
    public partial class Productos : Form
    {
        public Productos()
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

        private void Productos_Load(object sender, EventArgs e)
        {
            this.leer_datos("SELECT * FROM InventarioAlDetalle", ref resultados, "InventarioAlDetalle");
            this.mifiltro = ((DataTable)resultados.Tables["InventarioAlDetalle"]).DefaultView;
            this.dataGridView1.DataSource = mifiltro;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string salida_datos = "";
            string[] palabras_busqueda = this.textBox1.Text.Split(' ');

            foreach (string palabra in palabras_busqueda)
            {
                if (salida_datos.Length == 0)
                {
                    salida_datos = "(Codigo LIKE '%" + palabra + "%' OR Color LIKE '%" + palabra + "%' OR Descripcion LIKE '%" + palabra + "%')";
                }
                else
                {
                    salida_datos += "AND (Codigo LIKE '%" + palabra + "%' OR Color LIKE '%" + palabra + "%' OR Descripcion LIKE '%" + palabra + "%')";
                }
            }

            this.mifiltro.RowFilter = salida_datos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.IdProducto = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Program.Codigo = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Program.Color = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Program.Precio = Convert.ToDouble(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            Program.Talla = Convert.ToDouble(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            Program.Descripcion = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            Program.Cantidad = Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value.ToString());
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
