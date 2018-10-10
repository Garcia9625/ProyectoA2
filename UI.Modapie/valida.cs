using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal1._0
{
    class valida
    {
        
            public static void SoloLetras(KeyPressEventArgs v)
            {
                if (Char.IsLetter(v.KeyChar))
                {
                    v.Handled = false;
                }
                else if (Char.IsSeparator(v.KeyChar))
                {
                    v.Handled = false;
                }
                else if (Char.IsControl(v.KeyChar))
                {
                    v.Handled = false;
                }
                else
                {
                    v.Handled = true;
                    MessageBox.Show("Solo Letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            public static void SoloNumeros(KeyPressEventArgs v)
            {
                if (Char.IsDigit(v.KeyChar))
                {
                    v.Handled = false;
                }
                else if (Char.IsSeparator(v.KeyChar))
                {
                    v.Handled = false;
                }
                else if (Char.IsControl(v.KeyChar))
                {
                    v.Handled = false;
                }
                else
                {
                    v.Handled = true;
                    MessageBox.Show("Solo Numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            public static void NumerosDecimales(KeyPressEventArgs v)
            {
                if (Char.IsDigit(v.KeyChar))
                {
                    v.Handled = false;
                }
                else if (Char.IsSeparator(v.KeyChar))
                {
                    v.Handled = false;
                }
                else if (Char.IsControl(v.KeyChar))
                {
                    v.Handled = false;
                }
                else if (v.KeyChar.ToString().Equals("."))
                {
                    v.Handled = false;
                }
                else
                {
                    v.Handled = true;
                    MessageBox.Show("Solo numeros o punto decimal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            public static int Longitud(TextBox t)
            {
                int ok = 0;
                string vl = t.Text;
                if (vl.Length < 8)
                {
                    ok = 1;
                    MessageBox.Show("Tu contraseña es muy corta, debe contener al menos 8 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    if (vl.Length > 16)
                {
                    ok = 2;
                    MessageBox.Show("Tu contraseña es muy larga, debe contener maximo 16 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    ok = 3;

                return ok;
            }
    }
}
