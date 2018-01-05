using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMLOGX.Core
{
    public class Helper
    {
    }

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