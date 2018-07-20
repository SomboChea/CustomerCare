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
    public partial class frmNewSource : MetroForm
    {
        public frmNewSource()
        {
            InitializeComponent();
        }

        private string  SourceID { get; set; }
        public frmNewSource(string _sourceID,DataGridViewCellCollection cell)
        {
            InitializeComponent();
            this.Text = "Edit Source";
            SourceID = _sourceID;
        }

        private void frmNewSource_Load(object sender, EventArgs e)
        {
            cbProvince.DataSource = null;
            Helpers.FillComboBox(cbProvince, "name", "id", "Select * from locations where master_id='0'");
            Helpers.FillComboBox(cbType, "type", "id", "SELECT id, type FROM tbl_refer_type");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name, owner, tel_1, tel_2, email, type, memo;
            string province, district, commune, other;
            
            province = cbProvince.Text;
            district = cbDistrict.Text;
            commune = cbCommune.Text;
            other = txtAddress.Text;

            string address_id = Database.QueryScalar("EXEC insertLocation '" +province+ "','" +district+ "','" +commune+ "','"+other+"'") + "";
            string type_id = cbType.SelectedValue + "";

            name = txtName.Text;
            owner = txtOwner.Text;
            tel_1 = txtTel1.Text;
            tel_2 = txtTel2.Text;
            email = txtEmail.Text;
            type = cbType.Text;
            memo = txtMemo.Text;

            string id;
            if (SourceID == null)
            {
                 id = Database.QueryScalar("EXEC insertSource '" +
                    name + "','" + owner + "','" + tel_1 + "','" + tel_2 +
                    "','" + email + "','" + memo + "',null,'" + address_id +
                    "','" + type_id + "','" + Temp.logger_id + "'") + "";
            }
            else
            {
                string source_name_id = Database.GetName_ID(name, "1");
                string source_owner_id= Database.GetName_ID(name, "2");
                string col= "[name_id], [owner_id], [tel_1], [tel_2], [email], [memo], [image], [address_id], [type_id], [logger_id]";
                id=Database.Update("tbl_refer", " Where id=" + SourceID,col,source_name_id,source_owner_id,tel_1,tel_2,email,memo,address_id,type_id,Temp.logger_id)?"not null":null;
            }
            string success = id != null ? "Success" : "Failed";
            MetroMessageBox.Show(this, success);
        }

        private bool LocationIsContained(ComboBox cb) => Database.QueryScalar("SELECT id FROM locations WHERE id = '" +
                cb.SelectedValue + "'") !=null;

        private void cbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDistrict.DataSource = null;
            cbCommune.DataSource = null;
            Helpers.FillComboBox(cbDistrict, "name", "id", "Select * from locations where master_id='" + cbProvince.SelectedValue+"'");
        }

        private void cbDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCommune.DataSource = null;
            Helpers.FillComboBox(cbCommune, "name", "id", "Select * from locations where master_id='" + cbDistrict.SelectedValue+"'");
        }
    }
}
