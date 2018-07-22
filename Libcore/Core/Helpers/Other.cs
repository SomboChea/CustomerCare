using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace SMLOGX.Core
{
    /// <summary>
    /// BitmapFilter
    /// </summary>
    public class BitmapFilter
    {
        private static bool Conv3x3(Bitmap b, ConvMatrix m)
        {
            // Avoid divide by zero errors
            if (0 == m.Factor) return false;

            Bitmap bSrc = (Bitmap)b.Clone();

            // GDI+ still lies to us - the return format is BGR, NOT RGB.
            BitmapData bmData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bmSrc = bSrc.LockBits(new Rectangle(0, 0, bSrc.Width, bSrc.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int stride = bmData.Stride;
            int stride2 = stride * 2;
            System.IntPtr Scan0 = bmData.Scan0;
            System.IntPtr SrcScan0 = bmSrc.Scan0;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;
                byte* pSrc = (byte*)(void*)SrcScan0;

                int nOffset = stride + 6 - b.Width * 3;
                int nWidth = b.Width - 2;
                int nHeight = b.Height - 2;

                int nPixel;

                for (int y = 0; y < nHeight; ++y)
                {
                    for (int x = 0; x < nWidth; ++x)
                    {
                        nPixel = ((((pSrc[2] * m.TopLeft) + (pSrc[5] * m.TopMid) + (pSrc[8] * m.TopRight) +
                            (pSrc[2 + stride] * m.MidLeft) + (pSrc[5 + stride] * m.Pixel) + (pSrc[8 + stride] * m.MidRight) +
                            (pSrc[2 + stride2] * m.BottomLeft) + (pSrc[5 + stride2] * m.BottomMid) + (pSrc[8 + stride2] * m.BottomRight)) / m.Factor) + m.Offset);

                        if (nPixel < 0) nPixel = 0;
                        if (nPixel > 255) nPixel = 255;

                        p[5 + stride] = (byte)nPixel;

                        nPixel = ((((pSrc[1] * m.TopLeft) + (pSrc[4] * m.TopMid) + (pSrc[7] * m.TopRight) +
                            (pSrc[1 + stride] * m.MidLeft) + (pSrc[4 + stride] * m.Pixel) + (pSrc[7 + stride] * m.MidRight) +
                            (pSrc[1 + stride2] * m.BottomLeft) + (pSrc[4 + stride2] * m.BottomMid) + (pSrc[7 + stride2] * m.BottomRight)) / m.Factor) + m.Offset);

                        if (nPixel < 0) nPixel = 0;
                        if (nPixel > 255) nPixel = 255;

                        p[4 + stride] = (byte)nPixel;

                        nPixel = ((((pSrc[0] * m.TopLeft) + (pSrc[3] * m.TopMid) + (pSrc[6] * m.TopRight) +
                            (pSrc[0 + stride] * m.MidLeft) + (pSrc[3 + stride] * m.Pixel) + (pSrc[6 + stride] * m.MidRight) +
                            (pSrc[0 + stride2] * m.BottomLeft) + (pSrc[3 + stride2] * m.BottomMid) + (pSrc[6 + stride2] * m.BottomRight)) / m.Factor) + m.Offset);

                        if (nPixel < 0) nPixel = 0;
                        if (nPixel > 255) nPixel = 255;

                        p[3 + stride] = (byte)nPixel;

                        p += 3;
                        pSrc += 3;
                    }

                    p += nOffset;
                    pSrc += nOffset;
                }
            }

            b.UnlockBits(bmData);
            bSrc.UnlockBits(bmSrc);

            return true;
        }

        public static bool GaussianBlur(Bitmap b, int nWeight /* default to 4*/)
        {
            ConvMatrix m = new ConvMatrix();
            m.SetAll(1);
            m.Pixel = nWeight;
            m.TopMid = m.MidLeft = m.MidRight = m.BottomMid = 2;
            m.Factor = nWeight + 12;

            return BitmapFilter.Conv3x3(b, m);
        }

        /// <summary>
        /// ConvMatrix
        /// </summary>
        public class ConvMatrix
        {
            public int TopLeft = 0, TopMid = 0, TopRight = 0;
            public int MidLeft = 0, Pixel = 1, MidRight = 0;
            public int BottomLeft = 0, BottomMid = 0, BottomRight = 0;
            public int Factor = 1;
            public int Offset = 0;

            public void SetAll(int nVal)
            {
                TopLeft = TopMid = TopRight = MidLeft = Pixel = MidRight = BottomLeft = BottomMid = BottomRight = nVal;
            }
        }
    }

    /// <summary>
    /// ScreenShot
    /// </summary>
    public class Screenshot
    {
        public static Bitmap TakeSnapshot(System.Windows.Forms.Control ctl)
        {
            Bitmap bmp = new Bitmap(ctl.Size.Width, ctl.Size.Height);
            System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(bmp);
            g.CopyFromScreen(ctl.PointToScreen(ctl.ClientRectangle.Location), new Point(0, 0), ctl.ClientRectangle.Size);
            return bmp;
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
            return "N" + strCase + String.Join("'" + imp + "N'", values) + strCase;
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

    /// App Forecing Form
    /// </summary>
    public static class App
    {
        public static void Overlay(Form front, Form back)
        {
            Open(back);
            OpenDialog(front);
            front.Close();
            back.Close();
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

    //
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
