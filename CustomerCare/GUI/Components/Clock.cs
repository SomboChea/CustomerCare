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
    public partial class Clock : UserControl
    {
        public Clock()
        {
            InitializeComponent();
            timer.Start();
            lbDate.Text = DateTime.Now.ToString("dd/MMMM/yyyy");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.TimeOfDay.ToString("hh\\:mm\\:ss");
        }
    }
}