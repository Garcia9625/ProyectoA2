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
    public partial class frmClientesUsuario : Form
    {
        public frmClientesUsuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClienteAlDetalle cad = new ClienteAlDetalle();
            frmMantenimientos.ActiveForm.Dispose();
            cad.Show();
        }
    }
}
