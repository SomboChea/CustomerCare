using CustomerCare.STR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerCare.GUI
{
    public partial class frmQuickLuanch : Form
    {
        public frmQuickLuanch()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnHCP_MouseEnter(object sender, EventArgs e)
        {
            btnHCP.BackColor = Color.DeepPink;
        }

        private void btnHCP_MouseLeave(object sender, EventArgs e)
        {
            btnHCP.BackColor = Color.DodgerBlue;
        }

        private void btnRetail_MouseEnter(object sender, EventArgs e)
        {
            btnRetail.BackColor = Color.DeepPink;
        }

        private void btnRetail_MouseLeave(object sender, EventArgs e)
        {
            btnRetail.BackColor = Color.DodgerBlue;
        }

        private void btnMom_MouseEnter(object sender, EventArgs e)
        {
            btnMom.BackColor = Color.DeepPink;
        }

        private void btnMom_MouseLeave(object sender, EventArgs e)
        {
            btnMom.BackColor = Color.DodgerBlue;
        }

        private void btnKid_MouseEnter(object sender, EventArgs e)
        {
            btnKid.BackColor = Color.DeepPink;
        }

        private void btnKid_MouseLeave(object sender, EventArgs e)
        {
            btnKid.BackColor = Color.DodgerBlue;
        }

        private void btnCallQueue_MouseEnter(object sender, EventArgs e)
        {
            btnCallQueue.BackColor = Color.DeepPink;
        }

        private void btnCallQueue_MouseLeave(object sender, EventArgs e)
        {
            btnCallQueue.BackColor = Color.DodgerBlue;
        }

        private void btnStaff_MouseEnter(object sender, EventArgs e)
        {
            btnStaff.BackColor = Color.DeepPink;
        }

        private void btnStaff_MouseLeave(object sender, EventArgs e)
        {
            btnStaff.BackColor = Color.DodgerBlue;
        }

        private void btnLocation_MouseEnter(object sender, EventArgs e)
        {
            btnLocation.BackColor = Color.DeepPink;
        }

        private void btnLocation_MouseLeave(object sender, EventArgs e)
        {
            btnLocation.BackColor = Color.DodgerBlue;
        }

        private void btnUser_MouseEnter(object sender, EventArgs e)
        {
            btnUser.BackColor = Color.DeepPink;
        }

        private void btnUser_MouseLeave(object sender, EventArgs e)
        {
            btnUser.BackColor = Color.DodgerBlue;
        }

        private void btnSetting_MouseEnter(object sender, EventArgs e)
        {
            btnSetting.BackColor = Color.DeepPink;
        }

        private void btnSetting_MouseLeave(object sender, EventArgs e)
        {
            btnSetting.BackColor = Color.DodgerBlue;
        }

        private void frmQuickLuanch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Hide();
        }

        private void clickSpace(int idx)
        {
            Hide();
            switch (idx)
            {
                case 0:
                    Temp.frm_hcp.ShowDialog();
                    break;

                case 1:
                    Temp.frm_retail.ShowDialog();
                    break;

                case 3:
                    Temp.frm_mom.ShowDialog();
                    break;
            }
        }

        private void btnHCP_Click(object sender, EventArgs e)
        {
            clickSpace(0);
        }

        private void btnRetail_Click(object sender, EventArgs e)
        {
            clickSpace(1);
        }

        private void btnMom_Click(object sender, EventArgs e)
        {
            clickSpace(2);
        }

        private void btnKid_Click(object sender, EventArgs e)
        {
            clickSpace(3);
        }

        private void btnCallQueue_Click(object sender, EventArgs e)
        {
            clickSpace(4);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            clickSpace(5);
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            clickSpace(6);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            clickSpace(7);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            clickSpace(8);
        }
    }
}