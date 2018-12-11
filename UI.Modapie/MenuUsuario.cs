using BS.Modapie;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Modapie;

namespace DO.Modapie
{
    public partial class MenuUsuario : Form
    {
        public MenuUsuario()
        {
            InitializeComponent();
            tltCerrar.SetToolTip(this.pictureBox13, "Cerrar Sesión");
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelMenu.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelMenu.Controls.Add(formulario);
                panelMenu.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmVentaUsuario>();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro que desea salir?", "CERRAR SESIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                Login lo = new Login();
                this.Dispose();
                lo.Show();
            }
            else { }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmClientesUsuario>();
        }

        private void pictureBox13_MouseHover(object sender, EventArgs e)
        {
            pictureBox13.Size = new Size(54, 54);
            pictureBox13.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void pictureBox13_MouseLeave(object sender, EventArgs e)
        {
            pictureBox13.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox13.Size = new Size(42, 42);
        }
    }
}
