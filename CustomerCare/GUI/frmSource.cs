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
    public partial class frmSource : MetroForm
    {
        public frmSource()
        {
            InitializeComponent();
            dgSources.Columns.Clear();
            dgSources.MultiSelect = false;
            ReloadGridview();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmNewSource frm = new frmNewSource();
            frm.ShowDialog();
            ReloadGridview();
        }

        private void cbSearchby_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// all column 
        /// </summary>
        public string sqlColumn { get; set; } = "id Code,	src_name Name,	src_owner Owner,	src_tel1 Tel_1,	src_tel2 Tel_2,	src_mail Email,	src_memo Memo,	src_address Location,	srctype Type,	user_fullname Logged_by,src_logged log_id,	id,src_address_id,srctype_id";
        /// <summary>
        /// default Select to gridview statement
        /// </summary>
        public string sqlSelect { get; set; } = @"Select id Code,	src_name Name,	src_owner Owner,	src_tel1 Tel_1,	src_tel2 Tel_2,	src_mail Email,	src_memo Memo,	src_address Location,	srctype Type,	user_fullname Logged_by,src_logged log_id,	id,src_address_id,srctype_id from viewSource2";

        /// <summary>
        /// Reload Data from Database
        /// </summary>
        private void ReloadGridview()
        {
            dgSources.DataSource = Database.QueryModel(sqlSelect);
            HideColumn();
        }

        /// <summary>
        /// use for hide neccessary but not showing column
        /// </summary>
        private void HideColumn()
        {
            dgSources.Columns["id"].Visible = false;
            dgSources.Columns["log_id"].Visible = false;
            dgSources.Columns["src_address_id"].Visible = false;
            dgSources.Columns["srctype_id"].Visible = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (cbSearchby.Text.Trim() == "")
            {
                return;
            }
            if (txtSearch.Text.Trim() == "")
            {
                ReloadGridview();
                return;
            }

            string column = cbSearchby.Text;
            // Currency manager , I dont know too
            // without this will cause Error
            CurrencyManager currency = (CurrencyManager)BindingContext[dgSources.DataSource];
            currency.SuspendBinding();
           
            foreach (DataGridViewRow row in dgSources.Rows)
            {
                // Use for Programmatically filter Column
                // get value of specific columnn every row
                // compare
                row.Visible = row.Cells[column].Value.ToString().ToLower().Contains(txtSearch.Text.ToLower());
            }
            // 
            currency.ResumeBinding();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Helpers.ShowMsg(cbSearchby.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgSources.Rows.Count <= 0)
            {
                return;
            }

            frmNewSource frm = new frmNewSource(dgSources.SelectedRows[0].Cells["id"].Value+"",dgSources.SelectedRows[0].Cells);
            frm.ShowDialog();
            ReloadGridview();
        }
    }
}
