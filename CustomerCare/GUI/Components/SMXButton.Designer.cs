namespace CustomerCare.GUI.Components
{
    partial class SMXButton
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
            this.btnImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImage
            // 
            this.btnImage.BackColor = System.Drawing.SystemColors.Control;
            this.btnImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnImage.Image = global::CustomerCare.Properties.Resources.Add_New;
            this.btnImage.Location = new System.Drawing.Point(0, 0);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(80, 80);
            this.btnImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnImage.TabIndex = 0;
            this.btnImage.TabStop = false;
            this.btnImage.MouseEnter += new System.EventHandler(this.btnImage_MouseEnter);
            this.btnImage.MouseLeave += new System.EventHandler(this.btnImage_MouseLeave);
            // 
            // Button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnImage);
            this.Name = "Button";
            this.Size = new System.Drawing.Size(80, 80);
            ((System.ComponentModel.ISupportInitialize)(this.btnImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnImage;
    }
}
