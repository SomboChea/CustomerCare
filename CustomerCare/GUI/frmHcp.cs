using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerCare
{
    public partial class frmHcp : Form
    {
        public frmHcp()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string owner = txtOwner.Text;

            string location = txtLocation.Text;
            string dist = txtDist.Text;
            string comm = txtComm.Text;

            string[] tels = { txtTel1.Text, txtTel2.Text };
            string email = txtEmail.Text;
            string fb = txtFB.Text;
            string memo = txtMemo.Text;
        }
    }
}