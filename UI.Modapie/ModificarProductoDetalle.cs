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
        public ModificarProductoDetalle(string cod,double prec,string color, double talla, string desc, int canti)
        {
            InitializeComponent();
            txtCodigo.Text = cod;
            txtPrecio.Text = prec.ToString();
            txtColor.Text = color;
            txtTalla.Text = talla.ToString();
            txtDescripcion.Text = desc;
            txtCantidad.Text = canti.ToString();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

        }
    }
}
