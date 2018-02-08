namespace CustomerCare.GUI.Components
{
    partial class Demo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Demo));
            this.smxClose1 = new CustomerCare.GUI.Components.smxClose();
            this.SuspendLayout();
            // 
            // smxClose1
            // 
            this.smxClose1.BgColor = System.Drawing.Color.DeepSkyBlue;
            this.smxClose1.Hover = null;
            this.smxClose1.HoverColor = System.Drawing.Color.Crimson;
            this.smxClose1.Location = new System.Drawing.Point(516, 102);
            this.smxClose1.Name = "smxClose1";
            this.smxClose1.Normal = ((System.Drawing.Image)(resources.GetObject("smxClose1.Normal")));
            this.smxClose1.Size = new System.Drawing.Size(100, 100);
            this.smxClose1.TabIndex = 0;
            // 
            // Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 527);
            this.Controls.Add(this.smxClose1);
            this.Name = "Demo";
            this.Text = "Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private smxClose smxClose1;
    }
}