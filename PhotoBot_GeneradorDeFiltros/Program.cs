using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoBot_GeneradorDeFiltros
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
            //Application.Run(new Form1());

            Form1 main = new Form1();
            main.FormClosed += Form1_Closed; // agrega esto aquí
            main.Show();
            Application.Run();
        }

        private static void Form1_Closed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= Form1_Closed;

            if (Application.OpenForms.Count == 0)
            {
                Application.ExitThread();
            }
            else
            {
                Application.OpenForms[0].FormClosed += Form1_Closed;
            }
        }
    }
}
