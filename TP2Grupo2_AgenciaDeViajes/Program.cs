using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP2Grupo2_AgenciaDeViajes;

namespace TP2Grupo2_AgenciaDeViajes
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string[] argumentos = new string[1];
            Application.Run(new LogIn(argumentos));
        }
    }
}
