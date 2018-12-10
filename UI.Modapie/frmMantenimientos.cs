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
    public partial class frmMantenimientos : Form
    {
        public frmMantenimientos()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ImportarExcel1 ie = new ImportarExcel1();
            frmMantenimientos.ActiveForm.Dispose();
            ie.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GestionProductosAlDetalle gpd = new GestionProductosAlDetalle();
            frmMantenimientos.ActiveForm.Dispose();
            gpd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClienteAlPorMayor cam = new ClienteAlPorMayor();
            frmMantenimientos.ActiveForm.Dispose();
            cam.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClienteAlDetalle cad = new ClienteAlDetalle();
            frmMantenimientos.ActiveForm.Dispose();
            cad.Show();
        }
    }
}
