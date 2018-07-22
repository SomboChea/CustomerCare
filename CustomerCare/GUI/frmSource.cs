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
        //public string sqlColumn { get; set; } = "id Code,	src_name Name,	src_owner Owner,	src_tel1 Tel_1,	src_tel2 Tel_2,	src_mail Email,	src_memo Memo,	src_address Location,	srctype Type,	user_fullname Logged_by,src_logged log_id,	id,src_address_id,srctype_id";
        /// <summary>
        /// default Select to gridview statement
        /// </summary>
        public string sqlSelect { get; set; } = @"Select address ,('SR'+right('00000'+CONVERT([nvarchar](6),[id]),(6))) Code,	Name,	 Owner,	 Tel_1,	 Tel_2,	 Email,	 Memo,	 Location,	 Type,	 Logged_by, logged_id,	id,type_id,aid,pid,cid,did from viewSource2";

        /// <summary>
        /// Reload Data from Database
        /// </summary>
        private void ReloadGridview()
        {
            dgSources.DataSource = Database.QueryModel(sqlSelect);
            HideColumn();
            cbSearchby.Items.Clear();
            foreach(DataGridViewColumn col in dgSources.Columns)
            {
                if (col.Visible)
                    cbSearchby.Items.Add(col.HeaderText);
            }
        }

        /// <summary>
        /// use for hide neccessary but not showing column
        /// </summary>
        private void HideColumn()
        {
            try
            {
                dgSources.Columns["id"].Visible = false;
                dgSources.Columns["logged_id"].Visible = false;
                dgSources.Columns["type_id"].Visible = false;
                dgSources.Columns["pid"].Visible = false;
                dgSources.Columns["did"].Visible = false;
                dgSources.Columns["cid"].Visible = false;
                dgSources.Columns["aid"].Visible = false;
                dgSources.Columns["address"].Visible = false;
            }catch(Exception e)
            {
                Log.Write(e.Message, "FrmSource -> Method : HideColumn() ");
            }
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
            Database.Update("tbl_refer","Where id="+dgSources.SelectedRows[0].Cells["id"].Value, "status", "0");
            ReloadGridview();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgSources.Rows.Count <= 0)
            {
                return;
            }

            frmNewSource frm = new frmNewSource(dgSources.SelectedRows[0].Cells["id"].Value+"",dgSources.SelectedRows[0].Cells);
        
            frm.ShowDialog();
            this.Show();
            ReloadGridview();
        }
    }
}
