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
    public partial class ClienteAlDetalle : Form
    {
        Mantenimiento procesar = new Mantenimiento();
        DO.Modapie.ClienteAlDetalle cad;

        public ClienteAlDetalle()
        {
            InitializeComponent();
        }
        private void GetValues()
        {
            cad = new DO.Modapie.ClienteAlDetalle
            {

                
               Dni=txtCedula.Text,
               Nombre = txtNombre.Text,
              Apellido1= txtApellido1.Text,
              Apellido2=txtApellido2.Text,
              Celular=txtCelular.Text,
              Telefono= txtTelefono.Text,
              Correo= txtCorreo.Text
             

                
            };
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                GetValues();
                procesar.InsertarClienteAlDetalle(cad);
                MessageBox.Show("El cliente fue ingresado al sistema correctamente", "Cliente insertado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvCAD.DataSource = procesar;
            }
            catch (Exception ee)
            {
                MessageBox.Show("El cliente no pudo ser ingresado al sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            cad = procesar.buscarCAD(txtCedula.Text);
            
            
            txtNombre.Text = cad.Nombre;
            txtApellido1.Text = cad.Apellido1;
            txtApellido2.Text = cad.Apellido2;
            txtCelular.Text = cad.Celular;
            txtTelefono.Text = cad.Telefono;
            txtCorreo.Text = cad.Correo;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
