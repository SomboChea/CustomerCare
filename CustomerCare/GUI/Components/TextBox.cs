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
    public partial class TextBox : UserControl
    {
        
        [Description("Test text displayed in the textbox"), Category("Data")]
        public string TestColor { get=>txtValue.Text; set => this.txtValue.Text=value; }

        public string Value { get => txtValue.Text; set => txtValue.Text = Value; }

        public TextBox()
        {
            InitializeComponent();
        }
    }
}