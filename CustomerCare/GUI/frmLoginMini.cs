using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Fonts;
using MetroFramework.Forms;

namespace CustomerCare.GUI
{
    public partial class frmLoginMini : MetroForm
    {
        public frmLoginMini()
        {
            InitializeComponent();

        }

        private void lbDBSetting_Click(object sender, EventArgs e)
        {
            new frmChangeConnection().ShowDialog();
        }
    }
}
