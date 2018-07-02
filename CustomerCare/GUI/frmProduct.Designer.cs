namespace CustomerCare
{
    partial class frmProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbProductOwner = new System.Windows.Forms.ComboBox();
            this.panHead = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.txtLevel = new CustomerCare.GUI.Components.TextBox();
            this.txtName = new CustomerCare.GUI.Components.TextBox();
            this.panHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Level: ";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(51, 482);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(478, 59);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add Product";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description: ";
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDesc.Location = new System.Drawing.Point(218, 231);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(311, 141);
            this.txtDesc.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Product Owner: ";
            // 
            // cbProductOwner
            // 
            this.cbProductOwner.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbProductOwner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProductOwner.FormattingEnabled = true;
            this.cbProductOwner.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbProductOwner.Location = new System.Drawing.Point(218, 408);
            this.cbProductOwner.Name = "cbProductOwner";
            this.cbProductOwner.Size = new System.Drawing.Size(311, 28);
            this.cbProductOwner.TabIndex = 4;
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
            this.panHead.Size = new System.Drawing.Size(584, 55);
            this.panHead.TabIndex = 32;
            // 
            // picLogo
            // 
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogo.Image = global::CustomerCare.Properties.Resources.Product1;
            this.picLogo.Location = new System.Drawing.Point(11, 0);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(55, 55);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 8;
            this.picLogo.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(76, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(241, 34);
            this.label12.TabIndex = 7;
            this.label12.Text = "Product Addition";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::CustomerCare.Properties.Resources.Close_32;
            this.btnClose.Location = new System.Drawing.Point(529, 0);
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
            // txtLevel
            // 
            this.txtLevel.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtLevel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLevel.Location = new System.Drawing.Point(218, 153);
            this.txtLevel.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtLevel.MyBackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLevel.MyBorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtLevel.MyMulti = true;
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(311, 44);
            this.txtLevel.TabIndex = 2;
            this.txtLevel.Value = "";
            // 
            // txtName
            // 
            this.txtName.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(218, 82);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtName.MyBackColor = System.Drawing.Color.WhiteSmoke;
            this.txtName.MyBorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtName.MyMulti = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(311, 44);
            this.txtName.TabIndex = 1;
            this.txtName.Value = "";
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 563);
            this.Controls.Add(this.panHead);
            this.Controls.Add(this.cbProductOwner);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProduct";
            this.panHead.ResumeLayout(false);
            this.panHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private GUI.Components.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDesc;
        private GUI.Components.TextBox txtLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbProductOwner;
        private System.Windows.Forms.Panel panHead;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox btnClose;
    }
}