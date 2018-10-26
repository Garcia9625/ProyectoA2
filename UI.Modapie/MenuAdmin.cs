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
        string user;
        public MenuAdmin(string username)
        {
            InitializeComponent();
            Usuario usuario = Mantenimiento.Instancia.obtenerUsuarioUser(username);
            this.user = username;
            //lblUsername.Text = "Bienvenido: " + usuario.username;
        }
        public MenuAdmin()
        {
            InitializeComponent();
            //lblUsername.Text = "Bienvenido: " + usuario.username;
        }
        private void MenuAdmin_Load(object sender, EventArgs e)
        {

        }

        private void MenuAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea salir?", "CERRAR SESIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Dispose();
                Login lo = new Login();
                lo.Show();
            }
        }

        private void btnClientesPMa_Click(object sender, EventArgs e)
        {
            this.Dispose();
            ClienteAlPorMayor cpm = new ClienteAlPorMayor();
            cpm.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            this.Dispose();
            ImportarExcel1 PI = new ImportarExcel1();
            PI.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            VentaAlxMayor GIAM = new VentaAlxMayor();
            GIAM.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            GestionEmpleado GE = new GestionEmpleado();
            GE.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            ClienteAlDetalle CAD = new ClienteAlDetalle();
            CAD.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VentaDetalle vd = new VentaDetalle();
            this.Dispose();
            vd.Show();
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            this.Dispose();
            InformeDeCuentas info = new InformeDeCuentas();
            info.Show();
        }

        private void btn_GIAXM_Click(object sender, EventArgs e)
        {
            this.Dispose();
            GestionInventarioAlxMayor GIAXM = new GestionInventarioAlxMayor();
            GIAXM.Show();
        }

        private void btn_NuevoUsuario_Click(object sender, EventArgs e)
        {
            this.Dispose();
            RegistroUsuario registrousuario = new RegistroUsuario();
            registrousuario.Show();

        }

        private void btnVentasAlXM_Click(object sender, EventArgs e)
        {
            this.Dispose();
            VentaAlxMayor ventaxMayor = new VentaAlxMayor();
            ventaxMayor.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
