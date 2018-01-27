using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CustomerCare.GUI.Components
{
    
    public partial class TextBox : UserControl
    {
        //[Description("Test text displayed in the textbox"), Category("Alpha")]
        public string TestColor { get => txtValue.Text; set => this.txtValue.Text = value; }

        //[Description("Test text displayed in the textbox"), Category("Alpha")]
        public System.Drawing.Region Reg { get =>this.Region; set => this.Region=value; }

        public string Value { get => txtValue.Text; set => txtValue.Text = value; }

        public TextBox()
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            InitializeComponent();
        }
    }
}