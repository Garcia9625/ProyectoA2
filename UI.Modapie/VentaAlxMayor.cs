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
        DO.Modapie.VentaAlxMayor ventaAlxMayor2;
        int numFact;
        public VentaAlxMayor()
        {
            InitializeComponent();
            cbCliente.Items.Add("Seleccione una opción");
            cbEmpleado.Items.Add("Seleccione una opción");
            cargarEnLimpio();
            llenarcomboCliente();
            llenarComboEmpleado();
            limpiar();
        }

        private void cargarEnLimpio()
        {
            cbLote.Items.Clear();
            cbLote.Items.Add("Seleccione una opción");
            llenarcomboLote();
            cbLote.SelectedIndex = 0;
            cbCliente.SelectedIndex = 0;
            cbEmpleado.SelectedIndex = 0;
            btnRegistrarVenta.Enabled = false;
            cbLote.Enabled = false;
            btnAgregar.Enabled = false;
            dgvVenta.Rows.Clear();
            txtTotal.Text = "0";
            txtPago.Text = "";
            buscarUltimaVenta();

        }
        private void llenarcomboLote()
        {
            List<InventarioAlxMayor> eProductos = new List<InventarioAlxMayor>();
            eProductos = procesar.obtenerListaInventarioAlxMayor();
            foreach (InventarioAlxMayor iProducto in eProductos)
            {
                cbLote.Items.Add(iProducto.IdLote1);

            }
        }

        private void llenarcomboCliente()
        {
            List<ClientePorMayor> eClientes = new List<ClientePorMayor>();
            eClientes = procesar.MostarCAXM();
            foreach (ClientePorMayor iClientes in eClientes)
            {
                cbCliente.Items.Add(iClientes.nombre);

            }
        }

        private void llenarComboEmpleado()
        {
            List<Empleado> eEmpleado = new List<Empleado>();
            eEmpleado = procesar.MostrarEmpleado();
            foreach (Empleado iEmpleado in eEmpleado)
            {
                cbEmpleado.Items.Add(iEmpleado.Dni);

            }
        }
        private void limpiar()
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
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            int lote = Convert.ToInt32(cbLote.Text);
            InventarioAlxMayor iProducto = procesar.obtenerLote(lote);
            dgvVenta.Rows.Add(iProducto.IdLote1, iProducto.Codigo1, iProducto.Cliente1, iProducto.Pedido1, iProducto.Modelo1,
            iProducto.Color1, iProducto.Descripcion1, iProducto.Pares1, iProducto.TotalImpuestos1);
            cbLote.SelectedIndex = 0;
            dgvDetalle.Rows.Clear();
            obtenerTotal();
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

        private List<int> obtenerDatosDGV()
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
            if (txtPago.Text != "" && cbCliente.SelectedIndex != 0)
            {
                try
                {
                    DO.Modapie.VentaAlxMayor ventaAlxMayor;
                    ClientePorMayor clientePorMayor;
                    InventarioAlxMayor inventarioAlxMayor;
                    DescripcionVentaAlxMayor descripcionVentaAlxMayor;
                    List<int> listaVenta = obtenerDatosDGV();
                    bool pago = estadoVenta();
                    clientePorMayor = procesar.buscarClienteAlxMayor(cbCliente.Text);
                    ventaAlxMayor = new DO.Modapie.VentaAlxMayor
                    {
                        IdClienteMayor = clientePorMayor.idCliente,
                        IdEmpleado = cbEmpleado.Text,
                        Total = Convert.ToDouble(txtTotal.Text),
                        Estado = pago,
                        SaldoPendiente = Convert.ToDouble(txtTotal.Text) - Convert.ToDouble(txtPago.Text),
                        TotalAbonado = Convert.ToDouble(txtPago.Text),
                        UltimoAbono = Convert.ToDouble(txtPago.Text),
                        FechaVenta = DateTime.Now
                    };
                    procesar.InsertarVentaAlxMayor(ventaAlxMayor);
                    int cantidadLista = listaVenta.Count;
                    int Lote;
                    for (int i = 0; i < cantidadLista; i++)
                    {
                        Lote = listaVenta[i];
                        inventarioAlxMayor = procesar.obtenerLote(Lote);
                        descripcionVentaAlxMayor = new DescripcionVentaAlxMayor
                        {
                            IdVentaMayor = Convert.ToInt32(lblNumFact.Text),
                            IdProducto = inventarioAlxMayor.IdLote1,
                            Total = inventarioAlxMayor.TotalImpuestos1
                        };
                        procesar.InsertarDescripcionVentaAlxMayor(descripcionVentaAlxMayor);
                    }
                    MessageBox.Show("Venta Registrada");
                    cargarEnLimpio();
                    try
                    {
                        FacturaAlxMayor form = new FacturaAlxMayor();
                        ReportDocument oRep = new ReportDocument();
                        oRep.Load(Application.StartupPath + "/Reportes/FacturalAlxMayor.rpt");
                        form.crystalReportViewer1.ReportSource = oRep;
                        form.Show();
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show("No se puede mostrar la factura en este momento");
                    }
                }
            catch (Exception ee)
            {
                MessageBox.Show("No se pudo registrar la venta");
            }
            }
            else
            {
                MessageBox.Show("No se digitó el pago");
            }
        }

        private bool estadoVenta()
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

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void CambiaCliente(object sender, EventArgs e)
        {
            if (cbCliente.SelectedIndex != 0)
            {
                cbLote.Enabled = true;
            }
            else
            {
                cbLote.Enabled = false;
            }
        }

        private void buscarUltimaVenta()
        {
            ventaAlxMayor2 = procesar.buscarUltimaVenta();
            if (ventaAlxMayor2 != null)
            {
                numFact = Convert.ToInt32(ventaAlxMayor2.IdVentaMayor) + 1;
            }
            else
            {
                numFact = 1;
            }

            lblNumFact.Text = numFact.ToString();
        }

        private void dgvVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cambiaEmpleado(object sender, EventArgs e)
        {
            if (cbEmpleado.SelectedIndex != 0)
            {
                cbCliente.Enabled = true;
            }
            else
            {
                cbCliente.Enabled = false;
            }
        }

        private void txtPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.SoloNumeros(e);
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
