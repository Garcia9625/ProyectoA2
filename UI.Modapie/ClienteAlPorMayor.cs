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
            {/*
                idCliente = Convert.ToInt32(txtId.Text),
                nombreJuridico = txtJuridico.Text,
                nombreFisico = txtFisico.Text,
                nombreFantasia = txtFantasia.Text
                */

            };
        }

        private void GetValues2()
        {
            CAXM2 = new ClientePorMayor

            {/*
                nombreJuridico = txtJuridico.Text,
                nombreFisico = txtFisico.Text,
                nombreFantasia = txtFantasia.Text
                */
            };
        }

        private void ClienteAlPorMayor_FormClosed(object sender, FormClosedEventArgs e)
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
                GetValues2();
                procesar.InsertarCAlxMayor(CAXM2);
                dgvData.DataSource = procesar.MostarCAXM();
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        private void ClienteAlPorMayor_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
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
                    txtId.Text = Convert.ToString(selectedRow.Cells["idCliente"].Value);
                    txtJuridico.Text = Convert.ToString(selectedRow.Cells["nombreJuridico"].Value);
                    txtFisico.Text = Convert.ToString(selectedRow.Cells["nombreFisico"].Value);
                    txtFantasia.Text = Convert.ToString(selectedRow.Cells["nombreFantasia"].Value);
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

                    txtId.Text = dgv.Cells["idCliente"].Value.ToString();
                    txtJuridico.Text = dgv.Cells["nombreJuridico"].Value.ToString();
                    txtFisico.Text = dgv.Cells["nombreFisico"].Value.ToString();
                    txtFantasia.Text = dgv.Cells["nombreFantasia"].Value.ToString();
                }
            }
            catch (Exception ee)
            {
                throw;
            }
        }
    }
}
