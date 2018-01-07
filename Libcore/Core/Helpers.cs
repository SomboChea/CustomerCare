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
    public class Helper
    {
    }

    public static class MString
    {
        public static object[] explode(string value, params char[] exp)
        {
            return value.Split(exp);
        }

        public static string implode(string imp, params object[] values)
        {
            return String.Join(imp, values);
        }

        public static string implode(string imp, string strCase, params object[] values)
        {
            return strCase + String.Join("'" + imp + "'", values) + strCase;
        }

        public static string TrimStart(string value)
        {
            return value.Trim();
        }

        public static string Trim(string value, params char[] trimmer)
        {
            return value.Trim(trimmer);
        }

        public static string TrimStart(string value, params char[] trimmer)
        {
            return value.TrimStart(trimmer);
        }

        public static string TrimEnd(string value, params char[] trimmer)
        {
            return value.TrimEnd(trimmer);
        }
    }

    /// <summary>
    /// Log files
    /// </summary>
    public static class Log
    {
        private static string path = "logs.txt";
        private static string stateLine = "[ " + DateTime.Now.ToShortDateString() + " | " + DateTime.Now.ToShortTimeString() + " ] @ ";

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static string GetCurrentMethod()
        {
            StackTrace st = new StackTrace();
            StackFrame sf = st.GetFrame(1);

            return sf.GetMethod().Name;
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

    /** Unused **/

    public class Converter
    {
        public static List<string> InsertToSQL(string table, string columns, string filename, char splitter = ',')
        {
            List<string> data = new List<string>();
            filename += ".csv";
            string[] lines = File.ReadAllLines(filename, Encoding.UTF8);
            string sql = "";
            string[] dsp;

            foreach (string temp in lines)
            {
                dsp = temp.Split(splitter);
                for (int i = 0; i < dsp.Length; i++)
                {
                    if (dsp[i].Equals("") || dsp[i].Equals(null))
                        dsp[i] = "null";
                }

                sql = "INSERT INTO " + table + "(" + columns + ") VALUES(" + String.Join(",", dsp) + ");";
                data.Add(sql);
            }

            return data;
        }
    }
}