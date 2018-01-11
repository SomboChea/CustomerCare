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

namespace CustomerCare
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtPassword.txtValue.PasswordChar = '*';
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            App.ExitAll();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Database.Open();
            string[] user = { txtUsername.Value, txtPassword.Value };
            object userID = 0;
            Database.User.Table = "tbl_users";
            Database.User.Username = user[0];
            Database.User.Password = user[1];

            if (Database.User.Login(ref userID) || 1 == 1)
            {
                //MessageBox.Show("User ID: " + userID + " - Login Successfully!");
                new frmMain().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please try to login again!");
            }
        }

        private bool showPass = false;

        private void btnShowHide_Click(object sender, EventArgs e)
        {
            showPass = !showPass;
            txtPassword.txtValue.PasswordChar = showPass ? '\0' : '*';
            btnShowHide.Text = showPass ? "H" : "V";
        }
    }
}