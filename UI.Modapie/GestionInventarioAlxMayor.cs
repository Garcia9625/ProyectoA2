using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DO.Modapie;
using BS.Modapie;

namespace UI.Modapie
{
    public partial class GestionInventarioAlxMayor : Form
    {
        public GestionInventarioAlxMayor()
        {
            InitializeComponent();
        }

        private void GestionInventarioAlxMayor_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {                
              ProductosAlxMayor prod = Mantenimiento.Instancia.obtenerLote(Convert.ToInt32(txtLote.Text));


                txtOrdenEnvio.Text = Convert.ToString(prod.EnvioOrden1);
                txtShow.Text = prod.Show1;             
                txtCliente.Text = prod.Cliente1;
                txtVendedor.Text = Convert.ToString(prod.Vendedor1);
                txtZona.Text = Convert.ToString(prod.Zona1);
                txtTransporte.Text = Convert.ToString(prod.Transporte1);
                txtPedido.Text = prod.Pedido1;
                txtModelo.Text = Convert.ToString(prod.Modelo1);
                txtColor.Text = Convert.ToString(prod.Color1);
                rtbDescripcion.Text = prod.Descripcion1;
                txtCurva.Text = prod.Curva1;
                txtPares.Text = Convert.ToString(prod.Pares1);
                txtCajas.Text = Convert.ToString(prod.Cajas1);
                txtCif.Text = Convert.ToString(prod.Cif1);
                txtTotalCif.Text = Convert.ToString(prod.TotalCIF1);
                txtSubTotal.Text = Convert.ToString(prod.SubTotal1);
                txtTotalImpuestos.Text = Convert.ToString(prod.TotalImpuestos1);
            }
            catch (Exception ee)
            {

                DialogResult d = MessageBox.Show(ee.Message.ToString(), "Error");
            }
        }
    }
}
