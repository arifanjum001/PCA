using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using System.Windows.Forms;

namespace PCA_00
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Form2());
           // Application.Exit();
          //  Application.Run(new Form3());
            Application.Exit();
            Application.Run(new Form1());
            Application.Exit();
            // to clear the catch RAM , have to close it in a timer . . . . .
        }
    }
}
