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
    public partial class frmCustomerDetail : MetroForm
    {
        public frmCustomerDetail()
        {
            InitializeComponent();
            // u have design column name 
            // and after run will delete
            dgKids.Columns.Clear();
            // If open as edit or new
            edit = false;
        }
        public frmCustomerDetail(string mom_id,string mom_name,string t1,string t2)
        {
            InitializeComponent();
            dgKids.Columns.Clear();

            id = mom_id;
            ReloadGridView(id);

            txtMomName.Text = mom_name;
            txtTel1.Text = t1;
            txtTel2.Text = t2;

            edit = true;
        }

        public bool edit { get; set; } = false;
        public string id { get; set; }
        private void txtMomName_Click(object sender, EventArgs e)
        {

        }

        private void Clear()
        {
            txtKidName.Text = "";
            txtKidOrder.Text = "";
            cbGender.SelectedIndex = 0;
            dpDOB.Value = DateTime.Now;
            txtSearch.Text = "";
        }

        private void Insert_Update_Mom()
        {
            string name_id  = Database.QueryScalar(@"DECLARE @id int=0 exec @id=insertName 'myothername', 1 select @id")+"";
            Helpers.ShowMsg(name_id);
            string col = "name_id,tel_1,tel_2";
            if (id == null)
            {
                Database.Insert("tbl_mom", col, name_id, txtTel1.Text, txtTel2.Text);
                id = Database.GetLastId("tbl_mom")+"";
            }
            else
            {
                Database.Update("tbl_mom","Where id="+id,col, name_id, txtTel1.Text, txtTel2.Text);
            }
        }

        /// <summary>
        /// Verify If Pass or not
        /// </summary>
        /// <returns>True : All is fine</returns>
        private bool verify()
        {
            bool check;
           
            check = Helpers.checkRequire(txtKidName, txtKidOrder, txtMomName, txtTel1, cbGender, dpDOB);
            
           
            return check;
        }
        string DefaultSelectSql { get; set; } = "Select \"order\",Name,Sex,Date_of_Birth from viewKidsByMom where status=1";
        public void ReloadGridView(string mid)
        {
            string sql = DefaultSelectSql + " and mom_id=" + mid;
            dgKids.DataSource = Database.QueryModel(sql);
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void frmCustomerDetail_Load(object sender, EventArgs e)
        {
         
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (!verify())
            {
                return;
            }
            Insert_Update_Mom();

            //string kid_order = (int.Parse(dgKids.Rows[dgKids.Rows.Count - 1].Cells["Order"].Value+"")+1).ToString();
            string kid_data = string.Join(",", id, txtKidName.Text, cbGender.SelectedIndex+"", dpDOB.Value.ToShortDateString(),txtKidOrder.Text);
            Database.Exec("exec insertKid " + kid_data);

            ReloadGridView(id);
            Clear();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
            {
                dgKids.DataSource = Database.QueryModel(DefaultSelectSql+" and mom_id="+id);
                return;
            }
            dgKids.DataSource=Database.QueryModel(DefaultSelectSql+" and mom_id"+id+" and Name like '%"+txtSearch.Text+"%'")
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
