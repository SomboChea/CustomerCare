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
    public partial class ImageButton : UserControl
    {
        public ImageButton()
        {
            InitializeComponent();
        }

        [Description("Back Color Item"), Category("Alpha")]
        public Color BackColorImageButton { get => BackColor; set => BackColor = value; }

        [Description("Button Icon"), Category("Alpha")]
        public Image ImageIcon { get => IconLabel.Image; set => IconLabel.Image = value; }

        [Description("TextLabel Text"), Category("Alpha")]
        public string LabelText { get => TextLabel.Text; set => TextLabel.Text = value; }

        [Description("TextLabel Color"), Category("Alpha")]
        public Color TextLabelColor { get => TextLabel.ForeColor; set => TextLabel.ForeColor = value; }

        [Description("TextLabel BackColor"), Category("Alpha")]
        public Color TextLabelBackColor { get => TextLabel.BackColor; set => TextLabel.BackColor = value; }
    }
}