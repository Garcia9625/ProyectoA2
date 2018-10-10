﻿using BS.Modapie;
using DO.Modapie;
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
    public partial class VentaDetalle : Form
    {
        string Username;
        string IdEmpleado;
        double precio;
        public VentaDetalle(string username)
        {
            Usuario usuario = Mantenimiento.Instancia.obtenerUsuarioUser(username);
            this.IdEmpleado = usuario.idEmpleado;
            this.Username = usuario.username;
            InitializeComponent();
        }

        private List<VentaXDetalle> lst = new List<VentaXDetalle>();

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
            dataGridView1.ClearSelection();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            VentaXDetalle V = new VentaXDetalle();
            
            double SubTotal;

            //V.IdProducto = Convert.ToInt32(txtCodigo.Text);    Hay un problema con la llave primaria para poder registrar este campo
            //V.IdVenta = Convert.ToInt32(txtIdVenta.Text);  Hay que decidir como se va a guardar
            V.Cantidad = Convert.ToInt32(txtCantidad.Text);
            V.IdProducto = Convert.ToInt32(txtCodigo.Text);
            V.PrecioUnitario = precio;
            SubTotal = V.PrecioUnitario * V.Cantidad;
            V.Total = SubTotal;
            lst.Add(V);
            llenarGrid();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.SoloNumeros(e);
        }
    }
}
