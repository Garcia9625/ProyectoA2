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


                Dni1 = txtCedula.Text,
                Nombre1 = txtNombre.Text,
                Apellido11 = txtApellido1.Text,
                Apellido21 = txtApellido2.Text,
                Celular1 = txtCelular.Text,
                Telefono1 = txtTelefono.Text,
                Correo1 = txtCorreo.Text



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
                Limpiar();
            }
            catch (Exception ee)
            {
                MessageBox.Show("El cliente no pudo ser ingresado al sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                cad = procesar.buscarCAD(txtCedula.Text);


                txtNombre.Text = cad.Nombre1;
                txtApellido1.Text = cad.Apellido11;
                txtApellido2.Text = cad.Apellido21;
                txtCelular.Text = cad.Celular1;
                txtTelefono.Text = cad.Telefono1;
                txtCorreo.Text = cad.Correo1;
            }
            catch (Exception ee)
            {
                MessageBox.Show("No se puede encontrar el ID digitado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                dgvCAD.DataSource = procesar.MostrarClienteXDetalle();
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                GetValues();
                Mantenimiento.Instancia.EditarCAD(cad);
                dgvCAD.DataSource = procesar.MostrarClienteXDetalle();
                Limpiar();
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdmin M = new MenuAdmin();
            M.Show();
        }

        private void ClienteAlDetalle_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dgvCAD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Limpiar()
        {
            txtNombre.Text = "";
            txtApellido1.Text = "";
            txtApellido2.Text = "";
            txtCedula.Text = "";
            txtCelular.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
        }
    }
}
