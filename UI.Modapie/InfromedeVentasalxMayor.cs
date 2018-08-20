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
using BS.Modapie;
using DO.Modapie;
namespace UI.Modapie
{
    public partial class InfromedeVentasalxMayor : Form
    {
        Mantenimiento procesar = new Mantenimiento();
        public InfromedeVentasalxMayor()
        {
            InitializeComponent();
        }
     



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_BuscarPorCliente_Click(object sender, EventArgs e)
        {
            PlantillaInformeVentasAlxMayor form = new PlantillaInformeVentasAlxMayor();
            ReportDocument oRep = new ReportDocument();
            ParameterField pf = new ParameterField();
            ParameterFields pfs = new ParameterFields();
            ParameterDiscreteValue pdv = new ParameterDiscreteValue();
            pf.Name = "@Nombre";
            pfs.Add(pf);
            pdv.Value = nombre;
            pf.CurrentValues.Add(pdv);
            form.crystalReportViewer1.ParameterFieldInfo = pfs;
            oRep.Load("@C:/Users/ricar/source/repos/NewRepo/ProyectoA2/UI.Modapie/Reportes.rpt");
            form.crystalReportViewer1.ReportSource = oRep;
            form.Show();
            oRep.ExportToDisk(ExportFormatType.PortableDocFormat, @"C:\Users\ricar\Desktop\Reportes\reporteAlxMayor.pdf");

        }

        private void InfromedeVentasalxMayor_Load(object sender, EventArgs e)
        {

        }
    }
}
