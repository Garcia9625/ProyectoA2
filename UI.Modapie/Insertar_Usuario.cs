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
    public partial class Insertar_Usuario : Form
    {
        Mantenimiento procesar = new Mantenimiento();
        Usuario user;
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dr;

        public Insertar_Usuario()
        {

           
            InitializeComponent();
        }
      

        public void GetValues()
        {
            user = new Usuario
            {
                idEmpleado = txtEmpleado.Text,
                username = txtNombre.Text,
                password = txtContrasena.Text,
                rol = cmbRol.SelectedIndex + 1
            };
        }
        private void Conexion()
        {
            try
            {
                cnn = new SqlConnection("Data Source=.;Initial Catalog=DBMODAPIE;Integrated Security=True");
                cnn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto: " + ex.ToString());
            }
        }

        private void llenarCombo(ComboBox cb)
        {
            Conexion();
            cmd = new SqlCommand("Select Descripcion from Roles", cnn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cb.Items.Add(dr["Descripcion"].ToString());
            }
            dr.Close();

            cb.SelectedIndex = 0;
        }
        private void pcbRegistrar_MouseHover(object sender, EventArgs e)
        {
            pcbRegistrar.Size = new Size(60, 57);
            pcbRegistrar.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void pcbRegistrar_MouseLeave(object sender, EventArgs e)
        {
            pcbRegistrar.BackgroundImageLayout = ImageLayout.Stretch;
            pcbRegistrar.Size = new Size(52, 49);
        }

        private void pcbRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                GetValues();
                procesar.iInsertarUsuario(user);

                RegistroUsuario ru = new RegistroUsuario();
                ru.Show();
                this.Dispose();
            }
            catch (Exception ee)
            {
                throw;
                //MessageBox.Show("El usuario no pudo ser creado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Insertar_Usuario_Load(object sender, EventArgs e)
        {
            llenarCombo(cmbRol);
            tltUsuario.SetToolTip(this.pcbRegistrar, "Registrar el usuario");
            tltUsuario.SetToolTip(this.pcbCancelar, "Cancelar");
        }

        private void pcbCancelar_MouseHover(object sender, EventArgs e)
        {
            pcbCancelar.Size = new Size(60, 57);
            pcbCancelar.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void pcbCancelar_MouseLeave(object sender, EventArgs e)
        {
            pcbCancelar.BackgroundImageLayout = ImageLayout.Stretch;
            pcbCancelar.Size = new Size(52, 49);
        }

        private void pcbCancelar_Click(object sender, EventArgs e)
        {
            RegistroUsuario ru = new RegistroUsuario();
            ru.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdmin M = new MenuAdmin();
            M.Show();
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
