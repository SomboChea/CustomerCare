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
    public partial class smxClose : UserControl
    {
        public smxClose()
        {
            InitializeComponent();
        }

        [Description("Normal Image"), Category("Alpha")]
        public Image Normal { get => pClose.Image; set => pClose.Image = value; }

        [Description("Hover Image"), Category("Alpha")]
        public Image Hover { get; set; }

        [Description("Normal Color"), Category("Alpha")]
        public Color BgColor { get => pClose.BackColor; set => pClose.BackColor = value; }

        [Description("Hover Color"), Category("Alpha")]
        public Color HoverColor { get; set; }

        private Image temp = null;
        private Color colorTemp;

        private void pClose_MouseEnter(object sender, EventArgs e)
        {
            colorTemp = pClose.BackColor;
            temp = pClose.Image;
            pClose.Image = Hover;
        }

        private void pClose_MouseLeave(object sender, EventArgs e)
        {
            pClose.BackColor = colorTemp;
            pClose.Image = temp;
        }
    }
}