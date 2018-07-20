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
            dgKids.SelectionChanged += DgKids_SelectionChanged;
 
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

            dgKids.SelectionChanged += DgKids_SelectionChanged; ;

           
            edit = true;
        }

        private void DgKids_SelectionChanged(object sender, EventArgs e)
        {
            
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
            btnSave.Text = "Save";
            rowEditing = false;
        }

        private void Insert_Update_Mom()
        {
            //string name_id  = Database.QueryScalar(@"DECLARE @id int=0 exec @id=insertName '"+txtMomName.Text+"', 3 select @id")+"";
            ////Helpers.ShowMsg(name_id);
            //string col = "name_id,tel_1,tel_2";
            //if (id == null)
            //{
            //    Database.Insert("tbl_mom", col, name_id, txtTel1.Text, txtTel2.Text);
            //    id = Database.GetLastId("tbl_mom")+"";
            //}
            //else
            //{
            //    Database.Update("tbl_mom","Where id="+id,col, name_id, txtTel1.Text, txtTel2.Text);
            //}
        }

        /// <summary>
        /// Verify If Pass or not
        /// </summary>
        /// <returns>True : All is fine</returns>
        private bool verify()
        {
            bool check;
           
            check = Helpers.checkRequire(txtKidName, txtKidOrder, txtMomName, txtTel1, cbGender, dpDOB);


            //return check;
            return true;
        }

        string DefaultSelectSql { get; set; } = "Select kid_id, \"order\",Name,Sex,Date_of_Birth,sex_id from viewKidsByMom where status=1";

        public void ReloadGridView(string mid)
        {
            string sql = DefaultSelectSql + " and mom_id=" + mid;
            dgKids.DataSource = Database.QueryModel(sql);
            dgKids.Columns["sex_id"].Visible = false;
            dgKids.Columns["kid_id"].Visible = false;
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void frmCustomerDetail_Load(object sender, EventArgs e)
        {
         
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
            ReloadGridView(id);
            //if (!verify())
            //{
            //    Helpers.ShowMsg("not input all require field");
            //    return;
            //}
            //Insert_Update_Mom();

            //string kid_order = (int.Parse(dgKids.Rows[dgKids.Rows.Count - 1].Cells["Order"].Value+"")+1).ToString();
            
        }
        private bool rowEditing { get; set; } = false;
        private int rowEditingIndex;
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
            {
                dgKids.DataSource = Database.QueryModel(DefaultSelectSql+" and mom_id="+id);
                dgKids.Columns["sex_id"].Visible = false;
            dgKids.Columns["kid_id"].Visible = false;

                return;
            }
            dgKids.DataSource = Database.QueryModel(DefaultSelectSql + " and mom_id=" + id + " and Name like '%" + txtSearch.Text + "%'");

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
                string col = " [name_id], [sex], [dob], [order]";

                string name_id = Database.QueryScalar(@"DECLARE @id int=0 exec @id=insertName '"+txtKidName.Text+"', 4 select @id") + "";
                //Helpers.ShowMsg(name_id);

                if (rowEditing)
                {
<<<<<<< HEAD
                    Database.Update("tbl_kid","Where id="+dgKids.SelectedRows[0].Cells["id"].Value, col, name_id, txtKidOrder.Text, cbGender.SelectedIndex,dpDOB.Value.ToShortDateString());
                    id = Database.GetLastId("tbl_mom") + "";
=======
                    Database.Update("tbl_kid", "Where id=" + dgKids.SelectedRows[0].Cells["kid_id"].Value+"", col,name_id,cbGender.SelectedIndex,dpDOB.Value.ToShortDateString(),txtKidOrder.Text);
                    //id = Database.GetLastId("tbl_mom") + "";
                    
                    ReloadGridView(id);
                    Clear();
                    rowEditing = false;
                    return;
>>>>>>> 1ec6c23c8d62aa70a5cf9141c2112e54def29a5b
                }
             
               

                string kid_data = MString.implode(",","'", id, txtKidName.Text, cbGender.SelectedIndex + "", dpDOB.Value.ToString("yyyy-MM-dd"), txtKidOrder.Text);
                Database.Exec("exec insertKid " + kid_data);

         
                rowEditing = false;
                //Helpers.ShowMsg("Edit");
            
           
        }

        private void dgKids_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            rowEditing = false;

        }

        private void dgKids_DoubleClick(object sender, EventArgs e)
        {
            if (dgKids.SelectedRows.Count <= 0)
            {
                return;
            }
            DataGridViewCellCollection cell = dgKids.SelectedRows[0].Cells;
            txtKidName.Text = cell["Name"].Value + "";
            txtKidOrder.Text = cell["Order"].Value + "";

            cbGender.SelectedIndex = int.Parse(cell["sex_id"].Value + "");
            dpDOB.Value = DateTime.Parse(cell["Date_of_Birth"].Value + "");

            btnSave.Text = "Save";
            rowEditing = true;
            rowEditingIndex = dgKids.SelectedRows[0].Index;
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
