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
    public partial class RegistroUsuario : Form
    {

        Mantenimiento procesar = new Mantenimiento();
        Usuario user;


        public RegistroUsuario()
        {
            InitializeComponent();
        }


        public void GetValues()
        {
            user = new Usuario
            {
                
                idEmpleado = Convert.ToInt32(txtEmpleado.Text),
                username = txtNombre.Text,
                password = txtContrasena.Text,
                rol = Convert.ToInt32(txtRol.Text)

            }
            ;
        }
       

        private void RegistroUsuario_Load(object sender, EventArgs e)
        {


        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRol_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUsuario_Click(object sender, EventArgs e)
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            user = procesar.BuscarUsuario(txtUsuario.Text);
           


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
