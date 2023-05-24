using DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleanWorks_Scheduler
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DB.SetConfiguration("IPS23_mmarkovin21", "mmarkovin21", ":UJ}3rEv");
            Application.Run(new FrmLogin());
        }
    }
}
/*
 * mmarkovin21
Password: :UJ}3rEv
Database: IPS23_mmarkovin21
*/