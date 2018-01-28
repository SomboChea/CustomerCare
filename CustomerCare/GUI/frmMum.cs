using SMLOGX.Core;
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
    }
}