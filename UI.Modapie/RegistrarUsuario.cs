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
    public partial class RegistrarUsuario : Form
    {
        public RegistrarUsuario()
        {
            InitializeComponent();

        }


        Mantenimiento procesar = new Mantenimiento();
        Usuario  user;



        private void GetValues()
        {
            user = new DO.Modapie.Usuario
            {


                Dni1 = txtCedula.Text,
                Nombre1 = txtNombre.Text,
                Apellido11 = txtApellido1.Text,
                Apellido21 = txtApellido2.Text,
                Celular1 = txtCelular.Text,
                Telefono1 = txtTelefono.Text,
                Correo1 = txtCorreo.Text



            };
        }

        private void RegistrarUsuario_Load(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea salir?", "CERRAR EL PROGRAMA", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }
        
    }
}
