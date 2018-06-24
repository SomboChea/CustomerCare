namespace CustomerCare
{
    partial class frmPosition
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
            this.panHead = new System.Windows.Forms.Panel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListOptions = new System.Windows.Forms.CheckedListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listRoles = new System.Windows.Forms.ListBox();
            this.txtPosition = new CustomerCare.GUI.Components.TextBox();
            this.panHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panHead
            // 
            this.panHead.BackColor = System.Drawing.Color.DodgerBlue;
            this.panHead.Controls.Add(this.picClose);
            this.panHead.Controls.Add(this.lbTitle);
            this.panHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHead.Location = new System.Drawing.Point(0, 0);
            this.panHead.Margin = new System.Windows.Forms.Padding(4);
            this.panHead.Name = "panHead";
            this.panHead.Size = new System.Drawing.Size(800, 78);
            this.panHead.TabIndex = 1;
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = global::CustomerCare.Properties.Resources.close_button;
            this.picClose.Location = new System.Drawing.Point(742, 24);
            this.picClose.Margin = new System.Windows.Forms.Padding(4);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(30, 30);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClose.TabIndex = 2;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(165, 9);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(485, 56);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Position and Options";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Position Name:";
            // 
            // checkedListOptions
            // 
            this.checkedListOptions.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.checkedListOptions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListOptions.CheckOnClick = true;
            this.checkedListOptions.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkedListOptions.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListOptions.FormattingEnabled = true;
            this.checkedListOptions.Location = new System.Drawing.Point(318, 194);
            this.checkedListOptions.Name = "checkedListOptions";
            this.checkedListOptions.Size = new System.Drawing.Size(470, 432);
            this.checkedListOptions.TabIndex = 5;
            this.checkedListOptions.SelectedIndexChanged += new System.EventHandler(this.checkedListOptions_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(601, 105);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(183, 48);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // listRoles
            // 
            this.listRoles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listRoles.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.listRoles.FormattingEnabled = true;
            this.listRoles.ItemHeight = 23;
            this.listRoles.Location = new System.Drawing.Point(12, 194);
            this.listRoles.Name = "listRoles";
            this.listRoles.Size = new System.Drawing.Size(300, 437);
            this.listRoles.TabIndex = 7;
            this.listRoles.SelectedIndexChanged += new System.EventHandler(this.listRoles_SelectedIndexChanged);
            // 
            // txtPosition
            // 
            this.txtPosition.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtPosition.BackColor = System.Drawing.Color.White;
            this.txtPosition.Font = new System.Drawing.Font("AKbalthom KhmerLer", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosition.Location = new System.Drawing.Point(175, 105);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
            this.txtPosition.MyBackColor = System.Drawing.SystemColors.Control;
            this.txtPosition.MyBorderColor = System.Drawing.Color.White;
            this.txtPosition.MyMulti = true;
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(418, 48);
            this.txtPosition.TabIndex = 3;
            this.txtPosition.Value = "";
            // 
            // frmPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 615);
            this.Controls.Add(this.listRoles);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.checkedListOptions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.panHead);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPosition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPosition";
            this.Load += new System.EventHandler(this.frmPosition_Load);
            this.panHead.ResumeLayout(false);
            this.panHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panHead;
        private System.Windows.Forms.Label lbTitle;
        private GUI.Components.TextBox txtPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListOptions;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox listRoles;
        private System.Windows.Forms.PictureBox picClose;
    }
}