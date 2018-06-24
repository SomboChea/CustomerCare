namespace CustomerCare
{
    partial class frmDashboard
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
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnNewMom = new System.Windows.Forms.Button();
            this.frmNewSource = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btnLocations = new System.Windows.Forms.Button();
            this.btnViewAlert = new System.Windows.Forms.Button();
            this.panHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.panHead.Size = new System.Drawing.Size(1243, 55);
            this.panHead.TabIndex = 1;
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
            this.btnClose.Location = new System.Drawing.Point(1188, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(55, 55);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.lbTitle.Size = new System.Drawing.Size(322, 22);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Welcome {Username} - Dashboard";
            // 
            // btnNewMom
            // 
            this.btnNewMom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNewMom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNewMom.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNewMom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewMom.FlatAppearance.BorderSize = 0;
            this.btnNewMom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewMom.ForeColor = System.Drawing.Color.White;
            this.btnNewMom.Location = new System.Drawing.Point(79, 272);
            this.btnNewMom.Name = "btnNewMom";
            this.btnNewMom.Size = new System.Drawing.Size(250, 100);
            this.btnNewMom.TabIndex = 3;
            this.btnNewMom.Text = "New Mom";
            this.btnNewMom.UseVisualStyleBackColor = false;
            this.btnNewMom.Click += new System.EventHandler(this.btnNewMom_Click);
            // 
            // frmNewSource
            // 
            this.frmNewSource.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.frmNewSource.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.frmNewSource.BackColor = System.Drawing.Color.DodgerBlue;
            this.frmNewSource.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frmNewSource.FlatAppearance.BorderSize = 0;
            this.frmNewSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frmNewSource.ForeColor = System.Drawing.Color.White;
            this.frmNewSource.Location = new System.Drawing.Point(364, 272);
            this.frmNewSource.Name = "frmNewSource";
            this.frmNewSource.Size = new System.Drawing.Size(250, 100);
            this.frmNewSource.TabIndex = 4;
            this.frmNewSource.Text = "New Source";
            this.frmNewSource.UseVisualStyleBackColor = false;
            this.frmNewSource.Click += new System.EventHandler(this.frmNewSource_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(79, 395);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 100);
            this.button3.TabIndex = 5;
            this.button3.Text = "View Mom";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(364, 395);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(250, 100);
            this.button4.TabIndex = 6;
            this.button4.Text = "View Sources";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button5.BackColor = System.Drawing.Color.DodgerBlue;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(643, 272);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(250, 100);
            this.button5.TabIndex = 7;
            this.button5.Text = "Calling Lists";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button6.BackColor = System.Drawing.Color.DodgerBlue;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(643, 395);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(250, 100);
            this.button6.TabIndex = 8;
            this.button6.Text = "View Call Lists";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button7.BackColor = System.Drawing.Color.DodgerBlue;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(928, 395);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(250, 100);
            this.button7.TabIndex = 10;
            this.button7.Text = "Users";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button8.BackColor = System.Drawing.Color.DeepPink;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(79, 529);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(1099, 127);
            this.button8.TabIndex = 9;
            this.button8.Text = "Reports";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // btnLocations
            // 
            this.btnLocations.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLocations.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLocations.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLocations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLocations.FlatAppearance.BorderSize = 0;
            this.btnLocations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocations.ForeColor = System.Drawing.Color.White;
            this.btnLocations.Location = new System.Drawing.Point(928, 272);
            this.btnLocations.Name = "btnLocations";
            this.btnLocations.Size = new System.Drawing.Size(250, 100);
            this.btnLocations.TabIndex = 11;
            this.btnLocations.Text = "Locations";
            this.btnLocations.UseVisualStyleBackColor = false;
            this.btnLocations.Click += new System.EventHandler(this.btnLocations_Click);
            // 
            // btnViewAlert
            // 
            this.btnViewAlert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewAlert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnViewAlert.BackColor = System.Drawing.Color.Crimson;
            this.btnViewAlert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewAlert.FlatAppearance.BorderSize = 0;
            this.btnViewAlert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAlert.ForeColor = System.Drawing.Color.White;
            this.btnViewAlert.Location = new System.Drawing.Point(79, 110);
            this.btnViewAlert.Name = "btnViewAlert";
            this.btnViewAlert.Size = new System.Drawing.Size(1099, 127);
            this.btnViewAlert.TabIndex = 12;
            this.btnViewAlert.Text = "View Alerts";
            this.btnViewAlert.UseVisualStyleBackColor = false;
            this.btnViewAlert.Click += new System.EventHandler(this.btnViewAlert_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1243, 723);
            this.Controls.Add(this.btnViewAlert);
            this.Controls.Add(this.btnLocations);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.frmNewSource);
            this.Controls.Add(this.btnNewMom);
            this.Controls.Add(this.panHead);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome { Username } - Dashboard";
            this.panHead.ResumeLayout(false);
            this.panHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panHead;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNewMom;
        private System.Windows.Forms.Button frmNewSource;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnLocations;
        private System.Windows.Forms.Button btnViewAlert;
    }
}