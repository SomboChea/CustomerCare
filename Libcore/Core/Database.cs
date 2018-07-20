using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace SMLOGX.Core
{
    public static class Database
    {
        /** Open Database Connection **/
        public static SqlConnection GetConnection { get { return _setCon; } }
        private static SqlConnection _setCon = null;
        private static SqlCommand cmd = new SqlCommand();
        private static SqlDataReader reader = null;
        private static SqlDataAdapter adapter = null;

        public static bool HasOpen { get { return _hasOpen; } }
        private static bool _hasOpen = false;
        private static int _hasExec { get; set; } = 0;

        /** Config Server **/
        public static string Server { get; set; } = "localhost";
        public static string DBName { get; set; } = "Telmarketing";
        public static bool AuthType { get; set; } = false;
        public static string UserId { get; set; }
        public static string Password { get; set; }
        private static string[] Sections = { "Windows Authentication", "SQL Server Authentication" };

        public static string GetName_ID(string name,string type) {
            string name_id = Database.QueryScalar(@"DECLARE @id int=0 exec @id=insertName '" + name + "', "+type+" select @id") + "";
            return name_id;
        }
        /// <summary>
        /// Setting Configuration DB Server
        /// </summary>
        public static bool SetConfigDB(bool isAuth = false, string configPath = "config", string ext = "db")
        {
            try
            {
                MParser config = new MParser(configPath + "." + ext);
                int idx = isAuth ? 1 : 0;
                config.Write("Server", Server, Sections[idx]);
                config.Write("DBName", DBName, Sections[idx]);
                if (isAuth)
                {
                    config.Write("UserId", UserId, Sections[idx]);
                    config.Write("Password", Password, Sections[idx]);
                }
                config.Write("AuthType", isAuth + "", "Authentication");

                return true;
            }
            catch (Exception ex)
            {
                Log.Write(ex.Message, "Database.setConfigDB");
            }

            return false;
        }

      

        /// <summary>
        /// Load Configuration DB Server Public
        /// </summary>
        public static void GetConfigDB(bool auth)
        {
            _GetConfigDB(auth, true);
        }

        /// <summary>
        /// Load Configuration DB Server
        /// </summary>
        private static void _GetConfigDB(bool isAuth = false, bool readOnly = false, string configPath = "config", string ext = "db")
        {
            string path = configPath + "." + ext;
            MParser config;
            if (File.Exists(path))
            {
                config = new MParser(path);
                int idx = isAuth ? 1 : 0;
                Server = config.Read("Server", Sections[idx]);
                DBName = config.Read("DBName", Sections[idx]);
                AuthType = readOnly ? isAuth : Convert.ToBoolean(config.Read("AuthType", "Authentication"));
                if (isAuth)
                {
                    UserId = config.Read("UserId", Sections[idx]);
                    Password = config.Read("Password", Sections[idx]);
                }
            }
            return;
        }

        /// <summary>
        /// Open Database Connection
        /// </summary>
        public static void Open(bool useAuthentication = false)
        {
            _GetConfigDB(useAuthentication);
            string conString = useAuthentication ? "Server = " + Server + ";Database = " + DBName + ";User Id = " + UserId + ";Password = " + Password : "Server = " + Server + ";Database = " + DBName + ";Trusted_Connection=True";
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

        /// <summary>
        /// Test Database Connection
        /// </summary>
        public static bool Test(Config config, bool isAuth = false)
        {
            try
            {
                string conString = isAuth ? "Server = " + config.Server + ";Database = " + config.DBName + ";User Id = " + config.UserId + ";Password = " + config.Password : "Server = " + config.Server + ";Database = " + config.DBName + ";Trusted_Connection=True";
                SqlConnection conn = new SqlConnection(conString);
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                Log.Write(ex.Message, "Database.Test");
                return false;
            }
        }

        /// <summary>
        /// Close Database Connection
        /// </summary>
        public static void Close()
        {
            _hasOpen = false;
            _setCon.Close();
            GetConnection.Close();
        }

        /// <summary>
        /// Exit Reader & Cmd
        /// </summary>
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

        /// <summary>
        /// Has Executed
        /// </summary>
        private static bool HasExec()
        {
            return _hasExec > 0;
        }

        /// <summary>
        /// Create DB
        /// </summary>
        public static bool CreateDB(string dbname)
        {
            if (_hasOpen)
            {
                try
                {
                    cmd.CommandText = "CREATE DATABASE " + dbname;
                    _hasExec = cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    return HasExec();
                }
                catch (Exception ex)
                {
                    Log.Write(ex.Message, "Database.CreateDB");
                }
            }

            return false;
        }

        /// <summary>
        /// Create Table
        /// </summary>
        public static bool CreateTable(string sql)
        {
            if (_hasOpen)
            {
                try
                {
                    cmd.CommandText = sql;
                    _hasExec = cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    return HasExec();
                }
                catch (Exception ex)
                {
                    Log.Write(ex.Message, "Database.CreateTable");
                }
            }

            return false;
        }

        /// <summary>
        /// Delete
        /// </summary>
        public static bool Delete(string table, string where = "", SqlParameter[] parameter = null)
        {
            if (_hasOpen)
            {
                try
                {
                    where = !where.Equals("") || !where.Equals(null) ? " WHERE " + where : where;
                    cmd.CommandText = "DELETE FROM " + table + where;
                    if (parameter != null)
                        cmd.Parameters.AddRange(parameter);

                    _hasExec = cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    return HasExec();
                }
                catch (Exception ex)
                {
                    Log.Write(ex.Message, "Database.Delete");
                }
            }
            return false;
        }

        /// <summary>
        /// Insert
        /// </summary>
        public static bool Insert(string table, string columns, params object[] data)
        {
            if (_hasOpen)
            {
                try
                {
                    int count = data.Length > 1 ? data.Length : MString.explode(data[0] + "", ',').Length;
                    if (count != MString.explode(columns, ',').Length)
                    {
                        return false;
                    }
                    string final_data = data.Length > 1 ? MString.implode(",", "'", data) : MString.implode(",", "'", MString.explode(data[0] + "", ','));

                    cmd.CommandText = "INSERT INTO " + table + "(" + columns + ") VALUES(" + final_data + ");";
                    //System.Windows.Forms.MessageBox.Show(cmd.CommandText);

                    _hasExec = cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    return HasExec();
                }
                catch (Exception ex)
                {
                    Log.Write(ex.Message, "Database.Insert" + " \n" + cmd.CommandText);
                }
            }

            return false;
        }

       
        // My Add
        public static bool Update(string table, string WhereClause, string columns, params object[] data)
        {
            if (_hasOpen)
            {
                try
                {
                    int count = data.Length > 1 ? data.Length : MString.explode(data[0] + "", ',').Length;
                    if (count != MString.explode(columns, ',').Length)
                        return false;

                    //string final_data = data.Length > 1 ? MString.implode(",", "'", data) : MString.implode(",", "'", MString.explode(data[0] + "", ','));
                    object[] values = data.Length > 1 ? data : data[0].ToString().Split(',');
                    string[] column = columns.Split(',');

                    List<String> datas = new List<string>();
                    for (int i = 0; i < column.Length; i++)
                    {
                        string temp = column[i] + "=N'" + values[i] + "'";
                        datas.Add(temp);
                    }

                    //cmd.CommandText = "INSERT INTO " + table + "(" + columns + ") VALUES(" + final_data + ");";
                    cmd.CommandText = "Update " + table + " set " + String.Join(",", datas) + " " + WhereClause;
                    //System.Windows.Forms.MessageBox.Show(cmd.CommandText);
                    //System.Windows.Forms.MessageBox.Show(cmd.CommandText + "\n" + final_data);
                    //return false;
   
                    _hasExec = cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    return HasExec();
                }
                catch (Exception ex)
                {
                    Log.Write(ex.Message, "Database.Update");
                }
            }

            return false;
        }

        /// <summary>
        /// Update
        /// </summary>
        public static bool Update(string table, string data, string where = "", SqlParameter[] parameter = null)
        {
            if (_hasOpen)
            {
                try
                {
                    where = !where.Equals("") || !where.Equals(null) ? " WHERE " + where : where;
                    cmd.CommandText = "UPDATE " + table + " SET " + data + where;
                    if (parameter != null)
                        cmd.Parameters.AddRange(parameter);

                    _hasExec = cmd.ExecuteNonQuery();
                    return HasExec();
                }
                catch (Exception ex)
                {
                    Log.Write(ex.Message, "Database.Update");
                }
            }
            return false;
        }

        /// <summary>
        /// Use For Easy Setting Parameter
        /// replace text "@obj#"
        /// count from 1
        /// </summary>
        /// <param name="datas"></param>
        /// <returns></returns>
        public static SqlParameter[] SetParam(params string[] datas)
        {
            SqlParameter[] pmts = new SqlParameter[datas.Length];
            for(int i = 0; i < pmts.Length - 1; i++)
            {
                pmts[i].ParameterName = "@obj"+i;
                pmts[i].Value = datas[i];
            }
            return pmts;
        }

        /// <summary>
        /// Get Columns
        /// </summary>
        public static string GetColumns(string table, bool includePrimaryCol = false)
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

        /// <summary>
        /// Get Matching
        /// </summary>
        public static object GetMatched()
        {
            return null;
        }

        /// <summary>
        /// QueryModel
        /// </summary>
        public static DataTable QueryModel(string sql)
        {
            if (_hasOpen)
            {
                try
                {
                    DataTable dt = new DataTable();
                    adapter = new SqlDataAdapter(sql, _setCon);
                    adapter.Fill(dt);
                    adapter.Dispose();
                    return dt;
                }
                catch (Exception ex)
                {
                    Log.Write(ex.Message, "Database.QueryModel\n      " + sql);
                }
            }
            return null;
        }

        /// <summary>
        /// QueryModel
        /// </summary>
        public static bool Exec(string sql_exec)
        {
            if (_hasOpen)
            {
                try
                {
                    cmd.CommandText = sql_exec;

                    int b = cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    return Convert.ToBoolean(b);
                }
                catch (Exception ex)
                {
                    Log.Write(ex.Message, "Database.Exec , "+sql_exec);
                }
            }
            return false;
        }

        /// <summary>
        /// QueryScalar
        /// </summary>
        public static object QueryScalar(string sql, SqlParameter[] parameter = null)
        {
            if (_hasOpen)
            {
                try
                {
                    cmd.CommandText = sql;
                    if (parameter != null)
                        cmd.Parameters.AddRange(parameter);

                    object b = cmd.ExecuteScalar();
                    cmd.Dispose();
                    return b;
                }
                catch (Exception ex)
                {
                    Log.Write(ex.Message, "Database.QueryScalar");
                }
            }
            return null;
        }

        /// <summary>
        /// Get DataSet
        /// </summary>
        public static DataSet GetDataSet(string sql)
        {
            try
            {
                DataSet ds = new DataSet();
                adapter = new SqlDataAdapter(sql, _setCon);
                adapter.Fill(ds);
                adapter.Dispose();

                return ds;
            }
            catch (Exception ex)
            {
                Log.Write(ex.Message, "Database.GetDataSet");
            }
            return null;
        }

        /// <summary>
        /// Get Last Insert ID
        /// </summary>
        public static int GetLastId(string table)
        {
            try
            {
                cmd.CommandText = "SELECT IDENT_CURRENT('" + table + "')";
                object rex = cmd.ExecuteScalar();
                cmd.Dispose();
                return Convert.ToInt32(rex);
            }
            catch (Exception ex)
            {
                Log.Write(ex.Message, "Database.GetLastId");
            }

            return 0;
        }

        /// <summary>
        /// Class User for Setting up
        /// </summary>
        public static class User
        {
            public static string Table { get; set; } = "tbl_user";
            public static string Username { get; set; }
            public static string Password { get; set; }
            public static int RoleId { get; set; } = 0;
            public static string Where { get; set; }

            /// <summary>
            /// Login
            /// </summary>
            public static bool Login(ref object userID)
            {
                if (_hasOpen)
                {
                    try
                    {
                        Where = " username = '" + Username + "' AND password = '" + Password + "'";
                        cmd.CommandText = "SELECT * FROM " + Table + " WHERE " + Where;
                        userID = cmd.ExecuteScalar();
                        return Convert.ToBoolean(userID);
                    }
                    catch (Exception ex)
                    {
                        Log.Write(ex.Message, "Database.User.Login");
                    }
                }

                return false;
            }

            /// <summary>
            /// Register
            /// </summary>
            public static bool Register(string cols = null)
            {
                if (_hasOpen)
                {
                    try
                    {
                        return Insert(Table, cols == null ? GetColumns("table") : cols, Username, Password, RoleId);
                    }
                    catch (Exception ex)
                    {
                        Log.Write(ex.Message, "Database.User.Register");
                    }
                }

                return false;
            }
        }
    }
}