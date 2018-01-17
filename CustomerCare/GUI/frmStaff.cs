using SMLOGX.Core;
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
    public partial class frmStaff : Form
    {
        public frmStaff()
        {
            InitializeComponent();

            Database.Server = "localhost";
            Database.DBName = "CustomerCare";
            Database.Open();

          
        }
    }
}
