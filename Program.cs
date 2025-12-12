using System;
using System.Windows.Forms;
using EquipoComputoApp.Forms;

namespace EquipoComputoApp
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Formulario principal con menú para navegar
            Application.Run(new frmPrincipal());
        }
    }
}
