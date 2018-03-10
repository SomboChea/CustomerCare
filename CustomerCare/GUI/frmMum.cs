using CustomerCare.STR;
using SMLOGX.Core;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomerCare
{
    public partial class frmMum : Form
    {
        public frmMum()
        {
            InitializeComponent();

            Function.FillComboBox(cbTypeOf, "type", "id", "SELECT * FROM tbl_refer_type");
            Function.FillComboBox(cbNames, "name", "id", "SELECT * FROM tbl_name");
            Function.SetCombo(cbProvince, cbDistrict, cbCommune, txtAddress);
        }

        private void picClose_Click(object sender, System.EventArgs e)
        {
            this.Hide();
        }
        
        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            string name_id = cbNames.SelectedValue+"";
            string dates = dateEpt.Value.ToShortDateString();
            string[] tels = { txtTel1.Text, txtTel2.Text};
            string[] econtact = { txtEmail.Text, txtFB.Text };
            string location_id = Function.AddAddress();
            string refer_id = cbSources.SelectedValue +"";
            string sql = "EXEC InsertMom " + name_id + ",'" + dates + "','" + tels[0] + "','" + tels[1] + "','" + econtact[0] + "','" + econtact[1] + "'," + Temp.logger_id + "," + refer_id + "," + location_id;
            if (Database.Exec(sql))
                MessageBox.Show("Success");
            else
                MessageBox.Show("Failed");
        }

        private void btnAddKid_Click(object sender, EventArgs e)
        {
            new frmKid().ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Crimson;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = panHead.BackColor;
        }
        
        private void cbTypeOf_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSources.DataSource = null;
            Function.FillComboBox(cbSources, "name", "id", "SELECT * FROM viewRefers WHERE type_id = " + cbTypeOf.SelectedValue);
        }
    }
}