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

            string cols = "ret_id, ret_name, owner, pc_id, sk_id, ks_id, st, tel1,tel2, tel3, side, staff_id";

            foreach (string temp in Converter.InsertToSQL("tbl_mstretail", cols, "mst"))
            {
                File.AppendAllText("sql.txt", temp);
            }

            Console.Read();
        }
    }
}