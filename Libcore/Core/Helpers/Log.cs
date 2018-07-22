using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SMLOGX.Core
{

    /// <summary>
    /// Log files
    /// </summary>
    public static class Log
    {
        private static string path = "logs.txt";
        private static string stateLine = "[ " + DateTime.Now.ToShortDateString() + " | " + DateTime.Now.ToShortTimeString() + " ] => [FROM " + Environment.UserDomainName + "." + Environment.UserName + "] @ ";

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static string GetCurrentMethod()
        {
            StackTrace st = new StackTrace();
            StackFrame sf = st.GetFrame(1);

            return sf.GetMethod().Name;
        }

        public static string GetMethod()
        {
            return GetCurrentMethod();
        }

        public static void Write(string text, string logFrom = "Unknow")
        {
            stateLine += logFrom + " <<< ";
            if (!File.Exists(path))
            {
                File.WriteAllText(path, stateLine + text + " >>> ", Encoding.UTF8);
            }
            else
            {
                File.AppendAllText(path, Environment.NewLine + stateLine + text + " >>> ", Encoding.UTF8);
            }
        }

        public static string Read()
        {
            if (File.Exists(path))
            {
                return File.ReadAllText(path, Encoding.UTF8);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Can't read log file!");
                return null;
            }
        }
    }

}
