using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomerCare.GUI.BETA
{
    public partial class frmCallDetail : Form
    {
        public frmCallDetail(string from_code)
        {
            InitializeComponent();
            this.lbCode.Text += from_code;
            this.panTitle.Size = new Size(lbCode.Width + 10, panTitle.Height);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}