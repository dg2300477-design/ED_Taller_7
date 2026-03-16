using System;
using System.Windows.Forms;

namespace ED_Taller_7
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Inicia la aplicación cargando tu formulario
            Application.Run(new Form1());
        }
    }
}