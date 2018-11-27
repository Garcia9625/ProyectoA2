using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Modapie;

namespace UI.Modapie
{
    public partial class frmVentas : Form 
    {
        
        public frmVentas()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnVentasDet_Click(object sender, EventArgs e)
        {
            VentaDetalle vd = new VentaDetalle();
            MenuAdmin.ActiveForm.Dispose();
            vd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuAdmin.ActiveForm.Dispose();
            VentaAlxMayor GIAM = new VentaAlxMayor();
            GIAM.Show();
        }
    }
}
