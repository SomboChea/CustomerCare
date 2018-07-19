using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using SMLOGX.Core;

namespace CustomerCare.GUI
{
    public partial class frmChangeConnection : MetroForm
    {
        public frmChangeConnection()
        {
            InitializeComponent();
            CheckAuthHasUser();
            Database.Open();
            loadSetting();
        }

        private string[] sections = { "Windows Authentication", "SQL Server Authentication" };
        private MParser setting = new MParser("config.db");

        private void loadSetting()
        {
            txtHost.Text = Database.Server;
            cbAuthType.SelectedIndex = Database.AuthType ? 1 : 0;
            txtUsername.Text = Database.UserId;
            txtPassword.Text = Database.Password;
            
        }

        private void CheckUp()
        {
            CheckAuthHasUser();
            Database.GetConfigDB(panUser.Visible);
            loadSetting();
        }

        private void cbAuthType_SelectedIndexChanged(object sender, EventArgs e) => CheckUp();

        private void CheckAuthHasUser() => PanButtonMoveUpDown(panUser.Visible = PanUserIsShow());

        private bool PanUserIsShow() => cbAuthType.SelectedIndex.Equals(1);

        private void PanButtonMoveUpDown(bool tf) =>
            // UP is a false
            // DOWN is true
            panButton.Location = new Point(panButton.Location.X, !tf ? 320 : 430);

        private void btnTest_Click(object sender, EventArgs e)
        {
            Config config = new Config
            {
                Server = txtHost.Text,
                DBName = "telmarketing"
            };

            bool isAuth = false;
            if (cbAuthType.SelectedIndex == 1)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save(cbAuthType.SelectedIndex == 1);
        }

        private void Save(bool auth)
        {
            try
            {
                Database.Server = txtHost.Text;
                Database.DBName = "telmarketing";

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

    }

}
