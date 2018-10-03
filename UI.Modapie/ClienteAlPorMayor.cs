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
    public partial class ClienteAlPorMayor : Form
    {
        Mantenimiento procesar = new Mantenimiento();
        ClientePorMayor CAXM;
        ClientePorMayor CAXM2;

        public ClienteAlPorMayor()
        {
            InitializeComponent();
        }

        private void GetValues()
        {
            CAXM = new ClientePorMayor
            {
                cedula = txtCedulaClienteAlxMayor.Text,
                nombre = txtNombreClientealxMayor.Text,
                telefono = txtTelefonoClienteAlxMayor.Text,
                correo = txtCorreoClienteAlxMayor.Text
                
            };
        }

        private void GetValues2()
        {
            CAXM2 = new ClientePorMayor
            {
                nombre = textBox3.Text,
                telefono= textBox2.Text,
                cedula = textBox1.Text,
                correo = txtCorreoClienteAlxMayor.Text
            };
        }

        private void ClienteAlPorMayor_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea salir?", "CERRAR EL PROGRAMA", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        

        private void ClienteAlPorMayor_Load(object sender, EventArgs e)
        {

        }

       

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                GetValues();
                Mantenimiento.Instancia.Borrar(CAXM);
                dgvData.DataSource = Mantenimiento.Instancia.MostarCAXM();
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        private void dgvData_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvData.SelectedRows.Count > 0)
                {
                    int index = dgvData.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvData.Rows[index];
                    txtCedulaClienteAlxMayor.Text = Convert.ToString(selectedRow.Cells["cedula"].Value);
                    txtNombreClientealxMayor.Text = Convert.ToString(selectedRow.Cells["nombre"].Value);
                    txtCorreoClienteAlxMayor.Text = Convert.ToString(selectedRow.Cells["correo"].Value);
                    txtTelefonoClienteAlxMayor.Text = Convert.ToString(selectedRow.Cells["telefono"].Value);
                }
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvData.DataSource = procesar.MostarCAXM();
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow dgv = dgvData.Rows[e.RowIndex];
                    
                    txtCedulaClienteAlxMayor.Text = dgv.Cells["cedula"].Value.ToString();
                  txtNombreClientealxMayor.Text = dgv.Cells["nombre"].Value.ToString();
                 txtCorreoClienteAlxMayor.Text = dgv.Cells["correo"].Value.ToString();
                    txtTelefonoClienteAlxMayor.Text = dgv.Cells["telefono"].Value.ToString();
                }
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void IngresarClienteAlxMayor (object sender, EventArgs e)
        {
            try
            {
                GetValues2();
                procesar.InsertarClienteAlxMayor(CAXM2);
                MessageBox.Show("El cliente fue ingresado al sistema correctamente", "Cliente al por Mayor insertado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvData.DataSource = procesar.MostarCAXM();
            }
            catch (Exception ee)
            {
                MessageBox.Show("El cliente no pudo ser ingresado al sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCambiarEstadoCAXM_Click(object sender, EventArgs e)
        {

        }

        private void btnEditarCAXM_Click(object sender, EventArgs e)
        {
            try
            {
                GetValues();
                Mantenimiento.Instancia.Editar(CAXM);
                dgvData.DataSource = procesar.MostarCAXM();
            }
            catch (Exception ee)
            {

                throw;
            }
        }
    }
}
