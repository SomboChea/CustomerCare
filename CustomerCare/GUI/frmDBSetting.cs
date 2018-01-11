using SMLOGX.Core;
using System;
using System.Windows.Forms;

namespace CustomerCare
{
    public partial class frmDBSetting : Form
    {
        private string[] sections = { "Windows Authentication", "SQL Server Authentication" };
        private MParser setting = new MParser("config.db");

        public frmDBSetting()
        {
            InitializeComponent();
            Database.Open();

            Database.Close();
            loadSetting();
        }

        private void loadSetting()
        {
            txtServer.Text = Database.Server;
            cbAuth.SelectedIndex = Database.AuthType ? 1 : 0;
            txtUsername.Text = Database.UserId;
            txtPassword.Text = Database.Password;

            if (Database.HasOpen)
            {
                Helpers.FillComboBox(cbDB, "name", "name", "SELECT name FROM [master].[sys].[databases];");
                if (!Database.DBName.Equals(""))
                    cbDB.SelectedValue = Database.DBName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save(cbAuth.SelectedIndex == 1);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Database.Server = txtServer.Text;
            Database.DBName = cbDB.SelectedValue + "";

            if (cbAuth.SelectedIndex == 1)
            {
                Database.UserId = txtUsername.Text;
                Database.Password = txtPassword.Text;
            }

            Database.Open(cbAuth.SelectedIndex == 1);

            if (Database.HasOpen)
            {
                MessageBox.Show("Tested");
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }

        private void Save(bool auth)
        {
            try
            {
                Database.Server = txtServer.Text;
                Database.DBName = cbDB.SelectedValue + "";

                Database.UserId = txtUsername.Text;
                Database.Password = txtPassword.Text;

                if (Database.SetConfigDB(auth))
                    MessageBox.Show("Saved!");
                return;
            }
            catch (Exception ex)
            {
                Log.Write(ex.Message, "frmDBSetting.save");
            }
        }

        private void cbAuth_SelectedIndexChanged(object sender, EventArgs e)
        {
            panUser.Enabled = cbAuth.SelectedIndex == 1;
            Database.GetConfigDB(panUser.Enabled);
            loadSetting();
        }
    }
}