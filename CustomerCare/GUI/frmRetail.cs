using CustomerCare.STR;
using System.Drawing;
using System.Windows.Forms;
using static CustomerCare.frmSources;

namespace CustomerCare
{
    public partial class frmRetail : Form
    {
        public frmRetail()
        {
            InitializeComponent();
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

        private void picLogo_Click(object sender, System.EventArgs e)
        {
            Temp.frm_luanch.ShowDialog();
        }
    }
}