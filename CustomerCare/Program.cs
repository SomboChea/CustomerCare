using System;
using System.Collections.Generic;
using System.Data;
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
            //bool x = Database.Update("users", "name='mean',age=19,gender='female'", "id=5");
            //bool x = Database.Delete("users", "id=3");
            //object x = Database.QueryScalar("SELECT * FROM users");
            //DataTable dt = Database.QueryModel("SELECT * FROM users");
            //foreach (DataRow row in dt.Rows)
            //    Console.WriteLine(row["name"] + "");
            //object userID = 0;
            //Database.User.Username = "me";
            //Database.User.Password = "me";
            //Database.User.RoleId = 9;
            //bool x = Database.User.Login(ref userID);
            bool x = Database.User.Register("username,password,age");
            Console.WriteLine(x);

            Console.Read();
        }
    }
}