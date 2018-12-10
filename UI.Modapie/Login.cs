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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {

        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea Salir", "CERRAR EL PROGRAMA", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            tltInicio.SetToolTip(this.pcBInicio, "Iniciar Sesión");
            tltInicio.SetToolTip(this.btn_apagar, "Cerrar el Programa");
            Fechaa.Text = DateTime.Now.ToShortDateString();
            Horaa.Text = DateTime.Now.ToLongTimeString();
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            Horaa.Text = DateTime.Now.ToLongTimeString();
        }

        private void pcBInicio_Click(object sender, EventArgs e)
        {
            try
            {
                //validacion de campos completos
                if (txtID.Text != "" && txtContrasena.Text != "")
                {
                    int respuesta = Mantenimiento.Instancia.validarLogin(txtID.Text, txtContrasena.Text);
                    //Usuario correcto
                    if (respuesta == 1)
                    {
                        //Si el usuario es correcto obtiene el usuario desde la base de datos para validar el rol
                        Usuario usuario = Mantenimiento.Instancia.obtenerUsuarioUser(txtID.Text);
                        if (usuario.rol == 1)
                        {
                            Form admin = new MenuAdmin();//MenuAdmin(usuario.username);
                            //Form admin = new MenuAdmin();
                            this.Hide();
                            admin.Show();
                        }
                        else
                        {
                            Form normal = new MenuUsuario();
                            this.Hide();
                            normal.Show();
                        }
                    }
                    //Se encontro el usuario pero la contraseña es incorrecta
                    else if (respuesta == 0)
                    {
                        DialogResult d = MessageBox.Show("Usuario o contraseña incorrectos", "Error");
                    }
                    //No se encuentra el usuario
                    else if (respuesta == 2)
                    {
                        DialogResult mensaje = MessageBox.Show("Usuario no encontrado,favor contactar con un administrador", "Error");
                    }

                }
                else
                {
                    DialogResult d = MessageBox.Show("Todos los campos deben estar completos.");
                }

            }
            catch (Exception ee)
            {

                DialogResult d = MessageBox.Show(ee.Message.ToString());
            }
        }

        private void pcBInicio_MouseHover(object sender, EventArgs e)
        {
            pcBInicio.Size = new Size(76, 74);
            pcBInicio.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void pcBInicio_MouseLeave(object sender, EventArgs e)
        {
            pcBInicio.BackgroundImageLayout = ImageLayout.Stretch;
            pcBInicio.Size = new Size(61, 62);
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    //validacion de campos completos
                    if (txtID.Text != "" && txtContrasena.Text != "")
                    {
                        int respuesta = Mantenimiento.Instancia.validarLogin(txtID.Text, txtContrasena.Text);
                        //Usuario correcto
                        if (respuesta == 1)
                        {
                            //Si el usuario es correcto obtiene el usuario desde la base de datos para validar el rol
                            Usuario usuario = Mantenimiento.Instancia.obtenerUsuarioUser(txtID.Text);
                            if (usuario.rol == 1)
                            {
                                Form admin = new MenuAdmin();
                                //Form admin = new MenuAdmin();
                                this.Hide();
                                admin.Show();
                            }
                            else
                            {
                                Form normal = new MenuUsuario();
                                this.Hide();
                                normal.Show();
                            }
                        }
                        //Se encontro el usuario pero la contraseña es incorrecta
                        else if (respuesta == 0)
                        {
                            DialogResult d = MessageBox.Show("Usuario o contraseña incorrectos", "Error");
                        }
                        //No se encuentra el usuario
                        else if (respuesta == 2)
                        {
                            DialogResult mensaje = MessageBox.Show("Usuario no encontrado,favor contactar con un administrador", "Error");
                        }

                    }
                    else
                    {
                        DialogResult d = MessageBox.Show("Todos los campos deben estar completos.");
                    }
                }
                catch (Exception ee)
                {

                    DialogResult d = MessageBox.Show(ee.Message.ToString());
                }
            }

        }

        private void AbrirRecuperación(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form normal = new RecuperacionContraseña();
            this.Hide();
            normal.Show();
        }
    }
}