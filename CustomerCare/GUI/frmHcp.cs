using SMLOGX.Core;
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

        private int id = 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            id++;
            string[] hcpIdentity = { txtName.Text, txtOwner.Text };
            string[] address = { txtLocation.Text, txtDist.Text, txtComm.Text, txtST.Text };
            string[] tels = { txtTel1.Text, txtTel2.Text };
            string[] econtact = { txtEmail.Text, txtFB.Text };
            string memo = txtMemo.Text;

            dgView.Rows.Add(id, hcpIdentity[0], hcpIdentity[1], address[0], address[1], address[2], address[3], tels[0], tels[1], econtact[0], econtact[1], memo);
            Database.Insert();
        }
    }
}