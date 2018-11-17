using BS.Modapie;
using DO.Modapie;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Modapie
{
    public partial class VentaDetalle : Form
    {
        double precio; double total;
        int idEmpledo; int numFact;
        DO.Modapie.VentaAlDetalle venta;
        InventarioAlDetalle inve;
        Mantenimiento procesar = new Mantenimiento();
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dr;

        public VentaDetalle()
        {
            InitializeComponent();

            dataGridView1.ClearSelection();
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
        }
        private void Conexion()
        {
            try
            {
                cnn = new SqlConnection("Data Source=.;Initial Catalog=DBMODAPIE;Integrated Security=True");
                cnn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto: " + ex.ToString());
            }
        }

        private void llenarCombo(ComboBox cb)
        {
            Conexion();
            cmd = new SqlCommand("Select Nombre,Apellido1 from Empleado", cnn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cb.Items.Add(dr["Nombre"].ToString() +" "+ dr["Apellido1"].ToString());
            }
            dr.Close();
        }
        private List<DescripcionVentaXDetalle> lst = new List<DescripcionVentaXDetalle>();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VentaDetalle_Activated(object sender, EventArgs e)
        {
            txtCedula.Text = Program.IdClienteDetalle;
            txtNombre.Text = Program.Nombre + " " + Program.Apellido1 + " " + Program.Apellido2;
            rtxDescripcion.Text = Program.Descripcion;
            txtCodigo.Text = Program.Codigo;
            txtColor.Text = Program.Color;
            txtTalla.Text = Convert.ToString(Program.Talla);
            precio = Program.Precio;
            txtPrecio.Text = "¢"+Convert.ToString(Program.Precio);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Productos p = new Productos();
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClientesXDetalle cd = new ClientesXDetalle();
            cd.Show();
        }

        public void llenarGrid()
        {
            Decimal SumaTotal = 0; 
            dataGridView1.Rows.Clear();
            for (int i = 0; i < lst.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = lst[i].Cantidad;
                dataGridView1.Rows[i].Cells[1].Value = lst[i].IdProducto;
                dataGridView1.Rows[i].Cells[2].Value = lst[i].PrecioUnitario;
                dataGridView1.Rows[i].Cells[3].Value = lst[i].Total;

                SumaTotal += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);
            }

            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            
            dataGridView1.Rows[lst.Count + 2].Cells[2].Value = "     TOTAL   ¢";
            dataGridView1.Rows[lst.Count + 2].Cells[3].Value = SumaTotal;
            total = Convert.ToDouble(SumaTotal);
            dataGridView1.ClearSelection();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCedula.Text))
            {
                if (!string.IsNullOrEmpty(txtCodigo.Text))
                {
                    if (!string.IsNullOrEmpty(txtCantidad.Text))
                    {
                        if (Convert.ToInt32(txtCantidad.Text) > Program.Cantidad)
                        {
                            
                            DialogResult d = MessageBox.Show("La cantidad de productos seleccionada es mayor a la existente en las bodegas", "No se puede agregar el producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            btnRegistro.Enabled = true;
                            DescripcionVentaXDetalle V = new DescripcionVentaXDetalle();

                            double SubTotal;

                            //V.IdProducto = Convert.ToInt32(txtCodigo.Text);    Hay un problema con la llave primaria para poder registrar este campo
                            //V.IdVenta = Convert.ToInt32(txtIdVenta.Text);  Hay que decidir como se va a guardar
                            V.Cantidad = Convert.ToInt32(txtCantidad.Text);
                            V.IdProducto = Program.IdProducto;
                            V.PrecioUnitario = precio;
                            SubTotal = V.PrecioUnitario * V.Cantidad;
                            V.Total = SubTotal;
                            lst.Add(V);
                            llenarGrid();
                            limpiarProducto();
                        }
                        
                    }
                    else { DialogResult d = MessageBox.Show("No hay una cantidad de productos registrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { DialogResult d = MessageBox.Show("No hay ningún producto ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else { MessageBox.Show("No se ha ingresado ningún cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.SoloNumeros(e);
        }

        private void VentaDetalle_Load(object sender, EventArgs e)
        {
            
            venta = procesar.buscarUltimaVentaDetalle();
            if (venta != null)
            {
                numFact = Convert.ToInt32(venta.IdVentaDetalle) + 1;
            }
            else
            {
                numFact = 1;
            }
            
            lblNumFact.Text = numFact.ToString();
            llenarCombo(cmbEmpleados);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowHeadersVisible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
            MenuAdmin ma = new MenuAdmin();
            this.Dispose();
            ma.Show();
        }

        private void GuardarDetalleVenta( Int32 objIdVenta, Int32 objIdProducto, Int32 objCantidad, Double objPUnitario, Double objTotal)
        {
            DescripcionVentaXDetalle descripcionVentaDetalle;
            descripcionVentaDetalle = new DescripcionVentaXDetalle
            {
                IdVentaDetalle = objIdVenta,
                IdProducto = objIdProducto,
                Cantidad = objCantidad,
                PrecioUnitario = objPUnitario,
                Total = objTotal
            };
            procesar.InsertarDescripcionVentaAlDetalle(descripcionVentaDetalle);
            limpiar();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            
            try
            {
                DO.Modapie.VentaAlDetalle ventaDetalle;
                ventaDetalle = new DO.Modapie.VentaAlDetalle
                {
                    IdClienteDetalle = txtCedula.Text,
                    IdEmpleado = idEmpledo.ToString(),
                    Total = total
                };
                procesar.InsertarVentaDetalle(ventaDetalle);
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    int idVentaD = Convert.ToInt32(lblNumFact.Text);
                    Double Tot = 0;
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) != "")
                    {
                        Tot += Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                        GuardarDetalleVenta(
                        idVentaD,
                        Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value),
                        Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value),
                        Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value),
                        Tot
                        );                       
                    }
                    else {
                        break;
                    }
                }
                MessageBox.Show("Compra realizada satisfactoriamente","Compra exitosa",MessageBoxButtons.OK,MessageBoxIcon.Information);
                limpiar();
            }
            catch (Exception ee)
            {
                throw;
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Selected == true)
                {
                    if (Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value) != "")
                    {
                        dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                        lst.RemoveAt(dataGridView1.CurrentRow.Index);
                        llenarGrid();
                        MessageBox.Show("Producto Eliminado del carrito de compras", "Ventas Modapie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No Existe Ningun Elemento en el carrito", "Ventas Modapie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dataGridView1.ClearSelection();
                    }
                }
                else
                {
                    MessageBox.Show("Por Favor Seleccione Item a Eliminar del carrito de compras", "Ventas Modapie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("No Existe Ningun Elemento en el carrito", "Ventas Modapie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        public void limpiar() {
            dataGridView1.Rows.Clear();
            lst.Clear();
            btnRegistro.Enabled = false;
            Program.IdClienteDetalle = "";
            Program.Nombre = "";
            Program.Apellido1 = "";
            Program.Apellido2 = "";
            Program.Codigo = "";
            Program.Color = "";
            Program.Descripcion = "";
            Program.IdProducto = 0;
            Program.Talla = 0;
            Program.Precio = 0;
            txtNombre.Text = "";
            txtCedula.Text = "";
            txtCodigo.Text = "";
            txtPrecio.Text = "¢ ";
            txtCantidad.Text = "";
            txtTalla.Text = "";
            txtColor.Text = "";
            rtxDescripcion.Text = "";
            cmbEmpleados.SelectedIndex = -1;
        }

        public void limpiarProducto()
        {
            rtxDescripcion.Text = "";
            txtCodigo.Text = "";
            txtPrecio.Text = "¢ ";
            txtCantidad.Text = "";
            txtTalla.Text = "";
            txtColor.Text = "";
        }

        private void cmbEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombre = cmbEmpleados.Text;
            string[] nombreEmp = nombre.Split();
            
            Conexion();
            cmd = new SqlCommand("Select Dni from Empleado Where Nombre = '" + nombreEmp[0] + "'", cnn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                idEmpledo = Convert.ToInt32(dr["Dni"].ToString());
            }
            dr.Close();
        }
    }

}
