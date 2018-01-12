namespace CustomerCare.GUI
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListOptions = new System.Windows.Forms.CheckedListBox();
            this.textBox1 = new CustomerCare.GUI.Components.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listRoles = new System.Windows.Forms.ListBox();
            this.panHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // panHead
            // 
            this.panHead.BackColor = System.Drawing.Color.DodgerBlue;
            this.panHead.Controls.Add(this.lbTitle);
            this.panHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHead.Location = new System.Drawing.Point(0, 0);
            this.panHead.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panHead.Name = "panHead";
            this.panHead.Size = new System.Drawing.Size(800, 78);
            this.panHead.TabIndex = 1;
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(210, 18);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(383, 44);
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
            this.label1.Size = new System.Drawing.Size(124, 21);
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
            this.checkedListOptions.Size = new System.Drawing.Size(470, 418);
            this.checkedListOptions.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("AKbalthom KhmerLer", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(146, 105);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(447, 48);
            this.textBox1.TabIndex = 3;
            this.textBox1.Value = "";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(601, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listRoles
            // 
            this.listRoles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listRoles.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.listRoles.FormattingEnabled = true;
            this.listRoles.ItemHeight = 21;
            this.listRoles.Location = new System.Drawing.Point(12, 194);
            this.listRoles.Name = "listRoles";
            this.listRoles.Size = new System.Drawing.Size(300, 420);
            this.listRoles.TabIndex = 7;
            this.listRoles.SelectedIndexChanged += new System.EventHandler(this.listRoles_SelectedIndexChanged);
            // 
            // frmPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 632);
            this.Controls.Add(this.listRoles);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkedListOptions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panHead);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPosition";
            this.Text = "frmPosition";
            this.Load += new System.EventHandler(this.frmPosition_Load);
            this.panHead.ResumeLayout(false);
            this.panHead.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panHead;
        private System.Windows.Forms.Label lbTitle;
        private Components.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListOptions;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listRoles;
    }
}