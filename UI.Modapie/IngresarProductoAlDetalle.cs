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
    public partial class IngresarProductoAlDetalle : Form
    {
        Mantenimiento procesar = new Mantenimiento();
        DO.Modapie.ProductoDetalle pd;
        public IngresarProductoAlDetalle()
        {
            InitializeComponent();
        }
        private void GetValues()
        {
            pd = new DO.Modapie.ProductoDetalle
            {

                //IdProducto = Convert.ToInt32(txtId.Text),
                Codigo = txtCodigo.Text,
                PrecioUnitario = Convert.ToInt32(txtPrecio.Text),
                Color = txtColor.Text,
                Talla = Convert.ToInt32(txtTalla.Text),
                Cantidad = Convert.ToInt32(txtCantidad.Text),
                Descripcion = txtDescripcion.Text




            };
        }

        private void btnIngresarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                GetValues();
                procesar.InsertarProductoDetalle(pd);
                MessageBox.Show("El producto fue ingresado al sistema correctamente", "Producto insertado", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            catch (Exception ee)
            {
                throw;
                //MessageBox.Show("El producto no pudo ser ingresado al sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionProductosAlDetalle gpd = new GestionProductosAlDetalle();
            gpd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionProductosAlDetalle gpd = new GestionProductosAlDetalle();
            gpd.Show();
        }
    }
}
