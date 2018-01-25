using System;
using System.Windows.Forms;

namespace CustomerCare
{
    public partial class frmCalling : Form
    {
        public frmCalling()
        {
            InitializeComponent();
        }

        private void frmCalling_Load(object sender, EventArgs e)
        {
            textBox1.ContextMenuStrip = contextMenuStrip1; ;
        }
    }
}