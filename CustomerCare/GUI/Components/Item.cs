using CustomerCare.STR;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomerCare.GUI.Components
{
    public partial class Item : UserControl
    {
        private Form context;

        public Item()
        {
            InitializeComponent();
        }

        public Item(ItemList item)
        {
            InitializeComponent();
            this.panPhoto.BackColor = item.BackColor == null ? Color.DarkBlue : item.BackColor;
            this.bigPic.ImageLocation = item.Image;
            this.lbTitle.Text = item.Title;
            this.context = item.Context;
        }

        public Item(string title, Color color, string image = "Images\\1.png", Form context = null)
        {
            InitializeComponent();
            this.panPhoto.BackColor = color == null ? Color.DarkBlue : color;
            this.bigPic.ImageLocation = image;
            this.lbTitle.Text = title;
            this.context = context;
        }

        private void Item_Click(object sender, EventArgs e)
        {
            context.ShowDialog();
        }
    }
}