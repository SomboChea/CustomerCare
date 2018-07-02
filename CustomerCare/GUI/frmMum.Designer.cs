namespace CustomerCare
{
    partial class frmMum
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
            this.panContent = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbSources = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbTypeOf = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCommune = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDistrict = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbProvince = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkKid = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTel1 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTel2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFB = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateEpt = new System.Windows.Forms.MaskedTextBox();
            this.cbNames = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panHead = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panContent.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panContent
            // 
            this.panContent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panContent.AutoSize = true;
            this.panContent.Controls.Add(this.groupBox4);
            this.panContent.Controls.Add(this.groupBox1);
            this.panContent.Controls.Add(this.groupBox3);
            this.panContent.Controls.Add(this.groupBox2);
            this.panContent.Location = new System.Drawing.Point(13, 87);
            this.panContent.Name = "panContent";
            this.panContent.Size = new System.Drawing.Size(1177, 526);
            this.panContent.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox4.Controls.Add(this.cbSources);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.cbTypeOf);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(586, 3);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(563, 159);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Source";
            // 
            // cbSources
            // 
            this.cbSources.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSources.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSources.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbSources.FormattingEnabled = true;
            this.cbSources.Location = new System.Drawing.Point(173, 36);
            this.cbSources.Name = "cbSources";
            this.cbSources.Size = new System.Drawing.Size(377, 33);
            this.cbSources.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(10, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 23);
            this.label11.TabIndex = 45;
            this.label11.Text = "Type of Source:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(11, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 23);
            this.label13.TabIndex = 47;
            this.label13.Text = "From Source:";
            // 
            // cbTypeOf
            // 
            this.cbTypeOf.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTypeOf.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTypeOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbTypeOf.FormattingEnabled = true;
            this.cbTypeOf.Location = new System.Drawing.Point(172, 91);
            this.cbTypeOf.Name = "cbTypeOf";
            this.cbTypeOf.Size = new System.Drawing.Size(378, 33);
            this.cbTypeOf.TabIndex = 46;
            this.cbTypeOf.SelectedIndexChanged += new System.EventHandler(this.cbTypeOf_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbCommune);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbDistrict);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbProvince);
            this.groupBox1.Location = new System.Drawing.Point(14, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 335);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(17, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 23);
            this.label6.TabIndex = 43;
            this.label6.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAddress.Location = new System.Drawing.Point(169, 199);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(369, 116);
            this.txtAddress.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 40;
            this.label2.Text = "Commune:";
            // 
            // cbCommune
            // 
            this.cbCommune.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCommune.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCommune.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbCommune.FormattingEnabled = true;
            this.cbCommune.Location = new System.Drawing.Point(169, 141);
            this.cbCommune.Name = "cbCommune";
            this.cbCommune.Size = new System.Drawing.Size(369, 33);
            this.cbCommune.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(16, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 23);
            this.label4.TabIndex = 38;
            this.label4.Text = "District:";
            // 
            // cbDistrict
            // 
            this.cbDistrict.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDistrict.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbDistrict.FormattingEnabled = true;
            this.cbDistrict.Location = new System.Drawing.Point(168, 91);
            this.cbDistrict.Name = "cbDistrict";
            this.cbDistrict.Size = new System.Drawing.Size(370, 33);
            this.cbDistrict.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 36;
            this.label3.Text = "Province:";
            // 
            // cbProvince
            // 
            this.cbProvince.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbProvince.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbProvince.FormattingEnabled = true;
            this.cbProvince.Location = new System.Drawing.Point(169, 41);
            this.cbProvince.Name = "cbProvince";
            this.cbProvince.Size = new System.Drawing.Size(370, 33);
            this.cbProvince.TabIndex = 37;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.checkKid);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtTel1);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtTel2);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtFB);
            this.groupBox3.Controls.Add(this.txtEmail);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(585, 175);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(564, 335);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contacts";
            // 
            // checkKid
            // 
            this.checkKid.AutoSize = true;
            this.checkKid.Location = new System.Drawing.Point(25, 282);
            this.checkKid.Name = "checkKid";
            this.checkKid.Size = new System.Drawing.Size(121, 27);
            this.checkKid.TabIndex = 20;
            this.checkKid.Text = "Has a kid";
            this.checkKid.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 42);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tel Line 1: ";
            // 
            // txtTel1
            // 
            this.txtTel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTel1.Location = new System.Drawing.Point(134, 36);
            this.txtTel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTel1.Name = "txtTel1";
            this.txtTel1.Size = new System.Drawing.Size(417, 30);
            this.txtTel1.TabIndex = 13;
            this.txtTel1.Tag = "Tel";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(288, 269);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(263, 46);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Save";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 95);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tel Line 2: ";
            // 
            // txtTel2
            // 
            this.txtTel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTel2.Location = new System.Drawing.Point(134, 93);
            this.txtTel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTel2.Name = "txtTel2";
            this.txtTel2.Size = new System.Drawing.Size(417, 30);
            this.txtTel2.TabIndex = 15;
            this.txtTel2.Tag = "Tel2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 152);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 23);
            this.label10.TabIndex = 16;
            this.label10.Text = "Email: ";
            // 
            // txtFB
            // 
            this.txtFB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFB.Location = new System.Drawing.Point(135, 207);
            this.txtFB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFB.Name = "txtFB";
            this.txtFB.Size = new System.Drawing.Size(417, 30);
            this.txtFB.TabIndex = 19;
            this.txtFB.Tag = "Facebook";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.Location = new System.Drawing.Point(134, 146);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(417, 30);
            this.txtEmail.TabIndex = 17;
            this.txtEmail.Tag = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 213);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "Facebook: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.dateEpt);
            this.groupBox2.Controls.Add(this.cbNames);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(14, 3);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(564, 159);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // dateEpt
            // 
            this.dateEpt.Location = new System.Drawing.Point(169, 100);
            this.dateEpt.Mask = "00/00/0000";
            this.dateEpt.Name = "dateEpt";
            this.dateEpt.Size = new System.Drawing.Size(369, 32);
            this.dateEpt.TabIndex = 7;
            this.dateEpt.ValidatingType = typeof(System.DateTime);
            // 
            // cbNames
            // 
            this.cbNames.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNames.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbNames.FormattingEnabled = true;
            this.cbNames.Location = new System.Drawing.Point(169, 36);
            this.cbNames.Name = "cbNames";
            this.cbNames.Size = new System.Drawing.Size(369, 33);
            this.cbNames.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 103);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Expected date: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mom Name: ";
            // 
            // panHead
            // 
            this.panHead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panHead.BackColor = System.Drawing.Color.DodgerBlue;
            this.panHead.Controls.Add(this.btnClose);
            this.panHead.Controls.Add(this.pictureBox1);
            this.panHead.Controls.Add(this.lbTitle);
            this.panHead.Location = new System.Drawing.Point(0, 0);
            this.panHead.Name = "panHead";
            this.panHead.Size = new System.Drawing.Size(1203, 55);
            this.panHead.TabIndex = 11;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::CustomerCare.Properties.Resources.Close_32;
            this.btnClose.Location = new System.Drawing.Point(1148, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(55, 55);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CustomerCare.Properties.Resources.Tiles;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(63, 13);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(137, 30);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "New Mom";
            // 
            // frmMum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1202, 787);
            this.Controls.Add(this.panHead);
            this.Controls.Add(this.panContent);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mom Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panContent.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panHead.ResumeLayout(false);
            this.panHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panContent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFB;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbNames;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCommune;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbDistrict;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbProvince;
        private System.Windows.Forms.ComboBox cbTypeOf;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbSources;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panHead;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkKid;
        private System.Windows.Forms.MaskedTextBox dateEpt;
    }
}