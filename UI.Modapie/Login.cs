﻿using BS.Modapie;
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
            //Saludos rata
            
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
                            Form admin = new MenuAdmin(usuario.username);
                            this.Hide();
                            admin.Show();
                        }
                        else
                        {
                            Form normal = new MenuUsuario(usuario.username);
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

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea Salir", "CERRAR EL PROGRAMA", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Fechaa_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Fechaa.Text = DateTime.Now.ToString("dd/MM/yyyy");
            Horaa.Text = DateTime.Now.ToString("HH:mm");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
