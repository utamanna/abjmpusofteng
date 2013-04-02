using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TICSET
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

            // Load the forms. LoginWindow should be first
            // because that is the entry point for the game.
            Application.Run(new LoginWindow());
            //Application.Run(new RegisterWindow());
            //Application.Run(new Form1());
        }
    }
}
