using SMLOGX.Core;
using System;
using System.Windows.Forms;

namespace CustomerCare
{
    public partial class frmAddress : Form
    {
        private class function : frmHcp.helper
        {
            public static void FillListBox(ListBox lb, string value, string member, string sql)
            {
                lb.DisplayMember = member;
                lb.ValueMember = value;
                lb.DataSource = Database.QueryModel(sql);
            }
        }

        public frmAddress()
        {
            InitializeComponent();
            Database.Server = "localhost";
            Database.DBName = "CustomerCare";
            Database.Open();

            Clear();
        }

        private void listPro_SelectedIndexChanged(object sender, EventArgs e)
        {
            listComm.DataSource = null;
            listDis.DataSource = null;
            function.FillListBox(listDis, "ks_id", "ks_name", "Select * from tbl_ks where pc_id=" + listPro.SelectedValue);
        }

        private void frmAddPos_Load(object sender, EventArgs e)
        {
            function.FillListBox(listPro, "pc_id", "pc_name", "Select * from tbl_provinces");
        }

        private void listDis_SelectedIndexChanged(object sender, EventArgs e)
        {
            listComm.DataSource = null;
            function.FillListBox(listComm, "sk_id", "sk_name", "Select * from tbl_sk where ks_id=" + listDis.SelectedValue);
        }

        private void btnPro_Click(object sender, EventArgs e)
        {
            Database.Insert("tbl_provinces", "pc_name", txtpro.Text);
            frmAddPos_Load(null, null);
            Clear();
        }

        private void btnDis_Click(object sender, EventArgs e)
        {
            Database.Insert("tbl_ks", "ks_name,pc_id", txtdis.Text, listPro.SelectedValue);
            listPro_SelectedIndexChanged(null, null);
            Clear();
        }

        private void Clear()
        {
            txtcomm.Text = "";
            txtdis.Text = "";
            txtpro.Text = "";
            btnPro.Enabled = false;
            btnDis.Enabled = false;
            btnComm.Enabled = false;
        }

        private void btnComm_Click(object sender, EventArgs e)
        {
            Database.Insert("tbl_sk", "sk_name,ks_id", txtcomm.Text, listDis.SelectedValue);
            listDis_SelectedIndexChanged(null, null);
            Clear();
        }

        private void txtpro_TextChanged(object sender, EventArgs e)
        {
            btnPro.Enabled = txtpro.Text.Trim() != "";
        }

        private void txtdis_TextChanged(object sender, EventArgs e)
        {
            btnDis.Enabled = true;
            if (txtdis.Text.Trim() == "")
            {
                btnDis.Enabled = false;
                return;
            }
            if (listPro.SelectedItems.Count <= 0)
            {
                btnDis.Enabled = false;
                return;
            }
        }

        private void txtcomm_TextChanged(object sender, EventArgs e)
        {
            btnComm.Enabled = true;
            if (txtcomm.Text.Trim() == "")
            {
                btnComm.Enabled = false;
                return;
            }
            if (listPro.SelectedItems.Count <= 0)
            {
                btnComm.Enabled = false;
                return;
            }
            if (listDis.SelectedItems.Count <= 0)
            {
                btnComm.Enabled = false;
                return;
            }
        }
    }
}