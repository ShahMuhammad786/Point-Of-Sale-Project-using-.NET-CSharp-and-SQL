using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
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
            //Application.Run(new Index());
            //Application.Run(new StockManagement());
            //Application.Run(new Log());
            //Application.Run(new BuyScanner());
            //Application.Run(new BuyManual());
            Application.Run(new login());
            
        }
    }
}
