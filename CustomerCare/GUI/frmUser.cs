using SMLOGX.Core;
using System.Windows.Forms;

namespace CustomerCare
{
    public partial class frmUser : Form
    {
        TextBox txtusername, txtpassword, txtconfirm, txtfullname;
        Button btninsert,btnclose;
        ComboBox cbrole;

        public frmUser()
        {
            InitializeComponent();

            init();
            

        }

        public void init()
        {
            txtusername = tfusername;
            txtconfirm = tfcon;
            txtfullname = tffullname;
            txtpassword = tfpass;
            btninsert = butadd;

            btninsert.Click += Btninsert_Click;
        }
        
        private void Btninsert_Click(object sender, System.EventArgs e)
        {


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

        }
    }
}