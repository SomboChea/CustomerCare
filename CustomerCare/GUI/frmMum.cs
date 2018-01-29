using SMLOGX.Core;
using System;
using System.Windows.Forms;

namespace CustomerCare
{
    public partial class frmMum : Form
    {
        public frmMum()
        {
            InitializeComponent();
        }

        private void picClose_Click(object sender, System.EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            string name = txtName.Text;
            string[] dates = { dateRec.Text, dateEpt.Text };
            string[] tels = { txtTel1.Text, txtTel2.Text, txtTel3.Text };
            string[] econtact = { txtEmail.Text, txtFB.Text };
            string location = txtMomLocation.Text;
        }

        private void btnAddKid_Click(object sender, EventArgs e)
        {
            new frmKid().ShowDialog();
        }
    }
}