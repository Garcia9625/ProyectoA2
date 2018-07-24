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
                idCliente = Convert.ToInt32(txtId.Text),
                nombreJuridico = txtJuridico.Text,
                nombreFisico = txtFisico.Text,
                nombreFantasia = txtFantasia.Text                 
            };
        }

        private void GetValues2()
        {
            CAXM2 = new ClientePorMayor
            {
                nombreJuridico = txtJuridico.Text,
                nombreFisico = txtFisico.Text,
                nombreFantasia = txtFantasia.Text
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

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
