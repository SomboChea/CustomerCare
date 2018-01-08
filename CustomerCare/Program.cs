using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMLOGX.Core;
using CustomerCare.GUI.Components;

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
            Alert d = new Alert();
            d.Title = "Error @495";
            d.Message = "This is a big error on machine code!";
            //Application.Run(d);

            if (d.ShowDialog() == DialogResult.OK)
            {
                Console.Write("True");
            }
            else
            {
                Console.Write("False");
            }
            //Database.DBName = "test";
            //Database.Open();

            //Console.Read();
        }
    }
}