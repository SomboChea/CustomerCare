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
    public partial class frmChangeConnection : MetroForm
    {
        public frmChangeConnection()
        {
            InitializeComponent();
            CheckAuthHasUser();
        }

        private void cbAuthType_SelectedIndexChanged(object sender, EventArgs e) => CheckAuthHasUser();

        private void CheckAuthHasUser() => PanButtonMoveUpDown(panUser.Visible = PanUserIsShow());

        private bool PanUserIsShow() => cbAuthType.SelectedIndex.Equals(1);

        private void PanButtonMoveUpDown(bool tf) =>
            // UP is a false
            // DOWN is true
            panButton.Location = new Point(panButton.Location.X, !tf ? 320 : 430);

        private void btnTest_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
