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
    public partial class ModificarProductoDetalle : Form
    {

        Mantenimiento procesar = new Mantenimiento();
        DO.Modapie.ProductoDetalle IAD;



        public ModificarProductoDetalle(int id, string cod,double prec,string color, double talla, string desc, int canti)
        {
            InitializeComponent();
            txtId.Text = id.ToString();
            txtCodigo.Text = cod;
            txtPrecio.Text = prec.ToString();
            txtColor.Text = color;
            txtTalla.Text = talla.ToString();
            txtDescripcion.Text = desc;
            txtCantidad.Text = canti.ToString();
        }
        private void GetValues()
        {
            IAD = new DO.Modapie.ProductoDetalle
            {

                IdProducto = Convert.ToInt32(txtId.Text),
                Codigo = txtCodigo.Text,
                PrecioUnitario = Convert.ToInt32(txtPrecio.Text),
                Color= txtColor.Text,
                Talla= Convert.ToInt32(txtTalla.Text),
                Cantidad= Convert.ToInt32(txtCantidad.Text),
                Descripcion= txtDescripcion.Text




            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionProductosAlDetalle gpd = new GestionProductosAlDetalle();
            gpd.Show();

        }

        private void btnEditarproducto_Click(object sender, EventArgs e)
        {
            try
            {
                GetValues();
                Mantenimiento.Instancia.EditarproductoDetalle(IAD);
                IAD = procesar.MostrarUnproductoDetalle(Convert.ToInt32(txtId.Text));
                dgvCAD.Rows.Add(IAD.IdProducto, IAD.Codigo, IAD.Color, IAD.Talla, IAD.Descripcion,
            IAD.Cantidad, IAD.PrecioUnitario, IAD.Estado);
                MessageBox.Show("Se edito correctamente el producto", "Editar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ee)
            {
                throw;
                //MessageBox.Show("No se pudo editar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnMostrarCAD_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrarCAD_Click_1(object sender, EventArgs e)
        {

        }
    }
}
