using CustomerCare.STR;
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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            FullMode.Fullscreen(this);
            lbTitle.Text = "Welcome, " + Temp.logger_fullname + " - Dashboard";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new frmLogin().Show();
            
        }

        private void btnViewAlert_Click(object sender, EventArgs e)
        {
            new GUI.BETA.frmCallQueue().ShowDialog();
        }

        private void btnNewMom_Click(object sender, EventArgs e)
        {
            new frmMum().ShowDialog();
        }

        private void frmNewSource_Click(object sender, EventArgs e)
        {
            new frmSources().ShowDialog();
        }

        private void btnLocations_Click(object sender, EventArgs e)
        {
            new frmLocations().ShowDialog();
        }
    }
}
