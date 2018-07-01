using SMLOGX.Core;
using System.Windows.Forms;

namespace CustomerCare
{
    public partial class frmUser : Form
    {
        TextBox txtusername, txtpassword, txtconfirm, txtfullname;
        Button btninsert,btnclose,btnremove;
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

            btnremove.Click += Btnremove_Click;
            btninsert.Click += Btninsert_Click;
            dguser.SelectionChanged += Dguser_SelectionChanged;
        }

        private void Btnremove_Click(object sender, System.EventArgs e)
        {
            if (dguser.SelectedRows.Count <= 0)
            {
                Helpers.ShowMsg("No Row Select");
                return;
            }
            DataGridViewRow selectedrow = dguser.SelectedRows[0];
            Database.Delete("tbl_user", selectedrow.Cells["id"].Value+"","id");
            refresh();
        }

        private void Dguser_SelectionChanged(object sender, System.EventArgs e)
        {
           
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
            Database.Insert("tbl_user", columns, txtfullname.Text.Trim(), txtusername.Text.Trim(), txtpassword.Text.Trim(), cbrole.SelectedValue);
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
            dguser.DataSource = Database.QueryModel("select [id], [fullname], [username], [password], [role_id], [created_at], [status] from tbl_user where status=1");
        }
    }
}