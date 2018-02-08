using SMLOGX.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerCare.GUI.Components
{
    public partial class BlurForm : Form
    {
        private PictureBox pb;

        public BlurForm()
        {
            InitializeComponent();
            pb = new PictureBox();
            panel1.Controls.Add(pb);
            pb.Dock = DockStyle.Fill;
            panel1.Dock = DockStyle.Fill;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            Blur(panel1, pb);
        }

        private void Blur(Panel panel, PictureBox p)
        {
            Bitmap bmp = Screenshot.TakeSnapshot(panel);
            BitmapFilter.GaussianBlur(bmp, 4);

            p.Image = bmp;
            p.BringToFront();
        }

        private void UnBlur(PictureBox p)
        {
            p.Image = null;
            p.SendToBack();
        }
    }
}