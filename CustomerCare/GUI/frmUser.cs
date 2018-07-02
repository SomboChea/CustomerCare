using SMLOGX.Core;
using System.Windows.Forms;

namespace CustomerCare
{
    public partial class frmUser : Form
    {
        TextBox txtusername, txtpassword, txtconfirm, txtfullname;
        Button btninsert,btnclose,btnremove,btnedit,btnclear;
        ComboBox cbrole;
        DataGridView dguser;

        public frmUser()
        {
            Database.Open();

            InitializeComponent();

            init();

            refresh();

        }

        public void init()
        {
            btnremove = butremove;
            dguser = dataGridView1;
            txtusername = tfusername;
            txtconfirm = tfcon;
            txtfullname = tffullname;
            txtpassword = tfpass;
            btninsert = butadd;
            cbrole = comborole;
            btnedit = butedit;
            btnclear = butcl;
            chkedit.Visible = false;

            btnclear.Click += Btnclear_Click;
            btnedit.Click += Btnedit_Click;
            btnremove.Click += Btnremove_Click;
            btninsert.Click += Btninsert_Click;
            chkedit.CheckStateChanged += Chkedit_CheckStateChanged;
        }

        private void Btnclear_Click(object sender, System.EventArgs e)
        {
            refresh();
        }

        DataGridViewRow row;
        private void Btnedit_Click(object sender, System.EventArgs e)
        {
            if (btnedit.Text == "Update")
            {
                
                if (!Helpers.checkRequire(chkedit.Checked?txtconfirm:null, txtfullname, chkedit.Checked? txtpassword:null, txtusername))
                {
                    return;
                }

                if (txtconfirm.Text.Trim() != txtpassword.Text.Trim() && chkedit.Checked)
                {
                    Helpers.SetRedbox(txtconfirm);
                    Helpers.SetRedbox(txtpassword);
                    Helpers.ShowMsg("Password Not Match");
                    return;
                }

                string columns = " [fullname], [username], [role_id]";
                columns += chkedit.Checked ? ",[password]" : ",[status]";
                Database.Update("tbl_user", "where id="+row.Cells["id"].Value,columns, txtfullname.Text.Trim(), txtusername.Text.Trim(), cbrole.SelectedIndex,chkedit.Checked? txtpassword.Text.Trim() : row.Cells["status"].Value);
                chkedit.Visible = false;
                chkedit.Checked = true;
                btnedit.Text = "Edit";
                refresh();
            }
            else
            {
                if (dguser.SelectedRows.Count <= 0)
                {
                    Helpers.ShowMsg("No rows Selected");
                    return;
                }

                row = dguser.SelectedRows[0];

                if (row.Cells["status"].Value.ToString() != "enable")
                {
                    Helpers.ShowMsg("User is Login in , Cannot Change");
                    return;
                }

                txtfullname.Text = row.Cells["fullname"].Value+"";
                txtpassword.Text = row.Cells["password"].Value + "";
                txtconfirm.Text = row.Cells["password"].Value + "";
                txtusername.Text = row.Cells["username"].Value + "";
                cbrole.SelectedIndex = int.Parse(row.Cells["role_id"].Value + "");

                chkedit.Visible = true;
                btnedit.Text = "Update";
               
            }

        }

        private void Chkedit_CheckStateChanged(object sender, System.EventArgs e)
        {
            txtpassword.Enabled = chkedit.Checked;
            txtconfirm.Enabled = chkedit.Checked;
        }

        private void Btnremove_Click(object sender, System.EventArgs e)
        {
            if (dguser.SelectedRows.Count <= 0)
            {
                Helpers.ShowMsg("No Row Select");
                return;
            }
            DataGridViewRow selectedrow = dguser.SelectedRows[0];

            if (selectedrow.Cells["status"].Value.ToString() != "enable")
            {
                Helpers.ShowMsg("User is Login in , Cannot Delete");
                return;
            }
            Database.Update("tbl_user", "where id=" + selectedrow.Cells["id"].Value, "status", "disable");
            //Database.Delete("tbl_user", " where id="+selectedrow.Cells["id"].Value+"");
            refresh();
        }

       
        private void Btninsert_Click(object sender, System.EventArgs e)
        {
            Helpers.ClearRedline(this);

            if (!Helpers.checkRequire(txtconfirm, txtfullname, txtpassword, txtusername))
            {
                return;
            }

            if (txtconfirm.Text.Trim()!=txtpassword.Text.Trim())
            {
                Helpers.SetRedbox(txtconfirm);
                Helpers.SetRedbox(txtpassword);
                Helpers.ShowMsg("Password Not Match");
                return;
            }

            string columns = " [fullname], [username], [password], [role_id]";
            Database.Insert("tbl_user", columns, txtfullname.Text.Trim(), txtusername.Text.Trim(), txtpassword.Text.Trim(), cbrole.SelectedIndex);
            refresh();
        }

        private void refresh()
        {
            txtusername.Text = "";
            txtpassword.Clear();
            txtfullname.Clear();
            txtconfirm.Clear();

            cbrole.SelectedIndex = 0;
            ReloadView();
        }

        private void ReloadView()
        {
            dguser.DataSource = null;
            dguser.DataSource = Database.QueryModel("select [id], [fullname], [username], [password], [role_id], [created_at], [status] from tbl_user where status='enable'");
            dguser.Columns["password"].Visible = false;
        }
    }
}