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
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void btnVentasDet_Click(object sender, EventArgs e)
        {
            GestionEmpleado ge = new GestionEmpleado();
            frmEmpleados.ActiveForm.Dispose();
            ge.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistroUsuario ru = new RegistroUsuario();
            frmEmpleados.ActiveForm.Dispose();
            ru.Show();
        }
    }
}
