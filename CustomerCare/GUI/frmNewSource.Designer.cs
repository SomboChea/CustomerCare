namespace CustomerCare.GUI
{
    partial class frmNewSource
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.txtOwner = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbType = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtMemo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.cbProvince = new System.Windows.Forms.ComboBox();
            this.cbDistrict = new System.Windows.Forms.ComboBox();
            this.cbCommune = new System.Windows.Forms.ComboBox();
            this.txtTel1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtTel2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(25, 102);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(118, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Source Name";
            // 
            // txtName
            // 
            this.txtName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(30, 140);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PromptText = "Enter source name here...";
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(339, 36);
            this.txtName.TabIndex = 0;
            this.txtName.UseCustomBackColor = true;
            this.txtName.UseCustomForeColor = true;
            this.txtName.UseSelectable = true;
            this.txtName.UseStyleColors = true;
            this.txtName.WordWrap = false;
            // 
            // txtOwner
            // 
            this.txtOwner.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtOwner.Lines = new string[0];
            this.txtOwner.Location = new System.Drawing.Point(30, 225);
            this.txtOwner.MaxLength = 50;
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.PasswordChar = '\0';
            this.txtOwner.PromptText = "Enter source name here...";
            this.txtOwner.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOwner.SelectedText = "";
            this.txtOwner.Size = new System.Drawing.Size(339, 36);
            this.txtOwner.TabIndex = 1;
            this.txtOwner.UseCustomBackColor = true;
            this.txtOwner.UseCustomForeColor = true;
            this.txtOwner.UseSelectable = true;
            this.txtOwner.UseStyleColors = true;
            this.txtOwner.WordWrap = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(25, 187);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(200, 25);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Owner Name (Optional)";
            // 
            // cbType
            // 
            this.cbType.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cbType.FormattingEnabled = true;
            this.cbType.ItemHeight = 29;
            this.cbType.Location = new System.Drawing.Point(30, 312);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(339, 35);
            this.cbType.TabIndex = 2;
            this.cbType.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(25, 273);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(108, 25);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Source Type";
            // 
            // txtMemo
            // 
            this.txtMemo.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtMemo.Lines = new string[0];
            this.txtMemo.Location = new System.Drawing.Point(419, 523);
            this.txtMemo.MaxLength = 50;
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.PasswordChar = '\0';
            this.txtMemo.PromptText = "Enter source name here...";
            this.txtMemo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMemo.SelectedText = "";
            this.txtMemo.Size = new System.Drawing.Size(355, 85);
            this.txtMemo.TabIndex = 10;
            this.txtMemo.UseCustomBackColor = true;
            this.txtMemo.UseCustomForeColor = true;
            this.txtMemo.UseSelectable = true;
            this.txtMemo.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(414, 484);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(64, 25);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Memo";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(414, 102);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(79, 25);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "Province";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(414, 187);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(67, 25);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "District";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(414, 273);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(95, 25);
            this.metroLabel7.TabIndex = 13;
            this.metroLabel7.Text = "Commune";
            // 
            // txtAddress
            // 
            this.txtAddress.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtAddress.Lines = new string[0];
            this.txtAddress.Location = new System.Drawing.Point(419, 399);
            this.txtAddress.MaxLength = 50;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PromptText = "Enter source name here...";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(355, 72);
            this.txtAddress.TabIndex = 9;
            this.txtAddress.UseCustomBackColor = true;
            this.txtAddress.UseCustomForeColor = true;
            this.txtAddress.UseSelectable = true;
            this.txtAddress.UseStyleColors = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(414, 360);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(77, 25);
            this.metroLabel8.TabIndex = 14;
            this.metroLabel8.Text = "Address";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSave.Location = new System.Drawing.Point(649, 624);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 38);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.UseStyleColors = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbProvince
            // 
            this.cbProvince.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbProvince.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbProvince.Font = new System.Drawing.Font("AKbalthom KhmerLer", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProvince.FormattingEnabled = true;
            this.cbProvince.Location = new System.Drawing.Point(419, 140);
            this.cbProvince.Name = "cbProvince";
            this.cbProvince.Size = new System.Drawing.Size(355, 35);
            this.cbProvince.TabIndex = 6;
            this.cbProvince.SelectedIndexChanged += new System.EventHandler(this.cbProvince_SelectedIndexChanged);
            // 
            // cbDistrict
            // 
            this.cbDistrict.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDistrict.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDistrict.Font = new System.Drawing.Font("AKbalthom KhmerLer", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDistrict.FormattingEnabled = true;
            this.cbDistrict.Location = new System.Drawing.Point(419, 226);
            this.cbDistrict.Name = "cbDistrict";
            this.cbDistrict.Size = new System.Drawing.Size(355, 35);
            this.cbDistrict.TabIndex = 7;
            this.cbDistrict.SelectedIndexChanged += new System.EventHandler(this.cbDistrict_SelectedIndexChanged);
            // 
            // cbCommune
            // 
            this.cbCommune.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCommune.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCommune.Font = new System.Drawing.Font("AKbalthom KhmerLer", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCommune.FormattingEnabled = true;
            this.cbCommune.Location = new System.Drawing.Point(419, 312);
            this.cbCommune.Name = "cbCommune";
            this.cbCommune.Size = new System.Drawing.Size(355, 35);
            this.cbCommune.TabIndex = 8;
            // 
            // txtTel1
            // 
            this.txtTel1.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtTel1.Lines = new string[0];
            this.txtTel1.Location = new System.Drawing.Point(30, 399);
            this.txtTel1.MaxLength = 50;
            this.txtTel1.Name = "txtTel1";
            this.txtTel1.PasswordChar = '\0';
            this.txtTel1.PromptText = "Enter source name here...";
            this.txtTel1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTel1.SelectedText = "";
            this.txtTel1.Size = new System.Drawing.Size(339, 36);
            this.txtTel1.TabIndex = 3;
            this.txtTel1.UseCustomBackColor = true;
            this.txtTel1.UseCustomForeColor = true;
            this.txtTel1.UseSelectable = true;
            this.txtTel1.UseStyleColors = true;
            this.txtTel1.WordWrap = false;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(25, 361);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(83, 25);
            this.metroLabel9.TabIndex = 20;
            this.metroLabel9.Text = "Tel Line 1";
            // 
            // txtTel2
            // 
            this.txtTel2.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtTel2.Lines = new string[0];
            this.txtTel2.Location = new System.Drawing.Point(30, 484);
            this.txtTel2.MaxLength = 50;
            this.txtTel2.Name = "txtTel2";
            this.txtTel2.PasswordChar = '\0';
            this.txtTel2.PromptText = "Enter source name here...";
            this.txtTel2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTel2.SelectedText = "";
            this.txtTel2.Size = new System.Drawing.Size(339, 36);
            this.txtTel2.TabIndex = 4;
            this.txtTel2.UseCustomBackColor = true;
            this.txtTel2.UseCustomForeColor = true;
            this.txtTel2.UseSelectable = true;
            this.txtTel2.UseStyleColors = true;
            this.txtTel2.WordWrap = false;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(25, 446);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(83, 25);
            this.metroLabel10.TabIndex = 22;
            this.metroLabel10.Text = "Tel Line 2";
            // 
            // txtEmail
            // 
            this.txtEmail.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(30, 572);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PromptText = "Enter source name here...";
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(339, 36);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.UseCustomBackColor = true;
            this.txtEmail.UseCustomForeColor = true;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.UseStyleColors = true;
            this.txtEmail.WordWrap = false;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(25, 534);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(54, 25);
            this.metroLabel11.TabIndex = 24;
            this.metroLabel11.Text = "Email";
            // 
            // frmNewSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 685);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.txtTel2);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.txtTel1);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.cbCommune);
            this.Controls.Add(this.cbDistrict);
            this.Controls.Add(this.cbProvince);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.txtOwner);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmNewSource";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "New Source";
            this.Load += new System.EventHandler(this.frmNewSource_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroTextBox txtOwner;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cbType;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtMemo;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtAddress;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton btnSave;
        private System.Windows.Forms.ComboBox cbProvince;
        private System.Windows.Forms.ComboBox cbDistrict;
        private System.Windows.Forms.ComboBox cbCommune;
        private MetroFramework.Controls.MetroTextBox txtTel1;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtTel2;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroLabel metroLabel11;
    }
}