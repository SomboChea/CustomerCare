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
    public partial class frmLocations2 : Form
    {
        public frmLocations2()
        {
            InitializeComponent();
            FullMode.Fullscreen(this);

            init(cmbpro, cmbdis, cmbcom);
        }

        private ComboBox cbpro, cbdis, cbcomm;
        public string ProID { get; set; }
        public string DisID { get; set; }
        public string ComID { get; set; }


        private void init(ComboBox pro,ComboBox dis,ComboBox comm)
        {
            cbpro = pro;
            cbdis = dis;
            cbcomm = comm;

            cbpro.SelectedIndexChanged += Cbpro_SelectedIndexChanged;
            cbdis.SelectedIndexChanged += Cbdis_SelectedIndexChanged;
        }

        void ReloadView()
        {

        }

        private void refresh()
        {
            cbcomm.DataSource = null;
            cbdis.DataSource = null;
            cbpro.DataSource = null;

            //Helpers.FillComboBox(cbpro,);
            //Helpers.FillComboBox(cbdis,);
            //Helpers.FillComboBox(cbcomm,);
        }

        

        private void Cbdis_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbcomm.DataSource = null;
            //Helpers.FillComboBox(cbcomm,);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
           
           
        }

        private void Cbpro_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbcomm.DataSource = null;
            cbdis.DataSource = null;
            
            //Helpers.FillComboBox(cbdis,)
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
