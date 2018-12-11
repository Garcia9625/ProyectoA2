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
using BS.Modapie;
using DO.Modapie;

namespace UI.Modapie
{
    public partial class EditarUsuario : Form
    {
        Mantenimiento procesar = new Mantenimiento();
        Usuario CAXM;
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dr;

        private void GetValues()
        {
            CAXM = new Usuario
            {
                password = txtPass.Text,
               rol = cmbRol.SelectedIndex+1,
               idEmpleado = lblCedula.Text
            
       

              

            };
        }





        public EditarUsuario(string empleado, string nomUsuario, string pass, int rol)
        {
            InitializeComponent();
            lblCedula.Text = empleado;
            lblNombre.Text = nomUsuario;
            txtPass.Text = pass;
            cmbRol.SelectedItem = rol;
        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            llenarCombo(cmbRol);
            tltModificarUsuario.SetToolTip(this.pcbRegistrar, "Modificar el usuario");
            tltModificarUsuario.SetToolTip(this.pcbCancelar, "Cancelar");
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

        private void pcbRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                GetValues();
                procesar.ModificarUsuario(CAXM);
                MessageBox.Show("El usuario fue modificado correctamente", "Usuario Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RegistroUsuario ru = new RegistroUsuario();
                ru.Show();
                this.Dispose();


            }
            catch (Exception ee)
            {
             
                
                MessageBox.Show("El usuario no pudo ser modificado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
