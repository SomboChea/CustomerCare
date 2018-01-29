using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerCare
{
    internal class Initiailizing : Form
    {
        private TextBox txtInitializing;
        private PictureBox imgLoading;
        private Timer timerLoading;
        public int Interval { get; set; } = 1000;

        public System.Drawing.Size InitSize { get; set; } = new System.Drawing.Size(500, 500);

        private void initLoad()
        {
            InitializeComponent(InitSize);
            this.timerLoading.Tick += new System.EventHandler(this.timerStop);
            
            timerLoading.Interval = this.Interval;
        }

        public Initiailizing()
        {
            initLoad();
        }

        public Initiailizing(Form context)
        {
            initLoad();
        }

        private void timerStop(Object sender, EventArgs e)
        {
            timerLoading.Stop();
        }

        private void InitializeComponent(System.Drawing.Size size)
        {
            this.imgLoading = new System.Windows.Forms.PictureBox();
            this.txtInitializing = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoading)).BeginInit();
            this.SuspendLayout();
            //
            // imgLoading
            //
            this.imgLoading.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.imgLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgLoading.Image = global::CustomerCare.Properties.Resources.loading;
            this.imgLoading.Location = new System.Drawing.Point(0, 0);
            this.imgLoading.Name = "imgLoading";
            this.imgLoading.Size = size;
            this.imgLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgLoading.TabIndex = 0;
            this.imgLoading.TabStop = false;
            //
            // txtInitializing
            //
            this.txtInitializing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInitializing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInitializing.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtInitializing.Enabled = false;
            this.txtInitializing.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInitializing.HideSelection = false;
            this.txtInitializing.Location = new System.Drawing.Point(0, 365);
            this.txtInitializing.Name = "txtInitializing";
            this.txtInitializing.ReadOnly = true;
            this.txtInitializing.Size = new System.Drawing.Size(500, 29);
            this.txtInitializing.TabIndex = 1;
            this.txtInitializing.Text = "Initializing...";
            this.txtInitializing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInitializing.UseWaitCursor = true;
            //
            // Initiailizing
            //
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.ControlBox = false;
            this.Controls.Add(this.txtInitializing);
            this.Controls.Add(this.imgLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Initiailizing";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.imgLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}