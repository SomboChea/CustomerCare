namespace CustomerCare
{
    partial class frmMain
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
            this.panMain = new System.Windows.Forms.FlowLayoutPanel();
            this.panHead = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnMinz = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.textBox1 = new CustomerCare.GUI.Components.TextBox();
            this.panMain.SuspendLayout();
            this.panHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panMain
            // 
            this.panMain.Controls.Add(this.textBox1);
            this.panMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMain.Location = new System.Drawing.Point(0, 57);
            this.panMain.Margin = new System.Windows.Forms.Padding(10);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(1193, 663);
            this.panMain.TabIndex = 0;
            // 
            // panHead
            // 
            this.panHead.BackColor = System.Drawing.Color.DodgerBlue;
            this.panHead.Controls.Add(this.lbTitle);
            this.panHead.Controls.Add(this.btnMinz);
            this.panHead.Controls.Add(this.picClose);
            this.panHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHead.Location = new System.Drawing.Point(0, 0);
            this.panHead.Margin = new System.Windows.Forms.Padding(4);
            this.panHead.Name = "panHead";
            this.panHead.Size = new System.Drawing.Size(1193, 57);
            this.panHead.TabIndex = 1;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(9, 11);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(160, 33);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Dashboard";
            // 
            // btnMinz
            // 
            this.btnMinz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinz.Image = global::CustomerCare.Properties.Resources.remove;
            this.btnMinz.Location = new System.Drawing.Point(1102, 13);
            this.btnMinz.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinz.Name = "btnMinz";
            this.btnMinz.Size = new System.Drawing.Size(35, 30);
            this.btnMinz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinz.TabIndex = 1;
            this.btnMinz.TabStop = false;
            this.btnMinz.Click += new System.EventHandler(this.btnMinz_Click);
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = global::CustomerCare.Properties.Resources.close_button;
            this.picClose.Location = new System.Drawing.Point(1150, 13);
            this.picClose.Margin = new System.Windows.Forms.Padding(4);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(30, 30);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClose.TabIndex = 0;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // textBox1
            // 
            this.textBox1.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("AKbalthom KhmerLer", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(4, 7);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Reg = null;
            this.textBox1.Size = new System.Drawing.Size(492, 44);
            this.textBox1.TabIndex = 0;
            this.textBox1.TestColor = "";
            this.textBox1.Value = "";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 720);
            this.ControlBox = false;
            this.Controls.Add(this.panMain);
            this.Controls.Add(this.panHead);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panMain.ResumeLayout(false);
            this.panHead.ResumeLayout(false);
            this.panHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panMain;
        private System.Windows.Forms.Panel panHead;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox btnMinz;
        private System.Windows.Forms.Label lbTitle;
        private GUI.Components.TextBox textBox1;
    }
}