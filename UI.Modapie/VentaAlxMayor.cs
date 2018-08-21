using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BS.Modapie;
using DO.Modapie;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace UI.Modapie
{
    public partial class VentaAlxMayor : Form
    {
        int posicion, lote;
        Mantenimiento procesar = new Mantenimiento();
        public VentaAlxMayor()
        {
            InitializeComponent();
            cbLote.Items.Add("Seleccione una opción");
            cbCliente.Items.Add("Seleccione una opción");
            llenarcomboCliente();
            llenarcomboLote();
            cbLote.SelectedIndex = 0;
            cbCliente.SelectedIndex = 0;
            limpiar();
            btnRegistrarVenta.Enabled = false;
        }

        public void llenarcomboLote()
        {
            List<InventarioAlxMayor> eProductos = new List<InventarioAlxMayor>();
            eProductos = procesar.obtenerListaInventarioAlxMayor();
            foreach (InventarioAlxMayor iProducto in eProductos)
            {
                cbLote.Items.Add(iProducto.IdLote1);

            }
        }

        public void llenarcomboCliente()
        {
            List<ClientePorMayor> eClientes = new List<ClientePorMayor>();
            eClientes = procesar.MostarCAXM();
            foreach (ClientePorMayor iClientes in eClientes)
            {
                cbCliente.Items.Add(iClientes.nombre);

            }
        }

        void limpiar()
        {
            btnEliminar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void CambioLote(object sender, EventArgs e)
        {
            dgvDetalle.Rows.Clear();
            if (cbLote.SelectedIndex != 0)
            {
                lote = Convert.ToInt32(cbLote.Text);
                InventarioAlxMayor iProducto = new InventarioAlxMayor();
                iProducto = procesar.obtenerLote(lote);
                dgvDetalle.Rows.Add(iProducto.IdLote1, iProducto.Codigo1, iProducto.Cliente1, iProducto.Pedido1, iProducto.Modelo1,
                    iProducto.Color1, iProducto.Descripcion1, iProducto.Pares1, iProducto.TotalImpuestos1);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            int lote = Convert.ToInt32(cbLote.Text);
            InventarioAlxMayor iProducto = procesar.obtenerLote(lote);
            /*if (iProducto.Stock >= cantidad)
            {*/
            dgvVenta.Rows.Add(iProducto.IdLote1, iProducto.Codigo1, iProducto.Cliente1, iProducto.Pedido1, iProducto.Modelo1,
            iProducto.Color1, iProducto.Descripcion1, iProducto.Pares1, iProducto.TotalImpuestos1);
            cbLote.SelectedIndex = 0;
            dgvDetalle.Rows.Clear();
            obtenerTotal();
            /*}
            else
            {
                MessageBox.Show("No se cuentan con la unidades suficientes en el inventario", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            dgvVenta.Rows.Clear();
            limpiar();
            obtenerTotal();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dgvVenta.Rows.RemoveAt(posicion);
            limpiar();
            btnAgregar.Enabled = true;
            obtenerTotal();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cbLote.SelectedIndex = 0;
            btnAgregar.Enabled = true;
            limpiar();
        }

        public List<int> obtenerDatosDGV()
        {
            List<int> listaVenta = new List<int>();
            int cantidad = dgvVenta.Rows.Count-1;
            int Lote;
            for(int i = 0; i < cantidad; i++)
            {
                Lote = Convert.ToInt32(dgvVenta.Rows[i].Cells[0].Value.ToString());
                listaVenta.Add(Lote);
            }
            return listaVenta;
        }

        public void obtenerTotal()
        {
            int cantidad = dgvVenta.Rows.Count - 1;
            double Total = 0;
            if (cantidad > 0)
            {
                for (int i = 0; i < cantidad; i++)
                {
                    Total += Convert.ToDouble(dgvVenta.Rows[i].Cells[8].Value.ToString());
                }
                btnRegistrarVenta.Enabled = true;
            }
            else
            {
                btnRegistrarVenta.Enabled = false;
            }
             txtTotal.Text =Total.ToString();
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            DO.Modapie.VentaAlxMayor ventaAlxMayor;
            DO.Modapie.VentaAlxMayor ventaAlxMayor2;
            ClientePorMayor clientePorMayor;
            InventarioAlxMayor inventarioAlxMayor;
            DescripcionVentaAlxMayor descripcionVentaAlxMayor;
            List<int> listaVenta = obtenerDatosDGV();
            bool pago = estadoVenta();
            clientePorMayor = procesar.buscarClienteAlxMayor(cbCliente.Text);
            ventaAlxMayor = new DO.Modapie.VentaAlxMayor
            {
                IdClienteMayor = clientePorMayor.idCliente,
                IdEmpleado = "2",
                Total = Convert.ToDouble(txtTotal.Text),
                Estado = pago,
                SaldoPendiente = Convert.ToDouble(txtTotal.Text) - Convert.ToDouble(txtPago.Text),
                TotalAbonado = Convert.ToDouble(txtPago.Text),
                UltimoAbono = Convert.ToDouble(txtPago.Text),
                FechaVenta = DateTime.Now
            };
            procesar.InsertarVentaAlxMayor(ventaAlxMayor);
            ventaAlxMayor2 = procesar.buscarUltimaVenta();
            int cantidadLista = listaVenta.Count;
            int Lote;
            for(int i = 0; i<cantidadLista; i++)
            {
                Lote = listaVenta[i];
                inventarioAlxMayor = procesar.obtenerLote(Lote);
                descripcionVentaAlxMayor = new DescripcionVentaAlxMayor
                {
                    IdVentaMayor = ventaAlxMayor2.IdVentaMayor,
                    IdProducto = inventarioAlxMayor.IdLote1,
                    Total = inventarioAlxMayor.TotalImpuestos1
                };
                procesar.InsertarDescripcionVentaAlxMayor(descripcionVentaAlxMayor);
            }
            MessageBox.Show("Venta Registrada");

            FacturaVentasAlxMayor form = new FacturaVentasAlxMayor();
            ReportDocument oRep = new ReportDocument();
            ParameterField pf = new ParameterField();
            ParameterFields pfs = new ParameterFields();
            ParameterDiscreteValue pdv = new ParameterDiscreteValue();
            pf.Name = "@Nombre";
            pfs.Add(pf);
            pdv.Value =cbCliente.Text;
            pf.CurrentValues.Add(pdv);
            form.crystalReportViewer1.ParameterFieldInfo = pfs;
            oRep.Load("C:/Users/ricar/source/repos/NewRepo/ProyectoA2/UI.Modapie/FacturaVentaAlxMayor.rpt");
            form.crystalReportViewer1.ReportSource = oRep;
            form.Show();
            oRep.ExportToDisk(ExportFormatType.PortableDocFormat, @"C:\Users\ricar\Desktop\Reportes\FacturaVentaAlxMayor.pdf");


        }

        public bool estadoVenta()
        {
            double total = Convert.ToDouble(txtTotal.Text);
            double pago = Convert.ToDouble(txtPago.Text);
            if (total > pago)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdmin M = new MenuAdmin();
            M.Show();
        }

        private void DatoSeleccionado(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dgvVenta.CurrentRow.Index;

            btnAgregar.Enabled = false;
            btnEliminar.Enabled = true;
            btnCancelar.Enabled = true;
        }
    }
}
