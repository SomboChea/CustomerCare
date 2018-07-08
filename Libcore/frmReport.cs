using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMLOGX
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void viewreport_Load(object sender, EventArgs e)
        {
            
        }

        public  CrystalReportViewer getviewer()
        {
            return viewreport;
        }
    }

}
