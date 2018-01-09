using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerCare.GUI.Components
{
    public partial class Item : UserControl
    {
        public Item()
        {
            InitializeComponent();
        }

        private Form context;

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
            context.Show();
        }
    }
}