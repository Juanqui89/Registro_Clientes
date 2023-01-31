using RegistroClientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrosCliente
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new frmCustomer());

            new SplashScreenUsingVBframework().Run(args);
        }
    }

    class SplashScreenUsingVBframework : Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase
    {
        protected override void OnCreateSplashScreen()
        {
            base.OnCreateSplashScreen();
            this.SplashScreen = new frmSplashScreen();
        }
    }


}
