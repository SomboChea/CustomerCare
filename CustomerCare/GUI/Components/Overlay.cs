using System.Windows.Forms;

namespace CustomerCare.GUI.Components
{
    public partial class Overlay : Form
    {
        public Overlay()
        {
            InitializeComponent();
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
        }
    }
}