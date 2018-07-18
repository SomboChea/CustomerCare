using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using SMLOGX.Core;

namespace CustomerCare.GUI
{
    public partial class frmCustomer : MetroForm
    {
        /// <summary>
        /// Column that use to show in gridview
        /// </summary>
        string Columns = "Code,Name,Exp_Date,Tel_1,Tel_2,Email,FB,Other,Address,From_Source,Status,Logged_By,address_id,source_ID";

        public frmCustomer()
        {
            InitializeComponent();
            // Keep Your Columns You want to show
            // so Clear here
            dgCustomers.Columns.Clear();

            ReloadGridview();
            ReloadSearchFilter();
        }

        public void ReloadSearchFilter()
        {
            cbFilterby.Items.AddRange(Columns.Split(',')) ;
            
        }

        /// <summary>
        /// Reload Datagridview Data
        /// </summary>
        public void ReloadGridview()
        { 
            string sql = "select "+Columns+" from viewMomBySource where Status=1";
            dgCustomers.DataSource = Database.QueryModel(sql);
            dgCustomers.Columns["address_id"].Visible = false;
            dgCustomers.Columns["source_id"].Visible = false;
        }
        
        /// <summary>
        /// use For Search and Filter event
        /// </summary>
        public void search(string col,string val)
        {
            List<string> listcmd = new List<string>();
            string condition = "";
            string sql = "select {0} from viewMomBySource where Status=1 and \"{1}\" like '%{2}%'";
            sql = string.Format(sql, Columns, col, val);
            dgCustomers.DataSource=Database.QueryModel(sql);
        }

        private void cbFilterby_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbToFilter.DataSource = null;
            string filter = cbFilterby.Text;
            cbToFilter.DisplayMember = "Name";
            cbToFilter.DataSource = Database.QueryModel("select distinct("+filter+") Name from viewMomBySource where Status=1");
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void cbToFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            search(cbFilterby.Text, cbToFilter.Text);
        }

        private void cbToFilter_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            if (txtSearch.Text.Trim() == "")
            {
                ReloadGridview();
                return;
            }
            
            search("Name", txtSearch.Text.Trim());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgCustomers.SelectedRows.Count <= 0)
                return;
            Database.Update("tbl_mom", "where id="+dgCustomers.SelectedRows[0].Cells["Code"].Value, "Status", "0");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmCustomerDetail frm = new frmCustomerDetail();
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgCustomers.SelectedRows.Count <= 0)
                return;
            // get all cell of selected row
            DataGridViewCellCollection cell = dgCustomers.SelectedRows[0].Cells;
            frmCustomerDetail frm = new frmCustomerDetail(cell["Code"].Value + "",cell["Name"].Value+"",cell["Tel_1"].Value+"",cell["Tel_2"].Value+"");
            frm.ShowDialog();
        }
    }
}
