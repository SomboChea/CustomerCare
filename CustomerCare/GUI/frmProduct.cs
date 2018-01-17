using SMLOGX.Core;
using System;
using System.Windows.Forms;

namespace CustomerCare.GUI
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
            Database.Server = "smlogx";
            Database.DBName = "CustomerCare";
            Database.Open();
            Helpers.FillComboBox(cbCategory, "cate_name", "cate_id", "SELECT * FROM tbl_category");
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.txtValue.Text;
            string desc = txtDesc.Text;
            int.TryParse(cbCategory.SelectedValue.ToString(), out int cate_id);

            if (Database.Insert("tbl_product", "pro_name,description,cate_id", name, desc, cate_id))
                MessageBox.Show("Inserted");
        }
    }
}