using CustomerCare.STR;
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

namespace CustomerCare.GUI
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
            DataTable roles = Database.QueryModel("SELECT * FROM tbl_pos");
            foreach (DataRow row in roles.Rows)
                listRoles.Items.Add(row["pos_en"]);
        }

        private List<Options> all_options = new List<Options>();

        private List<Options> list = new List<Options>();

        private void loadAllOptions()
        {
            DataTable all = Database.QueryModel("SELECT * FROM tbl_options");
            foreach (DataRow temp in all.Rows)
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
            list.Clear();
            DataTable admin = Database.QueryModel("SELECT * FROM viewRoleAccessOptions WHERE pos_en = '" + position + "'");
            bool isCheck = false;

            foreach (Options temp in all_options)
            {
                foreach (DataRow temp2 in admin.Rows)
                {
                    isCheck = temp.option_name.Equals(temp2["option_name"]);
                    if (isCheck)
                    {
                        list.Add(new Options()
                        {
                            option_id = int.Parse(temp.option_id + ""),
                            option_name = temp.option_name + ""
                        });

                        admin.Rows.Remove(temp2);
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

        private void listRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadOptions(listRoles.SelectedItem.ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Save();
        }

        private List<Options> getChecked()
        {
            //List<Options> list = new List<Options>();
            //foreach (string )
            //{
            //    list.Add(new Options()
            //    {
            //    });
            //}
            return list;
        }

        private void Save()
        {
            Database.Insert("tbl_pos", "pos_en", txtPosition.txtValue.Text);
            foreach (Options temp in list)
            {
                Database.Insert("tbl_access_options", "pos_id, option_id", Database.GetLastId("tbl_pos") + "," + temp.option_id);
            }

            MessageBox.Show("Successfully!");
            loadRoles();
            loadOptions();
        }

        private void checkedListOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}