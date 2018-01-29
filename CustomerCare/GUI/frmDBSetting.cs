using SMLOGX.Core;
using System;
using System.Collections.Generic;
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
            loadSetting();
        }

        private void loadSetting()
        {
            txtServer.Text = Database.Server;
            cbAuth.SelectedIndex = Database.AuthType ? 1 : 0;
            txtUsername.Text = Database.UserId;
            txtPassword.Text = Database.Password;
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
            Config config = new Config
            {
                Server = txtServer.Text,
                DBName = "CustomerCare"
            };

            bool isAuth = false;
            if (cbAuth.SelectedIndex == 1)
            {
                config.UserId = txtUsername.Text;
                config.Password = txtPassword.Text;
                isAuth = true;
            }

            if (Database.Test(config, isAuth))
                MessageBox.Show("Connection Successful!", "Connection Testing", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else
                MessageBox.Show("Connection Failed!", "Connection Testing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Save(bool auth)
        {
            try
            {
                Database.Server = txtServer.Text;
                Database.DBName = "CustomerCare";

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