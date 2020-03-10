using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Asset_Control.Properties;

namespace Asset_Control
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool usp = (bool)Properties.Settings.Default["usep"];
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (usp == true)
            {
                Application.Run(new Password());
            }
            else
            {
                Application.Run(new home());
           }
           
        }
    }
}
