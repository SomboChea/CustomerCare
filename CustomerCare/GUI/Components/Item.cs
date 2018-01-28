using CustomerCare.STR;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CustomerCare.GUI.Components
{
    public partial class Item : UserControl
    {
        private Form context;

        [Category("Alpha")]
        public string Value { get => lbTitle.Text; set => lbTitle.Text = value; }

        [Category("Alpha")]
        public Image Icon { get => bigPic.Image; set => bigPic.Image = value; }

        [Category("Alpha")]
        public Color Bgcolor { get => panPhoto.BackColor; set => panPhoto.BackColor = value; }

        [Category("Alpha")]
        public Form NewForm { get => context; set => context = value; }

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