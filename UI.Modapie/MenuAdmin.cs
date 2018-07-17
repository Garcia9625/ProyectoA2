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
    public partial class MenuAdmin : Form
    {
        string Username;
        public MenuAdmin(string username)
        {
            Usuario usuario = Mantenimiento.Instancia.obtenerUsuarioUser(username);
            this.Username = username;
            InitializeComponent();
            lblUsername.Text = "Hola: " + usuario.username;
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {

        }

        private void MenuAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea Salir", "CERRAR EL PROGRAMA", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnClientesPMa_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClienteAlPorMayor cpm = new ClienteAlPorMayor();
            cpm.Show();
        }
    }
}
