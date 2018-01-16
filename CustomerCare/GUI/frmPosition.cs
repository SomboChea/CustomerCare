using CustomerCare.STR;
using SMLOGX.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CustomerCare
{
    public partial class frmPosition : Form
    {
        public frmPosition()
        {
            InitializeComponent();

            Database.Server = "localhost";
            Database.DBName = "CustomerCare";
            Database.Open();

            loadAllOptions();
        }

        private void loadRoles()
        {
            listRoles.Items.Clear();
            foreach (DataRow row in Database.QueryModel("SELECT * FROM tbl_pos").Rows)
                listRoles.Items.Add(row["pos_en"]);
        }

        private List<Options> all_options = new List<Options>();

        private List<Options> temp_options = new List<Options>();

        private void loadAllOptions()
        {
            foreach (DataRow temp in Database.QueryModel("SELECT * FROM tbl_options").Rows)
            {
                all_options.Add(new Options()
                {
                    option_id = int.Parse(temp["option_id"] + ""),
                    option_name = temp["option_name"] + ""
                });
            }
        }

        private void loadOptions(string position = "")
        {
            checkedListOptions.Items.Clear();
            temp_options.Clear();

            DataTable accessor = Database.QueryModel("SELECT * FROM viewRoleAccessOptions WHERE pos_en = '" + position + "'");
            bool isCheck = false;

            foreach (Options temp in all_options)
            {
                foreach (DataRow temp2 in accessor.Rows)
                {
                    isCheck = temp.option_name.Equals(temp2["option_name"]);
                    if (isCheck)
                    {
                        accessor.Rows.Remove(temp2);
                        break;
                    }
                }

                checkedListOptions.Items.Add(temp.option_name, isCheck);
                isCheck = false;
            }
        }

        private void frmPosition_Load(object sender, EventArgs e)
        {
            loadRoles();
            loadOptions();
        }

        private DialogResult rex;

        private void listRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string rolename = listRoles.SelectedItem.ToString();
            loadOptions(rolename);
            rex = MessageBox.Show("Do you want to update: " + rolename + "?", "Editing Role", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (rex.Equals(DialogResult.Yes))
                txtPosition.txtValue.Text = rolename;
            else
                txtPosition.txtValue.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text.Equals("Update"))
            {
            }
            else
            {
                Save();
            }
        }

        private void getChecked()
        {
            temp_options.Clear();
            int id;
            foreach (string temp in checkedListOptions.CheckedItems)
            {
                id = int.Parse(Database.QueryScalar("SELECT * FROM tbl_options WHERE option_name = '" + temp + "'") + "");
                temp_options.Add(new Options()
                {
                    option_id = id,
                    option_name = temp + ""
                });
            }
        }

        private void Update(string position)
        {
            getChecked();
        }

        private void Save()
        {
            getChecked();
            Database.Insert("tbl_pos", "pos_en", txtPosition.txtValue.Text);
            foreach (Options temp in temp_options)
                Database.Insert("tbl_access_options", "pos_id, option_id", Database.GetLastId("tbl_pos") + "," + temp.option_id);

            MessageBox.Show("Successfully!");
            txtPosition.txtValue.Clear();
            loadRoles();
            loadOptions();
        }

        private void checkedListOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdd.Text = "Update";
        }
    }
}