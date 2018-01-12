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
        }

        private void loadRoles()
        {
            listRoles.Items.Clear();
            DataTable roles = Database.QueryModel("SELECT * FROM tbl_pos");
            foreach (DataRow row in roles.Rows)
                listRoles.Items.Add(row["pos_en"]);
        }

        private void loadOptions(string position = "")
        {
            checkedListOptions.Items.Clear();
            DataTable admin = Database.QueryModel("SELECT * FROM viewRoleAccessOptions WHERE pos_en = '" + position + "'");
            DataTable all = Database.QueryModel("SELECT * FROM tbl_options");
            bool isCheck = false;
            List<Options> list = new List<Options>();

            foreach (DataRow temp in all.Rows)
            {
                foreach (DataRow temp2 in admin.Rows)
                {
                    isCheck = temp["option_name"].Equals(temp2["option_name"]);
                    if (isCheck)
                    {
                        list.Add(new Options()
                        {
                            option_id = int.Parse(temp["option_id"] + ""),
                            option_name = temp["option_name"] + ""
                        });

                        admin.Rows.Remove(temp2);
                        break;
                    }
                }

                checkedListOptions.Items.Add(temp["option_name"], isCheck);
                isCheck = false;
            }
        }

        private void frmPosition_Load(object sender, EventArgs e)
        {
            Database.Server = "localhost";
            Database.DBName = "CustomerCare";
            Database.Open();

            loadRoles();
            loadOptions();
        }

        private void listRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadOptions(listRoles.SelectedItem.ToString());
        }
    }
}