using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using SMLOGX.Core;

namespace CustomerCare.GUI.Components
{
    [ToolboxItem(true)]
    //[ToolboxBitmap(typeof(SMXButton), @"D:\Repository\Projects\CSharp\CustomerCare\CustomerCare\Resources\Button.bmp")]
    public partial class SMXButton : UserControl
    {
        public SMXButton()
        {
            InitializeComponent();
        }

        private Image temp = null;

        [Description("Hello"), Category("Alpha")]
        public Image CurrentImage { get => btnImage.Image; set => btnImage.Image = value; }

        [Description("Hello"), Category("Alpha")]
        public Image HoverImage { get; set; }

        private bool isImageNull = false;

        private void btnImage_MouseHover(object sender, EventArgs e)
        {
        }

        private void btnImage_MouseLeave(object sender, EventArgs e)
        {
            btnImage.Image = temp;
        }

        private void btnImage_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            isImageNull = HoverImage.Equals(null);
            if (isImageNull)
                return;
            temp = btnImage.Image;
            btnImage.Image = HoverImage;
        }
    }
}