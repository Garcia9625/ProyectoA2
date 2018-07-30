using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DO.Modapie;
using BS.Modapie;

namespace UI.Modapie
{
    public partial class GestionInventarioAlxMayor : Form
    {
        public GestionInventarioAlxMayor()
        {
            InitializeComponent();
        }

        private void GestionInventarioAlxMayor_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {                
              ProductosAlxMayor prod = Mantenimiento.Instancia.obtenerLote(Convert.ToInt32(txtLote.Text));


              //txtTitulo.Text = tarea.Titulo;
              //txtDescripcion.Text = tarea.Descripcion;
              //dtpInicio.Value = tarea.FechaInicio;
              //dtpFinalizacion.Value = tarea.FechaFinalizacion;
              //txtNumTarea.Text = tarea.Codigo + "";
                
            }
            catch (Exception ee)
            {

                DialogResult d = MessageBox.Show(ee.Message.ToString(), "Error");
            }
        }
    }
}
