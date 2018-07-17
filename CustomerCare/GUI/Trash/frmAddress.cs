using SMLOGX.Core;
using System;
using System.Windows.Forms;

namespace CustomerCare
{
    public partial class frmAddress : Form
    {
        private class function : frmSources.helper
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
            
        }

        private void frmAddPos_Load(object sender, EventArgs e)
        {
            
        }

        private void listDis_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnPro_Click(object sender, EventArgs e)
        {
            Database.Insert("tbl_provinces", "pc_name", txtpro.Text);
            frmAddPos_Load(null, null);
            Clear();
        }

        private void btnDis_Click(object sender, EventArgs e)
        {
            //Database.Insert("tbl_ks", "ks_name,pc_id", txtdis.Text, listPro.SelectedValue);
            listPro_SelectedIndexChanged(null, null);
            Clear();
        }

        private void Clear()
        {
            
        }

        private void btnComm_Click(object sender, EventArgs e)
        {
            //Database.Insert("tbl_sk", "sk_name,ks_id", txtcomm.Text, listDis.SelectedValue);
            listDis_SelectedIndexChanged(null, null);
            Clear();
        }

        private void txtpro_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtdis_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtcomm_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}