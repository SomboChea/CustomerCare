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
using MetroFramework.Forms;

namespace CustomerCare.GUI
{
    public partial class frmNewCustomer : MetroForm
    {
        public frmNewCustomer()
        {
            InitializeComponent();
        }

        private void chkHaveKid_CheckedChanged(object sender, EventArgs e)
        {
            MoveContactUpDown(PanExpectedIsShow());
        }

        private bool PanExpectedIsShow() => panExpected.Visible = !chkHaveKid.Checked;

        private void MoveContactUpDown(bool tf) =>
            //UP is false
            //DOWN is true
            panContact.Location = new Point(panContact.Location.X, tf ? 270 : 230);

        private void selectSource_Click(object sender, EventArgs e)
        {
            new frmSelectSource().ShowDialog();
        }
    }
}
