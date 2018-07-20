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
using SMLOGX.Core;

namespace CustomerCare.GUI
{
    public partial class frmCustomerQuickAdd : MetroForm
    {
        public frmCustomerQuickAdd()
        {
            InitializeComponent();
            Helpers.FillComboBox(cbFromSource,"name", "id","SELECT id,name FROM viewSources");
            Helpers.FillComboBox(cbSourceType, "type", "id", "SELECT id,type FROM tbl_refer_type");
        }

        private bool SourceIsContained() => 
            Database.QueryScalar("SELECT id FROM viewSources WHERE id = '" + 
                cbFromSource.SelectedValue + "'") != null;

        private void PanInfoMoveUpDown(bool tf) =>
            //UP is false
            //DOWN is true
            panInfo.Location = new Point(panInfo.Location.X, tf ? (panType.Location.Y + panType.Height) : panType.Location.Y - panType.Height + panInfo.Height);

        private bool PanTypeIsShow() => !SourceIsContained();

        private void CheckingSource() => PanInfoMoveUpDown(panType.Visible = PanTypeIsShow());

        private string CheckSourceAdd() => 
            SourceIsContained() ? 
            cbFromSource.SelectedValue + "" : 
            Database.QueryScalar("EXEC insertQuickSource '" +
                cbFromSource.Text + "'," + cbSourceType.SelectedValue + "," +
                Temp.logger_id) + "";

        Mom mom = new Mom();

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show(panInfo.Height + "");
            MessageBox.Show(panInfo.Location.Y + "");
            MessageBox.Show(panType.Location.Y + "");
            return;
            mom.Name = txtName.Text;
            mom.Tel_1 = txtTel1.Text;
            mom.Other = txtInfo.Text;
            mom.Refer_Id = CheckSourceAdd();

            mom.Id = Database.QueryScalar("EXEC insertQuickCustomer '" + mom.Name + "','" + mom.Tel_1 + "','" + mom.Other + "'," + mom.Refer_Id + "," + Temp.logger_id)+"";

            if (chkHasKid.Checked)
                PopUpAddKid();
            else
            {
                string sss = mom.Id != null ? "Success" : "Failed";
                MetroMessageBox.Show(this, sss);
            }
        }

        private void PopUpAddKid() => new frmCustomerDetail(mom.Id, mom.Name, mom.Tel_1, null).ShowDialog();

        private void cbFromSource_SelectedIndexChanged(object sender, EventArgs e) => CheckingSource();

        private void cbFromSource_KeyPress(object sender, KeyPressEventArgs e) => CheckingSource();

    }
}
