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

namespace DO.Modapie
{
    public partial class MenuUsuario : Form
    {
        string Username;
        public MenuUsuario(string username)
        {
            Usuario usuario = Mantenimiento.Instancia.obtenerUsuarioUser(username);
            this.Username = username;
            InitializeComponent();
            //holi
            lblUsername.Text = "Hola: " + usuario.username;
        }

        private void MenuUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea Salir", "CERRAR EL PROGRAMA", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
