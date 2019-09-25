using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giaodienthungan
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
            Application.Run(new MENU());
            Application.Run(new CHONBAN());
            Application.Run(new CHONMON());
            Application.Run(new Cafe());
            Application.Run(new Tea());
            Application.Run(new IceBlended());
            Application.Run(new Cookie());


        }
    }
}
