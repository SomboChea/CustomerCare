using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerCare.STR;
using MetroFramework;
using MetroFramework.Forms;

namespace CustomerCare.GUI
{
    public partial class frmMain : MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
            this.Text = "Welcome - " + Temp.logger_fullname;
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            new frmLoginMini().Show();
            
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            new frmCustomer().Show();
            this.Dispose();
        }

        private void btnSource_Click(object sender, EventArgs e)
        {
            new frmSource().Show();
            this.Dispose();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            //new frmProduct().Show();
            this.Dispose();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            new FrmUser().Show();
            this.Dispose();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            new frmReports().Show();
            this.Dispose();
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            new frmLocations().ShowDialog();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            new frmSettings().ShowDialog();
        }
    }
}
