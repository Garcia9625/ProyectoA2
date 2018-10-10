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
    public partial class VentaDetalle : Form
    {
        public VentaDetalle()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VentaDetalle_Activated(object sender, EventArgs e)
        {
            txtCedula.Text = Program.IdClienteDetalle;
            txtNombre.Text = Program.Nombre + " " + Program.Apellido1 + " " + Program.Apellido2;
            rtxDescripcion.Text = Program.Descripcion;
            txtCodigo.Text = Program.Codigo;
            txtColor.Text = Program.Color;
            txtTalla.Text = Convert.ToString(Program.Talla);            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Productos p = new Productos();
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClientesXDetalle cd = new ClientesXDetalle();
            cd.Show();
        }
    }
}
