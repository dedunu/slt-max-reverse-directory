using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SLTMAX
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
            Spalsh Splash = new Spalsh();
            Splash.ShowDialog();
            CSDA CSDApp = new CSDA();
            CSDApp.ShowDialog();
        }

    }
}