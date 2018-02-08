using CustomerCare.STR;
using System.Drawing;
using System.Windows.Forms;
using static CustomerCare.frmHcp;

namespace CustomerCare
{
    public partial class frmRetail : Form
    {
        public frmRetail()
        {
            InitializeComponent();
            cblocation.DataSource = null;
            helper.FillComboBox(cblocation, "pc_name", "pc_id", "Select * from tbl_provinces");
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Hide();
        }

        private void btnClose_MouseLeave(object sender, System.EventArgs e)
        {
            btnClose.BackColor = panHead.BackColor;
        }

        private void btnClose_MouseEnter(object sender, System.EventArgs e)
        {
            btnClose.BackColor = Color.Crimson;
        }

        private void btnClose_MouseDown(object sender, MouseEventArgs e)
        {
            btnClose.BackColor = Color.Crimson;
        }

        private void cbdistrict_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            cbcommune.DataSource = null;
            helper.FillComboBox(cbcommune, "sk_name", "sk_id", "Select * from tbl_sk where ks_id=" + cbdistrict.SelectedValue);
        }

        private void cblocation_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            cbdistrict.DataSource = null;
            cbcommune.DataSource = null;
            helper.FillComboBox(cbdistrict, "ks_name", "ks_id", "Select * from tbl_ks where pc_id=" + cblocation.SelectedValue);
        }

        private void picLogo_Click(object sender, System.EventArgs e)
        {
            Temp.frm_luanch.ShowDialog();
        }
    }
}