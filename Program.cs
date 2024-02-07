using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcsediTamas_Gyumolcs_Beadando
{
    internal static class Program
    {
        public static Form1 kezdolap = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            kezdolap = new Form1();
            Application.Run(kezdolap);
        }
    }
}
