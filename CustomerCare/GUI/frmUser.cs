using SMLOGX.Core;
using System.Windows.Forms;

namespace CustomerCare
{
    public partial class frmUser : MetroFramework.Forms.MetroForm
    {
        
        public frmUser()
        {
            Database.Open();

            InitializeComponent();
            
        }
        
    }
}