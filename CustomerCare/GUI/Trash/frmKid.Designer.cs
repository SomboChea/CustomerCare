namespace CustomerCare
{
    partial class frmKid
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
            this.btnDeleteKid = new System.Windows.Forms.Button();
            this.btnAddKid = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listKids = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKidName = new System.Windows.Forms.TextBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dateDOB = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtWhy = new System.Windows.Forms.TextBox();
            this.gbSelectPro = new System.Windows.Forms.GroupBox();
            this.rdUsed = new System.Windows.Forms.RadioButton();
            this.rdNotUsed = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gbSelectPro.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteKid
            // 
            this.btnDeleteKid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDeleteKid.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnDeleteKid.FlatAppearance.BorderSize = 0;
            this.btnDeleteKid.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteKid.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteKid.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteKid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteKid.Location = new System.Drawing.Point(896, 362);
            this.btnDeleteKid.Name = "btnDeleteKid";
            this.btnDeleteKid.Size = new System.Drawing.Size(121, 34);
            this.btnDeleteKid.TabIndex = 2;
            this.btnDeleteKid.Text = "Remove";
            this.btnDeleteKid.UseVisualStyleBackColor = false;
            this.btnDeleteKid.Click += new System.EventHandler(this.btnDeleteKid_Click);
            // 
            // btnAddKid
            // 
            this.btnAddKid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddKid.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAddKid.FlatAppearance.BorderSize = 0;
            this.btnAddKid.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.btnAddKid.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnAddKid.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnAddKid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddKid.Location = new System.Drawing.Point(755, 362);
            this.btnAddKid.Name = "btnAddKid";
            this.btnAddKid.Size = new System.Drawing.Size(121, 34);
            this.btnAddKid.TabIndex = 0;
            this.btnAddKid.Text = "Add kid";
            this.btnAddKid.UseVisualStyleBackColor = false;
            this.btnAddKid.Click += new System.EventHandler(this.btnAddKid_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 133;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Gender";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "DOB";
            this.columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Product";
            this.columnHeader4.Width = 159;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Why";
            this.columnHeader5.Width = 436;
            // 
            // listKids
            // 
            this.listKids.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listKids.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listKids.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listKids.FullRowSelect = true;
            this.listKids.GridLines = true;
            this.listKids.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listKids.Location = new System.Drawing.Point(12, 402);
            this.listKids.MultiSelect = false;
            this.listKids.Name = "listKids";
            this.listKids.Size = new System.Drawing.Size(1005, 169);
            this.listKids.TabIndex = 3;
            this.listKids.UseCompatibleStateImageBehavior = false;
            this.listKids.View = System.Windows.Forms.View.Details;
            this.listKids.DoubleClick += new System.EventHandler(this.listKids_DoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 100);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Gender: ";
            // 
            // txtKidName
            // 
            this.txtKidName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKidName.Location = new System.Drawing.Point(180, 36);
            this.txtKidName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtKidName.Name = "txtKidName";
            this.txtKidName.Size = new System.Drawing.Size(328, 26);
            this.txtKidName.TabIndex = 5;
            this.txtKidName.Tag = "";
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cbGender.Location = new System.Drawing.Point(180, 94);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(184, 28);
            this.cbGender.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 42);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 21);
            this.label11.TabIndex = 7;
            this.label11.Text = "Kid Name: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 158);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 21);
            this.label12.TabIndex = 8;
            this.label12.Text = "Record date: ";
            // 
            // dateDOB
            // 
            this.dateDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dateDOB.Location = new System.Drawing.Point(180, 149);
            this.dateDOB.Name = "dateDOB";
            this.dateDOB.Size = new System.Drawing.Size(328, 26);
            this.dateDOB.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(567, 149);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 21);
            this.label13.TabIndex = 10;
            this.label13.Text = "Product: ";
            // 
            // cbProduct
            // 
            this.cbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(661, 142);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(335, 28);
            this.cbProduct.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 224);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 21);
            this.label14.TabIndex = 12;
            this.label14.Text = "Why: ";
            // 
            // txtWhy
            // 
            this.txtWhy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWhy.Location = new System.Drawing.Point(95, 224);
            this.txtWhy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtWhy.Multiline = true;
            this.txtWhy.Name = "txtWhy";
            this.txtWhy.Size = new System.Drawing.Size(901, 107);
            this.txtWhy.TabIndex = 13;
            this.txtWhy.Tag = "";
            // 
            // gbSelectPro
            // 
            this.gbSelectPro.Controls.Add(this.rdNotUsed);
            this.gbSelectPro.Controls.Add(this.rdUsed);
            this.gbSelectPro.Location = new System.Drawing.Point(571, 27);
            this.gbSelectPro.Name = "gbSelectPro";
            this.gbSelectPro.Size = new System.Drawing.Size(425, 94);
            this.gbSelectPro.TabIndex = 15;
            this.gbSelectPro.TabStop = false;
            this.gbSelectPro.Text = "Product [Used / Not]";
            // 
            // rdUsed
            // 
            this.rdUsed.AutoSize = true;
            this.rdUsed.Location = new System.Drawing.Point(73, 48);
            this.rdUsed.Name = "rdUsed";
            this.rdUsed.Size = new System.Drawing.Size(73, 25);
            this.rdUsed.TabIndex = 0;
            this.rdUsed.TabStop = true;
            this.rdUsed.Text = "Used";
            this.rdUsed.UseVisualStyleBackColor = true;
            // 
            // rdNotUsed
            // 
            this.rdNotUsed.AutoSize = true;
            this.rdNotUsed.Location = new System.Drawing.Point(263, 48);
            this.rdNotUsed.Name = "rdNotUsed";
            this.rdNotUsed.Size = new System.Drawing.Size(109, 25);
            this.rdNotUsed.TabIndex = 1;
            this.rdNotUsed.TabStop = true;
            this.rdNotUsed.Text = "Not Used";
            this.rdNotUsed.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox4.Controls.Add(this.gbSelectPro);
            this.groupBox4.Controls.Add(this.txtWhy);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.cbProduct);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.dateDOB);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.cbGender);
            this.groupBox4.Controls.Add(this.txtKidName);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(13, 12);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(1004, 344);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kids";
            // 
            // frmKid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1030, 583);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.listKids);
            this.Controls.Add(this.btnAddKid);
            this.Controls.Add(this.btnDeleteKid);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MOM {Name} KIDS";
            this.Load += new System.EventHandler(this.frmKid_Load);
            this.gbSelectPro.ResumeLayout(false);
            this.gbSelectPro.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteKid;
        private System.Windows.Forms.Button btnAddKid;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView listKids;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKidName;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateDOB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtWhy;
        private System.Windows.Forms.GroupBox gbSelectPro;
        private System.Windows.Forms.RadioButton rdNotUsed;
        private System.Windows.Forms.RadioButton rdUsed;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}