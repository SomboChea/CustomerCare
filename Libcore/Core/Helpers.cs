using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMLOGX.Core
{
    /// <summary>
    /// Helpers
    /// </summary>
    public class Helpers
    {
        /// <summary>
        /// This is A function Use to Upload Photo into Specific Directory
        /// </summary>
        /// <param name="filepath">Original full file path</param>
        /// <param name="Directory_Path">Directory to Copy file into</param>
        /// <returns>Return a name and extension of Image in Directory_path</returns>
        public static string Upload_Photo(string filepath, string Directory_Path)
        {
            try
            {
                string[] filesplit = filepath.Split('\\');
                string filename = filesplit[filesplit.Length - 1];
                string imgpath = Directory_Path + filename;

                if (!Directory.Exists(Directory_Path))
                {
                    Directory.CreateDirectory(Directory_Path);
                }

                if (File.Exists(imgpath))
                {
                    DialogResult diag = MessageBox.Show("File : \n" + filepath + Environment.NewLine + " is Already Exist ! \nDo you want to Replace file" + Environment.NewLine + "\n\nYes : Replace File" + Environment.NewLine + "No : Auto Rename file" + Environment.NewLine + "Cancel : Abort", "File Exist", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
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
                File.Copy(filepath, imgpath);

                return filename;
            }
            catch (Exception ex)
            {
                Log.Write(ex.Message, "Helpers.Upload_Photo");
            }
            return null;
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

    /// <summary>
    /// App Forecing Form
    /// </summary>
    public static class App
    {
        public static void Open(Form context)
        {
            context.Show();
            return;
        }

        public static void ExitThread(Form context)
        {
            new ApplicationContext(context).ExitThread();
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
    }
}