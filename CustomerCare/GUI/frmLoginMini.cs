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
using MetroFramework.Fonts;
using MetroFramework.Forms;
using SMLOGX.Core;

namespace CustomerCare.GUI
{
    public partial class frmLoginMini : MetroForm
    {
        public frmLoginMini()
        {
            InitializeComponent();
            txtPassword.KeyPress += new KeyPressEventHandler(txtPassword_KeyPress);
            txtUsername.KeyPress += new KeyPressEventHandler(txtUsername_KeyPress);
        }

        private void lbDBSetting_Click(object sender, EventArgs e)
        {
            new frmChangeConnection().ShowDialog();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            Database.Open();
            string[] user = { txtUsername.Text, txtPassword.Text };
            object userID = 0;
            Database.User.Table = "tbl_user";
            Database.User.Username = user[0];
            Database.User.Password = user[1];

            if (Database.User.Login(ref userID))
            {
                Temp.logger_id = int.Parse(userID + "");
                Temp.logger_fullname = Database.QueryScalar("SELECT name FROM viewUsers WHERE id = " + Temp.logger_id) + "";
                new frmMain().Show();
                Temp.frm_login = this;
                this.Hide();
            }
            else
            {
                MetroMessageBox.Show(this,"Please try to login again!");
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtPassword.Focus();
            if (e.KeyChar == 27)
            {
                txtPassword.Text = "";
                txtUsername.Text = "";
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
                btnSignin_Click(null, null);
            if (e.KeyChar == 27)
            {
                txtPassword.Text = "";
                txtUsername.Text = "";
            }
        }

        private void frmLoginMini_FormClosed(object sender, FormClosedEventArgs e)
        {
            App.ExitAll();
        }
    }
}
