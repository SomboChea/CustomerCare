using CustomerCare.STR;
using SMLOGX.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CustomerCare
{
    public partial class frmSources : Form
    {
        public frmSources()
        {
            InitializeComponent();

            //Database.Server = "localhost";
            //Database.DBName = "TelMarketing";
            //Database.Open();

            Function.SetCombo(cbProvince, cbDistrict, cbCommune, txtAddress);
        }

        public class helper : Helpers
        {
            /// <summary>
            /// note : DatagridviewColumn Name must be match with Database Table ColumnName
            /// </summary>
            /// <param name="sql"></param>
            /// <param name="dgView"></param>
            public static void FillGridviewWithoutDataTable(string sql, DataGridView dgView)
            {
                double dgheight = dgView.ColumnHeadersHeight;

                DataTable dt = Database.QueryModel(sql);
                foreach (DataRow row in dt.Rows)
                {
                    List<object> obj = new List<object>();
                    foreach (DataGridViewColumn col in dgView.Columns)
                    {
                        obj.Add(row[col.Name]);
                    }
                    dgView.Rows.Add(obj.ToArray());
                }

                dgheight += dgView.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + 30;
                dgView.Size = new Size(dgView.Size.Width, int.Parse(Math.Ceiling(dgheight) + ""));
            }

            public static bool CheckExist(params Control[] ctrls)
            {
                bool check = true;
                foreach (Control ctrl in ctrls)
                {
                    if (ctrl.Text.Trim() != "")
                        continue;
                    SetRedbox(ctrl);
                    check = false;
                }

                return check;
            }

            public static void SetRedbox(Control ctrl)
            {
                Label redlabel = new Label();
                redlabel.Size = new Size(ctrl.Size.Width + 4, ctrl.Size.Height + 4);
                redlabel.Location = new Point(ctrl.Location.X - 2, ctrl.Location.Y - 2);
                redlabel.BackColor = Color.Red;
                redlabel.Tag = "Clear";
                ctrl.Parent.Controls.Add(redlabel);
            }

            public static void AutoFilltextboxfromDatagridview(DataGridViewRow selectedrow, Control main)
            {
                foreach (Control ctrl in main.Controls)
                {
                    if (ctrl is GroupBox || ctrl is Panel)
                    {
                        AutoFilltextboxfromDatagridview(selectedrow, ctrl);
                        continue;
                    }
                    if (ctrl is ComboBox)
                        continue;
                    try
                    {
                        ctrl.Text = selectedrow.Cells[ctrl.Tag + ""].Value + "";
                    }
                    catch (Exception) { }
                }
            }

            public static void ClearRed(Control main)
            {
                foreach (Control ctrl in main.Controls)
                {
                    if (ctrl is GroupBox || ctrl is Panel)
                    {
                        ClearRed(ctrl);
                    }
                    if (ctrl.Tag == "Clear")
                    {
                        ctrl.Visible = false;
                    }
                }
                foreach (Control ctrl in main.Controls)
                {
                    if (ctrl is GroupBox || ctrl is Panel)
                    {
                        ClearRed(ctrl);
                    }
                    if (ctrl.Tag == "Clear")
                    {
                        main.Controls.Remove(ctrl);
                    }
                }
            }
        }

        /** Close Button **/

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnClose_MouseDown(object sender, MouseEventArgs e)
        {
            btnClose.BackColor = Color.Crimson;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = panHead.BackColor;
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Crimson;
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            Temp.frm_luanch.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Function.AddAddress();
        }
    }
}