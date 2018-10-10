using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Modapie
{
    static class Program
    {
        /// <summary>C:\Users\ricar\source\repos\NewRepo\ProyectoA2\UI.Modapie\Program.cs
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 


        //Datos del Producto
        public static int IdProducto;
        public static String Codigo;
        public static String Color;
        public static Double Talla;
        public static String Descripcion;
        public static Double Precio;

        //Datos del Cliente
        public static String IdClienteDetalle;
        public static String Nombre;
        public static String Apellido1;
        public static String Apellido2;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
