using BS.Modapie;
using DO.Modapie;
using System.Data.SqlClient;
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
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dr;

        public ClienteAlPorMayor()
        {
            
            InitializeComponent();
            dgvData.DataSource = procesar.MostarCAXM();
        }

        private void GetValues()
        {
            CAXM = new ClientePorMayor
            {
                idCliente=  Convert.ToInt32(txtIdClienteInvisible.Text),
                cedula = txtCedulaClienteAlxMayor.Text,
                nombre = txtNombreClientealxMayor.Text,
                telefono = txtTelefonoClienteAlxMayor.Text,
                correo = txtCorreoClienteAlxMayor.Text,
                estado= (txtEstado.Text == "Activo") ? true : false
                
            };
        }

        private void GetValues2()
        {
            CAXM2 = new ClientePorMayor
            {
                nombre = txtNombreClientealxMayor.Text,
                telefono = txtTelefonoClienteAlxMayor.Text,
                cedula = txtCedulaClienteAlxMayor.Text,
                correo = txtCorreoClienteAlxMayor.Text,
                estado = true
            };
        }

        private void ClienteAlPorMayor_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea salir?", "CERRAR EL PROGRAMA", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void Limpiar()
        {
            txtCedulaClienteAlxMayor.Text = "";
            txtNombreClientealxMayor.Text = "";
            txtCorreoClienteAlxMayor.Text = "";
            txtTelefonoClienteAlxMayor.Text = "";
            txtEstado.Text = "";
            btnEditarCAXM.Enabled = false;
            btnBorrar.Enabled = false;


            if (!string.IsNullOrEmpty(txtCedulaClienteAlxMayor.Text))
            {
                if (!string.IsNullOrEmpty(txtNombreClientealxMayor.Text))
                {
                    if (!string.IsNullOrEmpty(txtTelefonoClienteAlxMayor.Text))
                    {
                        if (!string.IsNullOrEmpty(txtCorreoClienteAlxMayor.Text))
                        {

                        }
                    }
                }
            }

        }


        private void ClienteAlPorMayor_Load(object sender, EventArgs e)
        {
            btnEditarCAXM.Enabled = false;
            btnBorrar.Enabled = false;

        }

       
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                GetValues();
                if (CAXM.estado == true)
                {
                    CAXM.estado = false;
                }
                else
                {
                    CAXM.estado = true;
                }
                Mantenimiento.Instancia.Borrar(CAXM);
                dgvData.DataSource = Mantenimiento.Instancia.MostarCAXM();
                Limpiar();
                button6.Enabled = true;
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
                    button6.Enabled = false;
                    btnBorrar.Enabled = true;
                    btnEditarCAXM.Enabled = true;
                    int index = dgvData.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvData.Rows[index];
                    txtIdClienteInvisible.Text = Convert.ToString(selectedRow.Cells["idCliente"].Value);
                    txtCedulaClienteAlxMayor.Text = Convert.ToString(selectedRow.Cells["cedula"].Value);
                    txtNombreClientealxMayor.Text = Convert.ToString(selectedRow.Cells["nombre"].Value);
                    txtCorreoClienteAlxMayor.Text = Convert.ToString(selectedRow.Cells["correo"].Value);
                    txtTelefonoClienteAlxMayor.Text = Convert.ToString(selectedRow.Cells["telefono"].Value);
                    txtEstado.Text = Convert.ToString(selectedRow.Cells["estado"].Value);
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
                button6.Enabled = true;
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
                    button6.Enabled = false;
                    btnBorrar.Enabled = true;
                    btnEditarCAXM.Enabled = true;
                    DataGridViewRow dgv = dgvData.Rows[e.RowIndex];
                    txtIdClienteInvisible.Text = dgv.Cells["idCliente"].Value.ToString();
                    txtCedulaClienteAlxMayor.Text = dgv.Cells["cedula"].Value.ToString();
                  txtNombreClientealxMayor.Text = dgv.Cells["nombre"].Value.ToString();
                 txtCorreoClienteAlxMayor.Text = dgv.Cells["correo"].Value.ToString();
                    txtTelefonoClienteAlxMayor.Text = dgv.Cells["telefono"].Value.ToString();
                    if(Convert.ToBoolean(dgv.Cells["estado"].Value.ToString())== true)
                    {
                        txtEstado.Text = "Activo";
                    }
                    else
                    {
                        txtEstado.Text = "Inactivo";
                    }
                   
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
                Limpiar();
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
                Limpiar();
                button6.Enabled = true;
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
        
        }

        private void btnActualizarTablaCAXM_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void label2_Click(object sender, EventArgs e)
        {
        
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
