﻿namespace CustomerCare.GUI
{
    partial class frmChangeConnection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtHost = new MetroFramework.Controls.MetroTextBox();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbAuthType = new MetroFramework.Controls.MetroComboBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panUser = new MetroFramework.Controls.MetroPanel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnTest = new MetroFramework.Controls.MetroButton();
            this.panButton = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panUser.SuspendLayout();
            this.panButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(300, 0);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 31);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.UseStyleColors = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(65, 123);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(160, 20);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Hostname / IP Address";
            // 
            // txtHost
            // 
            this.txtHost.Lines = new string[0];
            this.txtHost.Location = new System.Drawing.Point(69, 154);
            this.txtHost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHost.MaxLength = 20;
            this.txtHost.Name = "txtHost";
            this.txtHost.PasswordChar = '\0';
            this.txtHost.PromptText = "eg: 127.0.0.1";
            this.txtHost.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHost.SelectedText = "";
            this.txtHost.Size = new System.Drawing.Size(400, 28);
            this.txtHost.TabIndex = 3;
            this.txtHost.UseCustomBackColor = true;
            this.txtHost.UseCustomForeColor = true;
            this.txtHost.UseSelectable = true;
            this.txtHost.UseStyleColors = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Lines = new string[0];
            this.txtUsername.Location = new System.Drawing.Point(8, 36);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.MaxLength = 20;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PromptText = "Username here...";
            this.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(228, 28);
            this.txtUsername.TabIndex = 5;
            this.txtUsername.UseCustomBackColor = true;
            this.txtUsername.UseCustomForeColor = true;
            this.txtUsername.UseSelectable = true;
            this.txtUsername.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(65, 194);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(106, 20);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Authentication";
            // 
            // cbAuthType
            // 
            this.cbAuthType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAuthType.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cbAuthType.FormattingEnabled = true;
            this.cbAuthType.ItemHeight = 21;
            this.cbAuthType.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
            this.cbAuthType.Location = new System.Drawing.Point(69, 222);
            this.cbAuthType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbAuthType.Name = "cbAuthType";
            this.cbAuthType.PromptText = "Choose one ...";
            this.cbAuthType.Size = new System.Drawing.Size(399, 27);
            this.cbAuthType.TabIndex = 6;
            this.cbAuthType.UseSelectable = true;
            this.cbAuthType.SelectedIndexChanged += new System.EventHandler(this.cbAuthType_SelectedIndexChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(8, 106);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PromptText = "Password here...";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(228, 28);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseCustomBackColor = true;
            this.txtPassword.UseCustomForeColor = true;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.UseStyleColors = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroPanel1.Controls.Add(this.pictureBox1);
            this.metroPanel1.Controls.Add(this.panUser);
            this.metroPanel1.Controls.Add(this.cbAuthType);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.txtHost);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 12;
            this.metroPanel1.Location = new System.Drawing.Point(31, 92);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(531, 418);
            this.metroPanel1.TabIndex = 8;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CustomerCare.Properties.Resources.Database_Connection_BL_C;
            this.pictureBox1.Location = new System.Drawing.Point(213, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panUser
            // 
            this.panUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panUser.Controls.Add(this.metroLabel4);
            this.panUser.Controls.Add(this.metroLabel3);
            this.panUser.Controls.Add(this.txtPassword);
            this.panUser.Controls.Add(this.txtUsername);
            this.panUser.HorizontalScrollbarBarColor = true;
            this.panUser.HorizontalScrollbarHighlightOnWheel = false;
            this.panUser.HorizontalScrollbarSize = 12;
            this.panUser.Location = new System.Drawing.Point(69, 267);
            this.panUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panUser.Name = "panUser";
            this.panUser.Size = new System.Drawing.Size(399, 147);
            this.panUser.TabIndex = 9;
            this.panUser.UseCustomBackColor = true;
            this.panUser.UseCustomForeColor = true;
            this.panUser.UseStyleColors = true;
            this.panUser.VerticalScrollbar = true;
            this.panUser.VerticalScrollbarBarColor = true;
            this.panUser.VerticalScrollbarHighlightOnWheel = false;
            this.panUser.VerticalScrollbarSize = 13;
            this.panUser.Visible = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(4, 75);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(70, 20);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Password";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(4, 5);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(75, 20);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Username";
            // 
            // btnTest
            // 
            this.btnTest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTest.Location = new System.Drawing.Point(0, 0);
            this.btnTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(145, 31);
            this.btnTest.TabIndex = 9;
            this.btnTest.Text = "Test connection";
            this.btnTest.UseCustomBackColor = true;
            this.btnTest.UseCustomForeColor = true;
            this.btnTest.UseSelectable = true;
            this.btnTest.UseStyleColors = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // panButton
            // 
            this.panButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panButton.Controls.Add(this.btnTest);
            this.panButton.Controls.Add(this.btnSave);
            this.panButton.HorizontalScrollbarBarColor = true;
            this.panButton.HorizontalScrollbarHighlightOnWheel = false;
            this.panButton.HorizontalScrollbarSize = 12;
            this.panButton.Location = new System.Drawing.Point(100, 529);
            this.panButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panButton.Name = "panButton";
            this.panButton.Size = new System.Drawing.Size(400, 31);
            this.panButton.TabIndex = 10;
            this.panButton.VerticalScrollbarBarColor = true;
            this.panButton.VerticalScrollbarHighlightOnWheel = false;
            this.panButton.VerticalScrollbarSize = 13;
            // 
            // frmChangeConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 625);
            this.Controls.Add(this.panButton);
            this.Controls.Add(this.metroPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmChangeConnection";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Connection Properties";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panUser.ResumeLayout(false);
            this.panUser.PerformLayout();
            this.panButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtHost;
        private MetroFramework.Controls.MetroTextBox txtUsername;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cbAuthType;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel panUser;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnTest;
        private MetroFramework.Controls.MetroPanel panButton;
    }
}