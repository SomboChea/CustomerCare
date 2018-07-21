using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
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
        public static Region Circle(Control control)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, control.Width - 2, control.Height - 2);
            Region rg = new Region(gp);
            control.Region = rg;
            return rg;
        }

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
        public static void FillComboBox(ListControl cb, string displaymember, string valuemember, string sql)
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




        public static void ShowMsg(object text)
        {
            MessageBox.Show(text + "");
        }
        public static void ShowConsole(object text)
        {
            Console.WriteLine(text);
        }
        public static void SetRedbox(Control txt)
        {
            Label redline = new Label();
            redline.BackColor = Color.Red;
            redline.Size = new Size(txt.Size.Width + 4, txt.Size.Height + 4);
            redline.Location = new Point(txt.Location.X - 2, txt.Location.Y - 2);
            redline.Tag = "RedLine";
            txt.Parent.Controls.Add(redline);
        }
        public static void ClearRedline(Control main)
        {
            for (int i = main.Controls.Count - 1; i >= 0; i--)
            {
#pragma warning disable CS0252 // Possible unintended reference comparison; left hand side needs cast
                if (main.Controls[i].Tag == "RedLine")
#pragma warning restore CS0252 // Possible unintended reference comparison; left hand side needs cast
                {
                    main.Controls.Remove(main.Controls[i]);
                }
            }
        }
        public static bool checkRequire(Control ctrl)
        {
            bool result = false;
            if (ctrl is TextBox)
            {
                result = ((TextBox)ctrl).Text.Trim() != "";
            }
            if (ctrl is ComboBox)
            {
                result = ((ComboBox)ctrl).Text.Trim() != "";
            }
            //if (!result)
            //SetRedbox(ctrl);
            return result;
        }

        ////public static void NumberOnlyEvent(object sender,KeyEventHandler e)
        ////{
        ////    if(!(Char.IsDigit((char)e.KeyValue) && e.KeyValue == 8))
        ////    {
        ////        e.Handled = true;
        ////    }
        ////}

        /// <summary>
        /// Check with many Control
        /// </summary>
        /// <param name="ctrl"></param>
        /// <returns>True : is No Problem</returns>
        public static bool checkRequire(params Control[] ctrl)
        {
            bool check = true;
            foreach (Control c in ctrl)
            {
                if (c == null)
                    return check;
                check = checkRequire(c) ? check : false;
            }

            return check;
        }

        public static string joinArray(string[] data)
        {
            string output = "N'" + String.Join("',N'", data) + "'";
            return output;
        }




    }

}