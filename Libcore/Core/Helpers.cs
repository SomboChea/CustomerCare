using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace SMLOGX.Core
{
    /// <summary>
    /// Helpers
    /// </summary>
    public class Helpers : IHelper
    {
        public static string Path_Prefix { get; set; } = ".\\Image\\";

        public static void Clear(Control main)
        {
            foreach (Control ctrl in main.Controls)
                if (ctrl is ComboBox)
                {
                    try
                    {
                        ((ComboBox)ctrl).SelectedIndex = 0;
                    }
                    catch (Exception)
                    { }
                }
                else if (ctrl is GroupBox || ctrl is Panel || ctrl is UserControl)
                    Clear(ctrl);
                else if (ctrl is TextBox)
                    ctrl.Text = "";
        }

        /// <summary>
        /// This is A function Use to Upload Photo into Specific Directory
        /// </summary>
        /// <param name="filepath">Original full file path</param>
        /// <param name="Directory_Path">Directory to Copy file into</param>
        /// <returns>Return a name and extension of Image in Directory_path</returns>
        public static string Upload_Photo(string filepath, string Directory_Path)
        {
            //try
            //{
            string[] filesplit = filepath.Split('\\');
            string filename = filesplit[filesplit.Length - 1];
            string imgpath = Directory_Path + filename;

            if (!Directory.Exists(Directory_Path))
            {
                Directory.CreateDirectory(Directory_Path);
            }

            if (File.Exists(imgpath))
            {
                DialogResult diag = MessageBox.Show("File : \n" + imgpath + Environment.NewLine + " is Already Exist ! \nDo you want to Replace file" + Environment.NewLine + "\n\nYes : Replace File" + Environment.NewLine + "No : Auto Rename file" + Environment.NewLine + "Cancel : Abort", "File Exist", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                for (int i = 1; File.Exists(imgpath); i++)
                {
                    if (diag == DialogResult.Yes)
                    {
                        File.Delete(imgpath);
                        break;
                    }
                    else if (diag == DialogResult.No)
                    {
                        imgpath = Directory_Path + filename.Split('.')[0] + "-" + i + "." + filename.Split('.')[filename.Split('.').Length - 1];
                    }
                    else
                    {
                        return "";
                    }
                }
            }
            MessageBox.Show(filepath);
            File.Copy(filepath, imgpath);

            return filename;
            //}
            //catch (Exception ex)
            //{
            //    Log.Write(ex.Message, "Helpers.Upload_Photo");
            //}
            //return null;
        }

        /// <summary>
        /// ImageToBase64
        /// </summary>
        public static string ImageToBase64(Image image)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            image.Save(ms, image.RawFormat);
            byte[] imageBytes = ms.ToArray();

            return Convert.ToBase64String(imageBytes); ;
        }

        /// <summary>
        /// Base64ToImage
        /// </summary>
        public static Image Base64ToImage(string base64)
        {
            byte[] imageByte = Convert.FromBase64String(base64);
            System.IO.MemoryStream ms = new System.IO.MemoryStream(imageByte);

            return Image.FromStream(ms);
        }

        /// <summary>
        /// Use for Fill item in Combobox from Database
        /// </summary>
        /// <param name="cb">Combobox Control</param>
        /// <param name="displaymember">(ColumnName) items you want to show in combobox</param>
        /// <param name="valuemember">(ColumnName) what you get when selecteditem</param>
        /// <param name="sql">SQL Select Command</param>
        public static void FillComboBox(ComboBox cb, string displaymember, string valuemember, string sql)
        {
            try
            {
                cb.ValueMember = valuemember;
                cb.DisplayMember = displaymember;
                cb.DataSource = Database.QueryModel(sql);
            }
            catch (Exception ex)
            {
                Log.Write(ex.Message, "Helpers.FillComboBox");
            }
        }

        /// <summary>
        /// Binding DataGridView
        /// </summary>
        public static void BindGridView(string sql, BindingSource bindinSource, DataGridView gridView)
        {
            try
            {
                gridView.Columns.Clear();
                bindinSource.DataSource = Database.QueryModel(sql);
                // Resize the DataGridView columns to fit the newly loaded content.
                gridView.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch (Exception ex)
            {
                Log.Write(ex.Message, "Helpers.BindGridView");
            }
            return;
        }

        /// <summary>
        /// AutoFit Columns
        /// </summary>
        public static void AutoFitColumns(DataGridView dg)
        {
            dg.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        /// <summary>
        /// Checking NULL Object
        /// </summary>
        public static bool Ifnull(object value, bool whitSpace = false)
        {
            return whitSpace ? value.Equals(" ") || value.Equals(null) || value.Equals("") : value.Equals(null) || value.Equals("");
        }

        /// <summary>
        /// Start of Week in DateTime
        /// </summary>
        public static DateTime StartOfWeek(DateTime dt, DayOfWeek startOfWeek)
        {
            int diff = dt.DayOfWeek - startOfWeek;
            if (diff < 0)
                diff += 7;
            return dt.AddDays(-1 * diff).Date;
        }

        /// <summary>
        /// Binding Source
        /// </summary>
        public static BindingSource Binding(object val)
        {
            return new BindingSource
            {
                DataSource = val
            };
        }

        public static void FillDatagridviewColumn(DataGridView dg, string sql)
        {
            DataTable dt = Database.QueryModel(sql);
            foreach (DataColumn col in dt.Columns)
            {
                DataGridViewColumn dgcol = new DataGridViewColumn(new DataGridViewTextBoxCell());
                dgcol.Name = col.Caption;
                dgcol.HeaderText = col.Caption;
                dg.Columns.Add(dgcol);
            }
        }

        public void Show()
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// M String
    /// </summary>
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
            //Console.WriteLine(values[0]);
            return "N"+strCase + String.Join("'" + imp + "N'", values) + strCase;

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
    /// Setting the files [Config Parser]
    /// </summary>
    public class MParser
    {
        private string Path;
        private string EXE = Assembly.GetExecutingAssembly().GetName().Name;

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        private static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        private static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        public MParser(string IniPath = null)
        {
            Path = new FileInfo(IniPath ?? EXE + ".ini").FullName.ToString();
        }

        public string Read(string Key, string Section = null)
        {
            var RetVal = new StringBuilder(255);
            GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 255, Path);
            return RetVal.ToString();
        }

        public void Write(string Key, string Value, string Section = null)
        {
            WritePrivateProfileString(Section ?? EXE, Key, Value, Path);
        }

        public void DeleteKey(string Key, string Section = null)
        {
            Write(Key, null, Section ?? EXE);
        }

        public void DeleteSection(string Section = null)
        {
            Write(null, null, Section ?? EXE);
        }

        public bool KeyExists(string Key, string Section = null)
        {
            return Read(Key, Section).Length > 0;
        }
    }

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

    /// <summary>
    /// App Forecing Form
    /// </summary>
    public static class App
    {
        public static void Overlay(Form top, Form down)
        {
            Open(down);
            OpenDialog(top);
            top.Close();
            down.Close();
        }

        public static void Open(Form context)
        {
            context.Show();
            return;
        }

        public static DialogResult OpenDialog(Form context)
        {
            return context.ShowDialog();
        }

        public static void ExitThread(Form context)
        {
            new ApplicationContext(context).ExitThread();
            return;
        }

        public static void Minimized(Form context)
        {
            context.WindowState = FormWindowState.Minimized;
            return;
        }

        public static void Maximized(Form context)
        {
            context.WindowState = FormWindowState.Maximized;
            return;
        }

        public static void Hide(Form context)
        {
            context.Hide();
            return;
        }

        public static void ExitAll()
        {
            Application.Exit();
            Application.ExitThread();
            return;
        }
    }

    /// <summary>
    /// Fullmode { Screen }
    /// </summary>
    public static class FullMode
    {
        public static void Fullscreen(Form context)
        {
            context.Width = Screen.PrimaryScreen.Bounds.Width;
            context.Height = Screen.PrimaryScreen.Bounds.Height;
        }

        public static void Fullscreen(Form context, bool workingAreaEnable = false)
        {
            if (workingAreaEnable)
            {
                context.Width = Screen.PrimaryScreen.WorkingArea.Width;
                context.Height = Screen.PrimaryScreen.WorkingArea.Height;
            }
            else
            {
                Fullscreen(context);
            }
        }

        public static void PopUp(Form context)
        {
            context.FormBorderStyle = FormBorderStyle.None;
            context.ShowIcon = false;
            context.ShowInTaskbar = false;
            context.MinimizeBox = false;
            context.MaximizeBox = false;
            context.WindowState = FormWindowState.Normal;
            context.StartPosition = FormStartPosition.CenterScreen;
            context.TopMost = true;
            context.TopLevel = true;
            context.Visible = true;
        }
    }

    /// <summary>
    /// Text Checking
    /// </summary>
    public static class Text
    {
        public static bool IsDigitObj(object value)
        {
            try
            {
                var x = int.Parse(value.ToString());
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static void IsDigit(KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        public static void IsDecimal(KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != (char)8 && !e.KeyChar.Equals('.');
        }

        public static string isRequired(TextBox tb, bool isMsg = false, string msg = "Required Field!")
        {
            if (tb.Text.Trim() == "")
            {
                tb.Focus();
                if (isMsg) MessageBox.Show(msg);
                return null;
            }
            else
                return tb.Text;
        }

        public static void isNullMsg(string val)
        {
            if (val == null)
                MessageBox.Show("Required Field!");
            return;
        }

        public static bool isNull(string val)
        {
            return val.Trim().Equals("") || val.Trim().Equals(null);
        }
    }

    /// <summary>
    /// Converter
    /// </summary>
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
        public class Excel
        {
            public static OleDbConnection Conn;
            public static void open(string path)
            {
                string ConnectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + path + "';Extended Properties='Excel 8.0;HDR=Yes;'";
                Conn = new OleDbConnection(ConnectionString);
                Conn.Open();
            }
            public static DataTable GetModel(string Sheetname)
            {
                OleDbDataAdapter adapt = new OleDbDataAdapter("Select * from [" + Sheetname + "$]", Conn);
                DataTable dt = new DataTable();
                adapt.Fill(dt);

                return dt;
            }

            public static void Insert_DB_From_Excel(string sheetname, string target_table, string Excel_Columns, string DB_Columns)
            {
                DataTable dtsheet = GetModel(sheetname);

                foreach (DataRow row in dtsheet.Rows)
                {
                    string[] all_cols = Excel_Columns.Split(',');
                    List<string> values = new List<string>();
                    if (all_cols.Length > 1)
                    {
                        foreach (string temp in all_cols)
                        {
                            values.Add(row[temp] + "");
                            //MessageBox.Show(row["Name"] + "");
                            //Console.WriteLine(row[temp]);
                        }
                    }
                    string value = all_cols.Length > 1 ? string.Join(",", values.ToArray()) : "N'" + row[all_cols[0]] + "'";
                    Console.WriteLine(value);

                    if (!Database.Insert(target_table, DB_Columns, value))
                        MessageBox.Show("Failed");
                }
            }
        }
    }

    public class Excels
    {
        public static OleDbConnection Conn;
        public static void open(string path)
        {
            string ConnectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + path + "';Extended Properties='Excel 8.0;HDR=Yes;'";
            Conn = new OleDbConnection(ConnectionString);
            Conn.Open();
        }
        public static DataTable GetModel(string Sheetname)
        {
            OleDbDataAdapter adapt = new OleDbDataAdapter("Select * from [" + Sheetname + "$]", Conn);
            DataTable dt = new DataTable();
            adapt.Fill(dt);

            return dt;
        }

        public static object QueryScalar(string sql)
        {
            OleDbCommand cmd = new OleDbCommand(sql, Conn);
            object obj = cmd.ExecuteScalar();
            cmd.Dispose();
            return obj;
        }

        public static DataTable QueryModel(string sql)
        {
            OleDbDataAdapter adapt = new OleDbDataAdapter(sql, Conn);
            DataTable dt = new DataTable();
            adapt.Fill(dt);

            return dt;
        }

        public static void Insert_ForeignerTable(string Sheet, string Exc_Primary)
        {
            DataTable dt = QueryModel("Select * from [Native$]");
            foreach (DataRow row in dt.Rows)
            {
                string value1 = "" + Database.QueryScalar("Select ClassID from Class where ClassName='" + row["ClassName"] + "'");
                string value2 = "" + Database.QueryScalar("Select PersonID from Person where PersonName like '" + row["Name"] + "'");
                Database.Insert("ClassDetail", "ClassID,PersonID,Room", value1, value2, row["Room"]);
            }
        }

        public static void Insert_DB_From_Excel(string sql, string target_table, string Excel_Columns, string DB_Columns)
        {
            //DataTable dtsheet = GetModel(sheetname);
            DataTable dtsheet = QueryModel(sql);
            foreach (DataRow row in dtsheet.Rows)
            {
                string[] all_cols = Excel_Columns.Split(',');
                List<string> values = new List<string>();
                if (all_cols.Length > 1)
                {
                    foreach (string temp in all_cols)
                    {
                        values.Add(row[temp] + "");
                        //MessageBox.Show(row["Name"] + "");
                        //Console.WriteLine(row[temp]);
                    }
                }
                string value = all_cols.Length > 1 ? string.Join(",", values.ToArray()) : "N'" + row[all_cols[0]] + "'";
                Console.WriteLine(value);

                //if (!Database.Insert(target_table, DB_Columns, value))
                //    MessageBox.Show("Failed");
            }
        }
    }

}