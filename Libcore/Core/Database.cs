using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMLOGX.Core
{
    public static class Database
    {
        /** Open Database Connection **/
        public static SqlConnection GetConnection { get { return _setCon; } }
        private static SqlConnection _setCon = null;
        private static SqlCommand cmd = new SqlCommand();
        private static SqlDataReader reader = null;

        public static bool hasOpen { get { return _hasOpen; } }
        private static bool _hasOpen = false;
        private static int _hasExec { get; set; } = 0;

        public static string Server { get; set; } = "localhost";
        public static string DBName { get; set; } = "CustomerCare";
        public static string Username { get; set; } = "sa";
        public static string Password { get; set; } = "sa";

        public static void Open(bool useAuthentication = false)
        {
            string conString = useAuthentication ? "Server = " + Server + ";Database = " + DBName + ";User Id = " + Username + ";Password = " + Password : "Server = " + Server + ";Database = " + DBName + ";Trusted_Connection=True";
            try
            {
                _setCon = new SqlConnection(conString);
                _setCon.Open();
                cmd.Connection = _setCon;

                _hasOpen = true;
            }
            catch (Exception ex)
            {
                Log.Write(ex.Message, "Connection.Open");
                _hasOpen = false;
            }
        }

        public static void Close()
        {
            if (_setCon.Equals(null))
                _setCon.Close();
            return;
        }

        private static void ExitReader()
        {
            try
            {
                cmd.Dispose();
                reader.Close();
            }
            catch (Exception ex)
            {
                Log.Write(ex.Message, "Database.ExitReader");
            }
        }

        private static bool hasExec()
        {
            return _hasExec > 0;
        }

        public static bool CreateDB(string dbname)
        {
            if (_hasOpen)
            {
                try
                {
                    cmd.CommandText = "CREATE DATABASE " + dbname;
                    _hasExec = cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    return hasExec();
                }
                catch (Exception ex)
                {
                    Log.Write(ex.Message, "Database.CreateDB");
                }
            }

            return false;
        }

        public static bool CreateTable(string sql)
        {
            if (_hasOpen)
            {
                try
                {
                    cmd.CommandText = sql;
                    _hasExec = cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    return hasExec();
                }
                catch (Exception ex)
                {
                    Log.Write(ex.Message, "Database.CreateTable");
                }
            }

            return false;
        }

        public static bool Delete(string table, string where = "")
        {
            if (_hasOpen)
            {
                try
                {
                    where = !where.Equals("") || !where.Equals(null) ? "WHERE " + where : where;
                    cmd.CommandText = "DELETE FROM " + table + where;
                }
                catch (Exception ex)
                {
                    Log.Write(ex.Message, "Database.Delete");
                }
            }
            return false;
        }

        public static bool Insert(string table, string columns, params object[] data)
        {
            if (_hasOpen)
            {
                try
                {
                    int count = data.Length > 1 ? data.Length : MString.explode(data[0] + "", ',').Length;
                    if (count != MString.explode(columns, ',').Length)
                        return false;

                    string final_data = data.Length > 1 ? MString.implode(",", "'", data) : MString.implode(",", "'", MString.explode(data[0] + "", ','));

                    cmd.CommandText = "INSERT INTO " + table + "(" + columns + ") VALUES(" + final_data + ");";
                    _hasExec = cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    return hasExec();
                }
                catch (Exception ex)
                {
                    Log.Write(ex.Message, "Database.Insert");
                }
            }

            return false;
        }

        public static bool Update(string table, string data, string where = "")
        {
            if (_hasOpen)
            {
                try
                {
                    where = !where.Equals("") || !where.Equals(null) ? "WHERE " + where : where;
                    cmd.CommandText = "UPDATE " + table + " SET " + data + where;
                    _hasExec = cmd.ExecuteNonQuery();
                    return hasExec();
                }
                catch (Exception ex)
                {
                    Log.Write(ex.Message, "Database.Update");
                }
            }
            return false;
        }

        /** Other Toolset **/

        public static string getColumns(string table, bool includePrimaryCol = false)

        {
            if (_hasOpen)
            {
                try
                {
                    string cols = "";
                    string sql = "SELECT [COLUMN_NAME] FROM [" + DBName + "].[INFORMATION_SCHEMA].[COLUMNS] WHERE [TABLE_NAME] = '" + table + "';";
                    cmd.CommandText = sql;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (!includePrimaryCol)
                        {
                            includePrimaryCol = true;
                            continue;
                        }
                        cols += reader.GetValue(0) + ",";
                    }
                    ExitReader();
                    return MString.TrimEnd(cols, ',');
                }
                catch (Exception ex)
                {
                    Log.Write(ex.Message, "Database.getColumns");
                }
            }

            return null;
        }

        public static object getMatched()
        {
            return null;
        }

        /** Models **/

        public static DataTable QueryModel(string sql)
        {
            throw new NotImplementedException();
        }

        public static object QueryScalar(string sql)
        {
            throw new NotImplementedException();
        }
    }
}