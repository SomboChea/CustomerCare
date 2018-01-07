using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMLOGX.Core;

namespace CustomerCare
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmLogin());

            Database.DBName = "test";
            Database.Open();
            bool x = Database.Update("users", "name='mean',age=19,gender='female'", "id=5");
            Console.Write(x);

            Console.Read();
        }
    }
}