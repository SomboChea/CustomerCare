using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerCare.GUI.BETA.UC_CALL_QUEUE
{
    public partial class ucPregnent : UserControl
    {
        public ucPregnent()
        {
            InitializeComponent();
        }

        public ucPregnent(string title)
        {
            InitializeComponent();
            this.txtVal.Text = title;
        }
    }
}