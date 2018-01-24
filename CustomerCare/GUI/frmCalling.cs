using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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