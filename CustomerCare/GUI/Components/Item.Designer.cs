namespace CustomerCare.GUI.Components
{
    partial class Item
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTitle = new System.Windows.Forms.Label();
            this.bigPic = new System.Windows.Forms.PictureBox();
            this.panPhoto = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bigPic)).BeginInit();
            this.panPhoto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(105, 43);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(92, 32);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Home";
            this.lbTitle.Click += new System.EventHandler(this.Item_Click);
            // 
            // bigPic
            // 
            this.bigPic.Image = global::CustomerCare.Properties.Resources.online_shop_2;
            this.bigPic.Location = new System.Drawing.Point(18, 26);
            this.bigPic.Name = "bigPic";
            this.bigPic.Size = new System.Drawing.Size(63, 65);
            this.bigPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bigPic.TabIndex = 0;
            this.bigPic.TabStop = false;
            this.bigPic.Click += new System.EventHandler(this.Item_Click);
            // 
            // panPhoto
            // 
            this.panPhoto.BackColor = System.Drawing.Color.DodgerBlue;
            this.panPhoto.Controls.Add(this.bigPic);
            this.panPhoto.Location = new System.Drawing.Point(0, 0);
            this.panPhoto.Name = "panPhoto";
            this.panPhoto.Size = new System.Drawing.Size(99, 121);
            this.panPhoto.TabIndex = 2;
            this.panPhoto.Click += new System.EventHandler(this.Item_Click);
            // 
            // Item
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.panPhoto);
            this.Controls.Add(this.lbTitle);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Item";
            this.Size = new System.Drawing.Size(294, 121);
            this.Click += new System.EventHandler(this.Item_Click);
            ((System.ComponentModel.ISupportInitialize)(this.bigPic)).EndInit();
            this.panPhoto.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bigPic;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panPhoto;
    }
}
