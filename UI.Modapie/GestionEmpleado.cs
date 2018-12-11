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
    public partial class GestionEmpleado : Form
    {
        Mantenimiento procesar = new Mantenimiento();
        Empleado emp;
        public GestionEmpleado()
        {
            InitializeComponent();
        }

        private void GetValues()
        {
            emp = new Empleado
            {
                Dni = txtDni.Text,
                Nombre = txtNombre.Text,
                Apellido1 = txtApellido1.Text,
                Apellido2 = txtApellido2.Text,
                Celular = txtCelular.Text,
                Telefono = txtTelefono.Text,
                Correo = txtCorreo.Text,
                DireccionDomicilio = rtbDireccion.Text,
                SalarioMensual = Convert.ToDouble(txtSalario.Text),
                FechaContratacion = dtpFContratacion.Value.Date,
                Estado = (cbEstado.Text == "Activo") ? true : false
            };
        }

        private void GestionEmpleado_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea salir?", "CERRAR EL PROGRAMA", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                GetValues();
                procesar.InsertarEmpleado(emp);
                dgvData.DataSource = procesar.MostrarEmpleado();
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtDni.Text))
                {
                    emp = procesar.BuscarEmpleado(txtDni.Text);
                    txtNombre.Text = emp.Nombre;
                    txtApellido1.Text = emp.Apellido1;
                    txtApellido2.Text = emp.Apellido2;
                    txtCelular.Text = emp.Celular;
                    txtTelefono.Text = emp.Telefono;
                    txtCorreo.Text = emp.Correo;
                    rtbDireccion.Text = emp.DireccionDomicilio;
                    txtSalario.Text = emp.SalarioMensual.ToString();
                    cbEstado.Text = emp.Estado ? "Activo" : "Inactivo";
                    txtDni.Enabled = false;
                }
                else
                    {
                    MessageBox.Show("Campo de cédula vacío, debe digitar un valor", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Debe buscar por la cédula del empleado", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                GetValues();
                procesar.ActualizarEmpleado(emp);
                dgvData.DataSource = procesar.MostrarEmpleado();
            }
            catch(Exception ee)
            {
                throw;
            }
        }
        

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdmin M = new MenuAdmin();
            M.Show();
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizarTabla_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = procesar.MostrarEmpleado();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.SoloNumeros(e);
        }
    }
}
