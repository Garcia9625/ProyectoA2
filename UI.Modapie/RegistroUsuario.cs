using BS.Modapie;
using DO.Modapie;
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
    public partial class RegistroUsuario : Form
    {

        Mantenimiento procesar = new Mantenimiento();
        Usuario user;


        public RegistroUsuario()
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

        private void RegistroUsuario_Load(object sender, EventArgs e)
        {
            this.leer_datos("SELECT * FROM Usuario", ref resultados, "Usuario");
            this.mifiltro = ((DataTable)resultados.Tables["Usuario"]).DefaultView;
            this.dataGridView1.DataSource = mifiltro;
        }

        

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            Insertar_Usuario iu = new Insertar_Usuario();
            iu.Show();
            this.Dispose();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdmin M = new MenuAdmin();
            M.Show();
        }

        private void txtEmpleado_KeyUp(object sender, KeyEventArgs e)
        {
            string salida_datos = "";
            string[] palabras_busqueda = this.txtEmpleado.Text.Split(' ');

            foreach (string palabra in palabras_busqueda)
            {
                if (salida_datos.Length == 0)
                {
                    salida_datos = "(Username LIKE '%" + palabra + "%' OR IdEmpleado LIKE '%" + palabra + "%' OR Password LIKE '%" + palabra + "%')";
                }
                else
                {
                    salida_datos += "AND (Username LIKE '%" + palabra + "%' OR IdEmpleado LIKE '%" + palabra + "%' OR Password LIKE '%" + palabra + "%')";
                }
            }
            
            this.mifiltro.RowFilter = salida_datos;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String empleado = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            String nomUsuario = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            String pass = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            int rol = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            

            EditarUsuario edit = new EditarUsuario(empleado, nomUsuario, pass, rol);
            edit.Show();
            this.Dispose();
        }
    }
}
