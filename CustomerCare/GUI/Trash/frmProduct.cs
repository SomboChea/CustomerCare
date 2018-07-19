using SMLOGX.Core;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomerCare
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
            cbProductOwner.SelectedIndex = 0;
            Database.Open();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.txtValue.Text.Trim();
            string desc = txtDesc.Text.Trim();
            if (Database.Insert("tbl_product", "name,description,owner,level", name, desc, cbProductOwner.SelectedIndex, txtLevel.txtValue.Text))
                MessageBox.Show("Inserted");
            else
                MessageBox.Show("Can't Insert!");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_MouseDown(object sender, MouseEventArgs e)
        {
            btnClose.BackColor = Color.Crimson;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = panHead.BackColor;
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Crimson;
        }
    }
}