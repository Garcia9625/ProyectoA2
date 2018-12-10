using System;
using BS.Modapie;
using DO.Modapie;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.IO;

namespace UI.Modapie
{
    public partial class RecuperacionContraseña : Form
    {
        public Usuario cuenta;
        public RecuperacionContraseña()
        {
            InitializeComponent();
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsuarioRecuperacion.Text;
                    var existe = Mantenimiento.Instancia.BuscarCorreo(usuario);
                    if (existe != null)
                    {
                        string contra = GenerarContra();
                        string cuerpo = System.IO.File.ReadAllText(Application.StartupPath + "\\Correo\\recuperacion.html");
                        cuerpo = cuerpo.Replace("#Cliente#", usuario);
                        cuerpo = cuerpo.Replace("#Contra#", contra);
                        Correo c1 = new Correo();
                        c1.Destinatarios = existe;
                        c1.Asunto = "Recuperación de Cuenta";
                        c1.Cuerpo = cuerpo;

                        System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();
                        System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
                        cliente.UseDefaultCredentials = false;
                        cliente.Credentials = new System.Net.NetworkCredential("proyectoPrograV@outlook.com", "prueba123");

                        mmsg.Subject = c1.Asunto;
                        mmsg.SubjectEncoding = System.Text.Encoding.UTF8;
                        mmsg.Body = c1.Cuerpo;
                        mmsg.BodyEncoding = System.Text.Encoding.UTF8;
                        mmsg.IsBodyHtml = true;
                        mmsg.From = new MailAddress("proyectoPrograV@outlook.com");
                        cliente.Host = "smtp.live.com";
                        cliente.Port = 587;
                        cliente.EnableSsl = true;
                        mmsg.To.Add(new MailAddress(c1.Destinatarios));
                        cliente.Send(mmsg);
                        Mantenimiento.Instancia.ModificarUsuarioContrasena(usuario, contra);
                    MessageBox.Show("Contraseña Recuperada");
                    btnRecuperar.Enabled = false;
                    Login lo = new Login();
                    this.Dispose();
                    lo.Show();
                }
                    else
                    {
                    MessageBox.Show("No existe el usuario");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error");
                throw;
            }
        }
        private string GenerarContra()
        {
            int longitud = 8;
            Guid miGuid = Guid.NewGuid();
            string token = Convert.ToBase64String(miGuid.ToByteArray());
            token = token.Replace("=", "").Replace("+", "").Replace("/", "");
            token = token.Substring(0, longitud);
            return token;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Login lo = new Login();
            this.Dispose();
            lo.Show();
        }
    }
}
