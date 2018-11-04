﻿using System;
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
    public partial class GestionProductosAlDetalle : Form
    {
        public GestionProductosAlDetalle()
        {
            InitializeComponent();
        }
       DataSet resultados = new DataSet();
        DataView mifiltro;
        public void leer_datos(string query, ref DataSet dstprincipal, string tabla)
        {
            try
            {
                string cadena = "Data Source=.;Initial Catalog=DBMODAPIE;Integrated Security=True";
                SqlConnection cn = new SqlConnection(cadena);
                SqlCommand cmd = new SqlCommand(query, cn);
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dstprincipal, tabla);
                da.Dispose();
                cn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string salida_datos = "";
            string[] palabras_busqueda = this.textBox1.Text.Split(' ');

            foreach (string palabra in palabras_busqueda)
            {
                if (salida_datos.Length == 0)
                {
                    salida_datos = "(Codigo LIKE '%" + palabra + "%' OR Color LIKE '%" + palabra + "%' OR Descripcion LIKE '%" + palabra + "%')";
                }
                else
                {
                    salida_datos += "AND (Codigo LIKE '%" + palabra + "%' OR Color LIKE '%" + palabra + "%' OR Descripcion LIKE '%" + palabra + "%')";
                }
            }

            this.mifiltro.RowFilter = salida_datos;
        }
        
    } 
}
