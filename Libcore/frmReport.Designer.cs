namespace SMLOGX
{
    partial class frmReport
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
            this.viewreport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // viewreport
            // 
            this.viewreport.ActiveViewIndex = -1;
            this.viewreport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewreport.Cursor = System.Windows.Forms.Cursors.Default;
            this.viewreport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewreport.Location = new System.Drawing.Point(0, 0);
            this.viewreport.Name = "viewreport";
            this.viewreport.Size = new System.Drawing.Size(800, 450);
            this.viewreport.TabIndex = 0;
            this.viewreport.Load += new System.EventHandler(this.viewreport_Load);
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewreport);
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer viewreport;
    }
}