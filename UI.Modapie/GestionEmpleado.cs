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
    }
}
