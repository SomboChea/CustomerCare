namespace CustomerCare
{
    partial class frmSources
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSources));
            this.panHead = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.textBox1 = new CustomerCare.GUI.Components.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNames = new System.Windows.Forms.ComboBox();
            this.cbProvince = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDistrict = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCommune = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new CustomerCare.GUI.Components.SMXButton();
            this.panHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panHead
            // 
            this.panHead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panHead.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panHead.Controls.Add(this.picLogo);
            this.panHead.Controls.Add(this.label12);
            this.panHead.Controls.Add(this.btnClose);
            this.panHead.Location = new System.Drawing.Point(0, 0);
            this.panHead.Name = "panHead";
            this.panHead.Size = new System.Drawing.Size(1298, 55);
            this.panHead.TabIndex = 31;
            // 
            // picLogo
            // 
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogo.Image = global::CustomerCare.Properties.Resources.Tiles;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(55, 55);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 8;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(62, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 34);
            this.label12.TabIndex = 7;
            this.label12.Text = "Sources";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::CustomerCare.Properties.Resources.Close_32;
            this.btnClose.Location = new System.Drawing.Point(1243, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(55, 55);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnClose.TabIndex = 4;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClose_MouseDown);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // textBox1
            // 
            this.textBox1.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Font = new System.Drawing.Font("AKbalthom KhmerLer", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(148, 108);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.textBox1.MyBackColor = System.Drawing.SystemColors.Control;
            this.textBox1.MyBorderColor = System.Drawing.SystemColors.Control;
            this.textBox1.MyMulti = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(390, 50);
            this.textBox1.TabIndex = 32;
            this.textBox1.Value = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 33;
            this.label1.Text = "Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 34;
            this.label2.Text = "Name: ";
            // 
            // cbNames
            // 
            this.cbNames.Font = new System.Drawing.Font("AKbalthom KhmerLer", 12F);
            this.cbNames.FormattingEnabled = true;
            this.cbNames.Location = new System.Drawing.Point(148, 43);
            this.cbNames.Name = "cbNames";
            this.cbNames.Size = new System.Drawing.Size(391, 44);
            this.cbNames.TabIndex = 35;
            // 
            // cbProvince
            // 
            this.cbProvince.Font = new System.Drawing.Font("AKbalthom KhmerLer", 12F);
            this.cbProvince.FormattingEnabled = true;
            this.cbProvince.Location = new System.Drawing.Point(149, 41);
            this.cbProvince.Name = "cbProvince";
            this.cbProvince.Size = new System.Drawing.Size(390, 44);
            this.cbProvince.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 36;
            this.label3.Text = "Province:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbCommune);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbDistrict);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbProvince);
            this.groupBox1.Location = new System.Drawing.Point(12, 481);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 256);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 23);
            this.label4.TabIndex = 38;
            this.label4.Text = "District:";
            // 
            // cbDistrict
            // 
            this.cbDistrict.Font = new System.Drawing.Font("AKbalthom KhmerLer", 12F);
            this.cbDistrict.FormattingEnabled = true;
            this.cbDistrict.Location = new System.Drawing.Point(148, 91);
            this.cbDistrict.Name = "cbDistrict";
            this.cbDistrict.Size = new System.Drawing.Size(390, 44);
            this.cbDistrict.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 23);
            this.label5.TabIndex = 40;
            this.label5.Text = "Commune:";
            // 
            // cbCommune
            // 
            this.cbCommune.Font = new System.Drawing.Font("AKbalthom KhmerLer", 12F);
            this.cbCommune.FormattingEnabled = true;
            this.cbCommune.Location = new System.Drawing.Point(149, 141);
            this.cbCommune.Name = "cbCommune";
            this.cbCommune.Size = new System.Drawing.Size(390, 44);
            this.cbCommune.TabIndex = 41;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("AKbalthom KhmerLer", 12F);
            this.txtAddress.Location = new System.Drawing.Point(149, 191);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(390, 44);
            this.txtAddress.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 23);
            this.label6.TabIndex = 43;
            this.label6.Text = "Address:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbNames);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(559, 234);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personal Information";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.CurrentImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.CurrentImage")));
            this.btnAdd.HoverImage = null;
            this.btnAdd.Location = new System.Drawing.Point(1205, 656);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 80);
            this.btnAdd.TabIndex = 40;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmSources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1298, 749);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panHead);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmSources";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sources Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panHead.ResumeLayout(false);
            this.panHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panHead;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label label12;
        private GUI.Components.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbNames;
        private System.Windows.Forms.ComboBox cbProvince;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbDistrict;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCommune;
        private System.Windows.Forms.GroupBox groupBox2;
        private GUI.Components.SMXButton btnAdd;
    }
}