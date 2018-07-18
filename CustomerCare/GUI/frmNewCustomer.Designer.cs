namespace CustomerCare.GUI
{
    partial class frmNewCustomer
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
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dpExpected = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.chkHaveKid = new MetroFramework.Controls.MetroCheckBox();
            this.panContact = new MetroFramework.Controls.MetroPanel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtTel1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtTel2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtFacebook = new MetroFramework.Controls.MetroTextBox();
            this.selectSource = new MetroFramework.Controls.MetroTextBox();
            this.selectAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtOther = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.panExpected = new MetroFramework.Controls.MetroPanel();
            this.panContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panExpected.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSave.Location = new System.Drawing.Point(747, 428);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 37);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.UseStyleColors = true;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(164, 195);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PromptText = "Enter customer name here...";
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(210, 27);
            this.txtName.TabIndex = 2;
            this.txtName.UseCustomBackColor = true;
            this.txtName.UseCustomForeColor = true;
            this.txtName.UseSelectable = true;
            this.txtName.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(49, 195);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(109, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Customer Name";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(501, 195);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(86, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "From Source";
            // 
            // dpExpected
            // 
            this.dpExpected.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpExpected.Location = new System.Drawing.Point(116, 3);
            this.dpExpected.MinimumSize = new System.Drawing.Size(0, 29);
            this.dpExpected.Name = "dpExpected";
            this.dpExpected.Size = new System.Drawing.Size(290, 29);
            this.dpExpected.TabIndex = 6;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(0, 3);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(96, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Expected Date";
            // 
            // chkHaveKid
            // 
            this.chkHaveKid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkHaveKid.AutoSize = true;
            this.chkHaveKid.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkHaveKid.Location = new System.Drawing.Point(380, 198);
            this.chkHaveKid.Name = "chkHaveKid";
            this.chkHaveKid.Size = new System.Drawing.Size(78, 19);
            this.chkHaveKid.TabIndex = 8;
            this.chkHaveKid.Text = "Have kid";
            this.chkHaveKid.UseSelectable = true;
            this.chkHaveKid.CheckedChanged += new System.EventHandler(this.chkHaveKid_CheckedChanged);
            // 
            // panContact
            // 
            this.panContact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panContact.Controls.Add(this.metroLabel7);
            this.panContact.Controls.Add(this.txtFacebook);
            this.panContact.Controls.Add(this.metroLabel6);
            this.panContact.Controls.Add(this.txtEmail);
            this.panContact.Controls.Add(this.metroLabel5);
            this.panContact.Controls.Add(this.txtTel2);
            this.panContact.Controls.Add(this.metroLabel4);
            this.panContact.Controls.Add(this.txtTel1);
            this.panContact.HorizontalScrollbarBarColor = true;
            this.panContact.HorizontalScrollbarHighlightOnWheel = false;
            this.panContact.HorizontalScrollbarSize = 10;
            this.panContact.Location = new System.Drawing.Point(49, 270);
            this.panContact.Name = "panContact";
            this.panContact.Size = new System.Drawing.Size(409, 139);
            this.panContact.TabIndex = 9;
            this.panContact.VerticalScrollbarBarColor = true;
            this.panContact.VerticalScrollbarHighlightOnWheel = false;
            this.panContact.VerticalScrollbarSize = 10;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(0, 5);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(66, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Tel Line 1";
            // 
            // txtTel1
            // 
            this.txtTel1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTel1.Lines = new string[0];
            this.txtTel1.Location = new System.Drawing.Point(115, 5);
            this.txtTel1.MaxLength = 50;
            this.txtTel1.Name = "txtTel1";
            this.txtTel1.PasswordChar = '\0';
            this.txtTel1.PromptText = "Enter phone number here...";
            this.txtTel1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTel1.SelectedText = "";
            this.txtTel1.Size = new System.Drawing.Size(292, 27);
            this.txtTel1.TabIndex = 4;
            this.txtTel1.UseCustomBackColor = true;
            this.txtTel1.UseCustomForeColor = true;
            this.txtTel1.UseSelectable = true;
            this.txtTel1.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(0, 38);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(66, 19);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "Tel Line 2";
            // 
            // txtTel2
            // 
            this.txtTel2.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTel2.Lines = new string[0];
            this.txtTel2.Location = new System.Drawing.Point(115, 38);
            this.txtTel2.MaxLength = 50;
            this.txtTel2.Name = "txtTel2";
            this.txtTel2.PasswordChar = '\0';
            this.txtTel2.PromptText = "Enter phone number here...";
            this.txtTel2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTel2.SelectedText = "";
            this.txtTel2.Size = new System.Drawing.Size(292, 27);
            this.txtTel2.TabIndex = 6;
            this.txtTel2.UseCustomBackColor = true;
            this.txtTel2.UseCustomForeColor = true;
            this.txtTel2.UseSelectable = true;
            this.txtTel2.UseStyleColors = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(0, 71);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(41, 19);
            this.metroLabel6.TabIndex = 9;
            this.metroLabel6.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(115, 71);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PromptText = "Enter email here...";
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(292, 27);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.UseCustomBackColor = true;
            this.txtEmail.UseCustomForeColor = true;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.UseStyleColors = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(0, 104);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(67, 19);
            this.metroLabel7.TabIndex = 11;
            this.metroLabel7.Text = "Facebook";
            // 
            // txtFacebook
            // 
            this.txtFacebook.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtFacebook.Lines = new string[0];
            this.txtFacebook.Location = new System.Drawing.Point(115, 104);
            this.txtFacebook.MaxLength = 50;
            this.txtFacebook.Name = "txtFacebook";
            this.txtFacebook.PasswordChar = '\0';
            this.txtFacebook.PromptText = "Enter facebook here...";
            this.txtFacebook.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFacebook.SelectedText = "";
            this.txtFacebook.Size = new System.Drawing.Size(292, 27);
            this.txtFacebook.TabIndex = 10;
            this.txtFacebook.UseCustomBackColor = true;
            this.txtFacebook.UseCustomForeColor = true;
            this.txtFacebook.UseSelectable = true;
            this.txtFacebook.UseStyleColors = true;
            // 
            // selectSource
            // 
            this.selectSource.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectSource.Enabled = false;
            this.selectSource.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.selectSource.Lines = new string[0];
            this.selectSource.Location = new System.Drawing.Point(593, 195);
            this.selectSource.MaxLength = 50;
            this.selectSource.Name = "selectSource";
            this.selectSource.PasswordChar = '\0';
            this.selectSource.PromptText = "Please click here to quick add...";
            this.selectSource.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.selectSource.SelectedText = "";
            this.selectSource.Size = new System.Drawing.Size(262, 27);
            this.selectSource.TabIndex = 12;
            this.selectSource.UseCustomBackColor = true;
            this.selectSource.UseCustomForeColor = true;
            this.selectSource.UseSelectable = true;
            this.selectSource.UseStyleColors = true;
            // 
            // selectAddress
            // 
            this.selectAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectAddress.Enabled = false;
            this.selectAddress.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.selectAddress.Lines = new string[0];
            this.selectAddress.Location = new System.Drawing.Point(505, 268);
            this.selectAddress.MaxLength = 50;
            this.selectAddress.Name = "selectAddress";
            this.selectAddress.PasswordChar = '\0';
            this.selectAddress.PromptText = "Please click here to quick add...";
            this.selectAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.selectAddress.SelectedText = "";
            this.selectAddress.Size = new System.Drawing.Size(350, 27);
            this.selectAddress.TabIndex = 14;
            this.selectAddress.UseCustomBackColor = true;
            this.selectAddress.UseCustomForeColor = true;
            this.selectAddress.UseSelectable = true;
            this.selectAddress.UseStyleColors = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(501, 238);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(140, 19);
            this.metroLabel8.TabIndex = 13;
            this.metroLabel8.Text = "Customer Address ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::CustomerCare.Properties.Resources.User_Add_Cir;
            this.pictureBox1.Location = new System.Drawing.Point(380, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // txtOther
            // 
            this.txtOther.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOther.Enabled = false;
            this.txtOther.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtOther.Lines = new string[0];
            this.txtOther.Location = new System.Drawing.Point(505, 342);
            this.txtOther.MaxLength = 255;
            this.txtOther.Multiline = true;
            this.txtOther.Name = "txtOther";
            this.txtOther.PasswordChar = '\0';
            this.txtOther.PromptText = "Other customer information ...";
            this.txtOther.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOther.SelectedText = "";
            this.txtOther.Size = new System.Drawing.Size(350, 59);
            this.txtOther.TabIndex = 17;
            this.txtOther.UseCustomBackColor = true;
            this.txtOther.UseCustomForeColor = true;
            this.txtOther.UseSelectable = true;
            this.txtOther.UseStyleColors = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(501, 317);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(116, 19);
            this.metroLabel9.TabIndex = 16;
            this.metroLabel9.Text = "Other Infomation";
            // 
            // panExpected
            // 
            this.panExpected.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panExpected.Controls.Add(this.dpExpected);
            this.panExpected.Controls.Add(this.metroLabel3);
            this.panExpected.HorizontalScrollbarBarColor = true;
            this.panExpected.HorizontalScrollbarHighlightOnWheel = false;
            this.panExpected.HorizontalScrollbarSize = 10;
            this.panExpected.Location = new System.Drawing.Point(49, 229);
            this.panExpected.Name = "panExpected";
            this.panExpected.Size = new System.Drawing.Size(409, 37);
            this.panExpected.TabIndex = 18;
            this.panExpected.VerticalScrollbarBarColor = true;
            this.panExpected.VerticalScrollbarHighlightOnWheel = false;
            this.panExpected.VerticalScrollbarSize = 10;
            // 
            // frmNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 546);
            this.Controls.Add(this.panExpected);
            this.Controls.Add(this.txtOther);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.selectAddress);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.selectSource);
            this.Controls.Add(this.panContact);
            this.Controls.Add(this.chkHaveKid);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSave);
            this.Name = "frmNewCustomer";
            this.Text = "New Customer";
            this.panContact.ResumeLayout(false);
            this.panContact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panExpected.ResumeLayout(false);
            this.panExpected.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime dpExpected;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroCheckBox chkHaveKid;
        private MetroFramework.Controls.MetroPanel panContact;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtTel1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtTel2;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtFacebook;
        private MetroFramework.Controls.MetroTextBox selectSource;
        private MetroFramework.Controls.MetroTextBox selectAddress;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox txtOther;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroPanel panExpected;
    }
}