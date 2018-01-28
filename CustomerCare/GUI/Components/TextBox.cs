using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CustomerCare.GUI.Components
{
    public partial class TextBox : UserControl
    {
        [Description("Test text displayed in the textbox"), Category("Alpha")]
        public Color MyBackColor { get => txtValue.BackColor; set => txtValue.BackColor = value; }

        [Description("Test text displayed in the textbox"), Category("Alpha")]
        public Color MyBorderColor { get => this.BackColor; set => this.BackColor = value; }

        [Description("Test text displayed in the textbox"), Category("Alpha")]
        public bool MyMulti { get => txtValue.Multiline; set => txtValue.Multiline = value; }

        [Description("Test text displayed in the textbox"), Category("Alpha")]
        public string Value { get => txtValue.Text; set => txtValue.Text = value; }

        public TextBox()
        {
            InitializeComponent();
        }
    }
}