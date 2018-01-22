using System.Drawing;
using System.Windows.Forms;

namespace CustomerCare.STR
{
    public class ItemList
    {
        public ItemList()
        {
        }

        public ItemList(Form context, string title, string image, Color backColor)
        {
            Context = context;
            Title = title;
            Image = image;
            BackColor = backColor;
        }

        public Form Context { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public Color BackColor { get; set; } = Color.DodgerBlue;
    }
}