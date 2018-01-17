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
            panel1.HorizontalScroll.Visible = false;
            panel1.HorizontalScroll.Enabled = false;
            panel1.AutoScroll = true;
            panel1.MouseWheel += Panel1_MouseWheel;
            addevent(this);
            //dgView.DataSource = Database.GetDataSet("Select * from tbl_mststaff").Tables[0];
        }

        private void Panel1_MouseWheel(object sender, MouseEventArgs e)
        {
            panel1_Scroll(sender, new ScrollEventArgs(ScrollEventType.EndScroll, panel1.VerticalScroll.Value));
        }

        public string id { get; set; }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            {
                //string[] hcpIdentity = { txtName.Text, txtOwner.Text };
                //string[] address = { cblocation.Text, cbdistrict.Text, cbcommune.Text, txtST.Text };
                //string[] tels = { txtTel1.Text, txtTel2.Text };
                //string[] econtact = { txtEmail.Text, txtFB.Text };
                //string memo = txtMemo.Text;
                //MessageBox.Show(txtName.Parent.Text);

                //dgView.Rows.Add(id, hcpIdentity[0], hcpIdentity[1], address[0], address[1], address[2], address[3], tels[0], tels[1], econtact[0], econtact[1], memo);
            }
            helper.ClearRed(this);
            if (!helper.CheckExist(txtName, txtST, txtTel1, cbcommune, cbdistrict, cblocation))
                return;

            bool checknum = false;
            if (Database.QueryModel("Select Count(*) from tbl_mststaff where " + txtTel1 + " in(Tel_per1,Tel_per2) and staff_id!=" + id) + "" == "0")

            {
                helper.SetRedbox(txtTel1);
            }
            if (txtTel2.Text.Trim().Equals(""))
            {

                if (Database.QueryModel("Select Count(*) from tbl_mststaff where " + txtTel2 + " in(Tel_per1,Tel_per2) and staff_id!=" + id) + "" == "0")

                {
                    helper.SetRedbox(txtTel1);
                }
            }
            if (checknum)
            {
                MessageBox.Show("Telephone Number is Exist !", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (btnAdd.Text == "Add")
            {
                string columns = "hcp_name,hcp_owner,address_id,hcp_tel1,hcp_tel2,hcp_email,hcp_fb,hcp_memo";
                Database.QueryScalar("Insert into tbl_address values(" + cbcommune.SelectedValue + ",'" + txtST.Text + "','');");
                Database.Insert("tbl_hcp", columns, txtName.Text, txtOwner.Text, Database.GetLastId("tbl_address"), txtTel1.Text, txtTel2.Text, txtEmail.Text, txtFB.Text, txtMemo.Text);
            }
            if (btnAdd.Text == "Update")
            {
                string data = "[hcp_name] = N'" + txtName.Text + "', [hcp_owner] = N'" + txtOwner.Text + "',  [hcp_tel1] = '" + txtTel1.Text + "', [hcp_tel2] = '" + txtTel2.Text + "', [hcp_email] = '" + txtEmail.Text + "', [hcp_fb] = N'" + txtFB.Text + "', [hcp_memo] = N'" + txtMemo.Text + "'";
                Database.Update("tbl_hcp", data, " hcp_id=" + id);
                Database.Update("tbl_address", " sk_id=" + cbcommune.SelectedValue + " ,st_road=" + txtST.Text);
                btnAdd.Text = "Add";
            }
            id = (Database.GetLastId("tbl_hcp") + 1) + "";
            Clear(this);
            frmHcp_Load(null, null);

        }

        private void dgView_DoubleClick(object sender, EventArgs e)
        {

        }

        private void frmHcp_Load(object sender, EventArgs e)
        {
            dgView.Rows.Clear();
            cblocation.DataSource = null;
            helper.FillGridviewWithoutDataTable("Select top 10 * from viewHcp order by ID desc", dgView);
            helper.FillComboBox(cblocation, "pc_name", "pc_id", "Select * from tbl_provinces");
            id = (Database.GetLastId("tbl_hcp") + 1) + "";

        }

        void Clear(Control main)
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
                else if (ctrl is GroupBox)
                    Clear(ctrl);
                else if (ctrl is TextBox)
                    ctrl.Text = "";
        }

        void addevent(Control main)
        {
            foreach (Control ctrl in main.Controls)
            {
                if (ctrl is GroupBox || ctrl is Panel)
                {
                    addevent(ctrl);
                    continue;
                }
                ctrl.KeyPress += new KeyPressEventHandler(frmHcp_KeyPress);
            }
        }


        private void cblocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbdistrict.DataSource = null;
            cbcommune.DataSource = null;
            helper.FillComboBox(cbdistrict, "ks_name", "ks_id", "Select * from tbl_ks where pc_id=" + cblocation.SelectedValue);
        }


        private void cbdistrict_SelectedIndexChanged(object sender, EventArgs e)

        {
            cbcommune.DataSource = null;
            helper.FillComboBox(cbcommune, "sk_name", "sk_id", "Select * from tbl_sk where ks_id=" + cbdistrict.SelectedValue);
        }

        private void dgView_Click(object sender, EventArgs e)
        {

        }

        private void dgView_Scroll(object sender, ScrollEventArgs e)
        {
            //if (e.ScrollOrientation != ScrollOrientation.VerticalScroll)
            //    return;


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgView.Rows.Clear();
            if (txtSearch.Text.Trim() == "")
            {
                helper.FillGridviewWithoutDataTable("Select top 10 * from viewHcp order by id desc", dgView);

            }
            else
            {

                helper.FillGridviewWithoutDataTable("Select * from viewHcp where hcpName like '%" + txtSearch.Text + "%'", dgView);

            }
        }

        private void panel1_Scroll(object sender, ScrollEventArgs e)
        {

            //label1.Text = panel1.VerticalScroll.LargeChange+"  "+e.NewValue + "  " + (panel1.VerticalScroll.Maximum - panel1.VerticalScroll.LargeChange);
            if (e.NewValue == 0 || txtSearch.Text.Trim() != "")
                return;
            if (e.NewValue >= (panel1.VerticalScroll.Maximum - panel1.VerticalScroll.LargeChange))
            {
                panel1.Cursor = Cursors.WaitCursor;
                string sql = "Select top 10 * from viewHcp where ID<" + dgView.Rows[dgView.Rows.Count - 1].Cells[0].Value + " order by ID desc";
                //txtMemo.Text = sql;
                helper.FillGridviewWithoutDataTable(sql, dgView);
                if (Database.QueryScalar("Select count(*) from viewHcp").ToString().Equals(dgView.Rows.Count + ""))
                    MessageBox.Show("Load All Rows", "HCP", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            panel1.Cursor = Cursors.Default;
        }

        private void dgView_DoubleClick_1(object sender, EventArgs e)
        {
            if (dgView.SelectedRows.Count > 0)
            {
                helper.AutoFilltextboxfromDatagridview(dgView.SelectedRows[0], this);
                cblocation.Text = dgView.SelectedRows[0].Cells["Location"].Value + "";
                cbdistrict.Text = dgView.SelectedRows[0].Cells["District"].Value + "";
                cbcommune.Text = dgView.SelectedRows[0].Cells["Commune"].Value + "";
                btnAdd.Text = "Update";
                id = dgView.SelectedRows[0].Cells["ID"].Value + "";
            }
        }

        private void frmHcp_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show("dsdsd");
            if (e.KeyChar == 27)
            {
                Clear(this);
            }
        }
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
}
