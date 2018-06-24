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
    public partial class frmLocations : Form
    {
        public frmLocations()
        {
            InitializeComponent();
            FullMode.Fullscreen(this);
        }

        private ComboBox cbpro, cbdis, cbcomm;
        private void init()
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
