using SMLOGX.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerCare
{
    public partial class frmHcp : Form
    {
        public frmHcp()
        {
            InitializeComponent();

            Database.Server = "localhost";
            Database.DBName = "CustomerCare";
            Database.Open();
            //dgView.DataSource = Database.GetDataSet("Select * from tbl_mststaff").Tables[0];
        }

        private int id = 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            {
                id++;
                string[] hcpIdentity = { txtName.Text, txtOwner.Text };
                string[] address = { cblocation.Text, cbdistrict.Text, cbcommune.Text, txtST.Text };
                string[] tels = { txtTel1.Text, txtTel2.Text };
                string[] econtact = { txtEmail.Text, txtFB.Text };
                string memo = txtMemo.Text;
                MessageBox.Show(txtName.Parent.Text);

                dgView.Rows.Add(id, hcpIdentity[0], hcpIdentity[1], address[0], address[1], address[2], address[3], tels[0], tels[1], econtact[0], econtact[1], memo);
            }
            helper.ClearRed(this);
            if (!helper.CheckExist(txtName, txtST, txtTel1, cbcommune, cbdistrict, cblocation))
                return;

            bool checknum = false;
            if (Database.QueryModel("Select Count(*) from tbl_mststaff where " + txtTel1 + " in(Tel_per1,Tel_per2)").Rows.Count > 0)
            {
                helper.SetRedbox(txtTel1);
            }
            if (txtTel2.Text.Trim().Equals(""))
            {
                if (Database.QueryModel("Select Count(*) from tbl_mststaff where " + txtTel2 + " in(Tel_per1,Tel_per2)").Rows.Count > 0)
                {
                    helper.SetRedbox(txtTel1);
                }
            }
            if (checknum)
            {
                MessageBox.Show("Telephone Number is Exist !", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
        }

        private void dgView_DoubleClick(object sender, EventArgs e)
        {
            if (dgView.SelectedRows.Count > 0)
                helper.AutoFilltextboxfromDatagridview(dgView.SelectedRows[0], this);
        }

        private void frmHcp_Load(object sender, EventArgs e)
        {
        }
    }

    internal class helper : Helpers
    {
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
                }
                try
                {
                    ctrl.Text = selectedrow.Cells[ctrl.Tag + ""].Value + "";
                }
                catch (Exception ex)
                {
                    Log.Write(ex.Message, "Helper.AutoFilltextboxfromDatagridview");
                }
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
}