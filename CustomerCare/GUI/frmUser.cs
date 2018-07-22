using SMLOGX.Core;

namespace CustomerCare.GUI
{
    public partial class FrmUser : MetroFramework.Forms.MetroForm
    {
        
        public FrmUser()
        {
            Database.Open();

            InitializeComponent();
            
        }
        
    }
}