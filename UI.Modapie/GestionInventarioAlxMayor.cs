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
            if (MessageBox.Show("¿Esta seguro que desea salir?", "CERRAR SESION", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Login l = new Login();
                l.Show();
                this.Dispose();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!txtLote.Text.Equals(""))
            {
                try
                {
                    InventarioAlxMayor prod = Mantenimiento.Instancia.obtenerLote(Convert.ToInt32(txtLote.Text));

                    txtOrdenEnvio.Text = prod.EnvioOrden1.ToString();
                    txtShow.Text = prod.Show1;
                    txtCodigo.Text = prod.Codigo1.ToString();
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
                    txtPrecioUnitario.Text = prod.PrecioUnitario1.ToString();
                    txtSubTotal.Text = Convert.ToString(prod.SubTotal1);
                    txtTotalImpuestos.Text = Convert.ToString(prod.TotalImpuestos1);
                    txtEstado.Text = prod.Estado2 ? "Disponible" : "Desactivado";
                }
                catch (Exception ee)
                {

                    DialogResult d = MessageBox.Show(ee.Message.ToString(), "Error");
                }
            }
            else
                MessageBox.Show("El campo IdLote se encuentra en blanco", "Error", MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                //Se pide la confirmacion del usuario para eliminar
                DialogResult dialogResult = MessageBox.Show("Esta seguro que desea eliminar este producto?", "Eliminar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Mantenimiento.Instancia.EliminarProdXMayor(Convert.ToInt32(txtLote.Text));
                    limpiar();
                }
            }
            catch (Exception ee)
            {

                DialogResult d = MessageBox.Show(ee.GetBaseException().ToString(), "Error");
            }
        }


        private void limpiar()
        {
            txtOrdenEnvio.Text = "";
            txtShow.Text           = "";
            txtCodigo.Text         = "";
            txtCliente.Text        = "";
            txtVendedor.Text       = "";
            txtZona.Text           = "";
            txtTransporte.Text     = "";
            txtPedido.Text         = "";
            txtModelo.Text         = "";
            txtColor.Text          = "";
            rtbDescripcion.Text    = "";
            txtCurva.Text          = "";
            txtPares.Text          = "";
            txtCajas.Text          = "";
            txtCif.Text            = "";
            txtTotalCif.Text       = "";
            txtPrecioUnitario.Text = "";
            txtSubTotal.Text       = "";
            txtTotalImpuestos.Text = "";
            txtLote.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdmin M = new MenuAdmin();
            M.Show();
        }
    }
}
