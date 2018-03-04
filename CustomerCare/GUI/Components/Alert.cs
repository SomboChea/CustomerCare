using System;
using System.Windows.Forms;

namespace CustomerCare.GUI.Components
{
    public partial class Alert : Form
    {
        public string Title { get; set; } = "Alert Box";
        public string BtnOK { get; set; } = "OK";
        public string BtnCancel { get; set; } = "Cancel";
        public string Message { get; set; }
        private bool _setOK = false;
        public bool isOK { get { return _setOK; } }
        //private DialogResult result = DialogResult.Cancel;

        public Alert()
        {
            InitializeComponent();
        }

        private void txtMsg_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _setOK = true;
            return;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _setOK = false;
            this.Dispose();
        }

        private void Alert_Load(object sender, EventArgs e)
        {
            this.lbTitle.Text = Title;
            this.btnOK.Text = BtnOK;
            this.btnCancel.Text = BtnCancel;
        }

        private void Alert_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult == DialogResult.OK ? DialogResult : DialogResult.Cancel;
        }
    }
}