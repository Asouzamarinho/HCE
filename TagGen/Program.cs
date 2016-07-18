using System;
using System.Windows.Forms;

namespace TagGen
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Cruzeiro.WebService.Console.Program.StartCoreServer(new string[0]);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
