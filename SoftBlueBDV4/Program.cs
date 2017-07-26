using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SoftBlueBD
{

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        public static Form1 MainRef;
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainRef = new Form1();
            Application.Run(MainRef);
        }
    }
}
