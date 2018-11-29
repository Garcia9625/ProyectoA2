using CrystalDecisions.CrystalReports.Engine;
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
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void btnVentasDet_Click(object sender, EventArgs e)
        {
            CuentasPorCobrar cxc = new CuentasPorCobrar();
            ReportDocument oRep = new ReportDocument();
            oRep.Load(Application.StartupPath + "\\Reportes\\CuentasXCobrar.rpt");
            //oRep.Load(@"C:\Users\ricar\source\repos\NewRepo\ProyectoA2\UI.Modapie\CuentasXCobrar.rpt");
            cxc.crystalReportViewer1.ReportSource = oRep;
            cxc.Show();
        }
    }
}
