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
    public partial class frmKid : Form
    {
        public frmKid()
        {
            InitializeComponent();
            Database.DBName = "CustomerCare";
            Database.Server = "localhost";
            Database.Open();
            panel1.AutoScroll = false;
            panel1.HorizontalScroll.Visible = false;
            panel1.AutoScroll = true;
            panel1.MouseWheel += Panel1_MouseWheel;
            KidID = (int.Parse(Database.GetLastId("tbl_Kid") + "") + 1) + "";
            function.FillDatagridviewColumn(dataGridView1, "Select * from viewKid order by ID desc");
            //MessageBox.Show(Database.HasOpen + "");
        }

        private void Panel1_MouseWheel(object sender, MouseEventArgs e)
        {
            panel1_Scroll(panel1, new ScrollEventArgs(ScrollEventType.LargeIncrement, panel1.VerticalScroll.Value));
        }

        public string KidID { get; set; }

        private void frmKid_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            function.FillGridviewWithoutDataTable("Select top 10 * from viewKid order by ID desc", dataGridView1);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow selectedrow = dataGridView1.SelectedRows[0];
            txtName.Text = selectedrow.Cells["Name"].Value + "";
            txtorder.Text = selectedrow.Cells["Mom_ID"].Value + "";
            rmale.Checked = selectedrow.Cells["Gender"].Value.Equals("Male");
            dtpicker.Value = DateTime.Parse(selectedrow.Cells["Date of Birth"].Value + "");
            btnadd.Text = "Update";
            KidID = dataGridView1.SelectedRows[0].Cells[0].Value + "";
        }

        private void Clear()
        {
            txtName.Text = "";
            txtorder.Text = "";
            dtpicker.Value = DateTime.Now;
            rmale.Checked = true;
            btnadd.Text = "Add";
            function.ClearRed(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!function.CheckExist(txtName, txtorder, dtpicker))
                return;
            if (Database.QueryModel("Select * from viewKid where Name like '" + txtName.Text.Trim() + "' and ID !=" + KidID).Rows.Count > 0)
            {
                MessageBox.Show("Name Exist", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                function.SetRedbox(txtName);
                return;
            }
            if (btnadd.Text == "Add")
            {
                Database.Insert("tbl_Kid", "[kid_name], [kid_dob], [kid_sex], [mom_id]", txtName.Text, dtpicker.Value, rmale.Checked ? "Male" : "Female", txtorder.Text);
            }
            if (btnadd.Text == "Update")
            {
                Database.Update("tbl_Kid", "[kid_name] = N'" + txtName.Text + "', [kid_dob] = '" + dtpicker.Value + "', [kid_sex] = N'" + (rmale.Checked ? "Male" : "Female") + "', [mom_id] = N'" + txtorder.Text + "'", "kid_ID=" + KidID);
            }
            btnadd.Text = "Add";
            Clear();
            frmKid_Load(null, null);
            KidID = (int.Parse(Database.GetLastId("tbl_Kid") + "") + 1) + "";
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (textBox12.Text.Trim() != "")
            {
                dataGridView1.Rows.Clear();
                function.FillGridviewWithoutDataTable("Select * from viewKid where Name like '%" + textBox12.Text.Trim() + "%'", dataGridView1);
            }
            else
            {
                frmKid_Load(null, null);
            }
        }

        private void panel1_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.NewValue == 0 || textBox12.Text.Trim() != "")
                return;
            if (e.NewValue >= (panel1.VerticalScroll.Maximum - panel1.VerticalScroll.LargeChange))
            {
                panel1.Cursor = Cursors.WaitCursor;
                string sql = "Select top 10 * from viewKid where ID<" + dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value + " order by ID desc";
                //txtMemo.Text = sql;
                function.FillGridviewWithoutDataTable(sql, dataGridView1);
                if (Database.QueryScalar("Select count(*) from viewKid").ToString().Equals(dataGridView1.Rows.Count + ""))
                    MessageBox.Show("Load All Rows", "Kid", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            panel1.Cursor = Cursors.Default;
        }

        /// <summary>
        /// Dont Delete this class
        /// </summary>
        private class function : frmHcp.helper
        {
        }
    }
}