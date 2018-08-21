using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace UI.Modapie
{
    public partial class InformeDeCuentas : Form
    {
        public InformeDeCuentas()
        {
            InitializeComponent();
        }

        private void btnInfXC_Click(object sender, EventArgs e)
        {
            CuentasPorCobrar cxc = new CuentasPorCobrar();
            ReportDocument oRep = new ReportDocument();
            oRep.Load(@"C:\Users\Diego\source\repos\ProyectoA2\UI.Modapie\CuentasXCobrar.rpt");
            cxc.crystalReportViewer1.ReportSource = oRep;
            cxc.Show();
        }
    }
}
