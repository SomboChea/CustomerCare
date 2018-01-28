namespace CustomerCare.GUI.Components
{
    partial class ImageButton
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
            this.IconLabel = new System.Windows.Forms.PictureBox();
            this.TextLabel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.IconLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // IconLabel
            // 
            this.IconLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IconLabel.Image = global::CustomerCare.Properties.Resources.online_shop_2;
            this.IconLabel.Location = new System.Drawing.Point(0, 0);
            this.IconLabel.Name = "IconLabel";
            this.IconLabel.Size = new System.Drawing.Size(204, 125);
            this.IconLabel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconLabel.TabIndex = 0;
            this.IconLabel.TabStop = false;
            // 
            // TextLabel
            // 
            this.TextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLabel.Location = new System.Drawing.Point(0, 131);
            this.TextLabel.Multiline = true;
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.ReadOnly = true;
            this.TextLabel.Size = new System.Drawing.Size(204, 41);
            this.TextLabel.TabIndex = 1;
            this.TextLabel.Text = "This a Label";
            this.TextLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ImageButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.IconLabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ImageButton";
            this.Size = new System.Drawing.Size(204, 172);
            ((System.ComponentModel.ISupportInitialize)(this.IconLabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox IconLabel;
        private System.Windows.Forms.TextBox TextLabel;
    }
}
