using System.Windows.Forms;

namespace CustomerCare.GUI.Components
{
    public partial class ComOverlay : Form
    {
        public ComOverlay(Form front)
        {
            InitializeComponent();
            this.Show();
            front.ShowDialog();
            //front.Close();
            this.Close();
        }
    }
}