using BS.Modapie;
using DO.Modapie;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                rol = Convert.ToInt32(cmbRol.SelectedText)

            };
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
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        private void Insertar_Usuario_Load(object sender, EventArgs e)
        {
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
    }
}
