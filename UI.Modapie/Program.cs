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
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new VentaAlxMayor());
        }
    }
}
