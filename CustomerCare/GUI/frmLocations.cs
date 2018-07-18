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
    public partial class frmLocations : Form
    {
        public frmLocations()
        {
            Database.Open();
            InitializeComponent();
            FullMode.Fullscreen(this);

            init(cmbpro, cmbdis, cmbcom);
            refresh();
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
            //dataLocations.DataSource = null;
            //// Query Column Province , District , Commune , CID, DID ,Pid
            //dataLocations.DataSource = Database.QueryModel("select p.name Province,d.name as District , c.name as Commune, c.id cid ,d.id did, p.id pid from (select * from locations where master_id=0) p left JOIN (select * from locations ) d on d.master_id=p.id left join (select * from locations ) c on c.master_id=d.id");

            //// hide pid , did , cid
            //dataLocations.Columns["cid"].Visible = false;
            //dataLocations.Columns["did"].Visible = false;
            //dataLocations.Columns["pid"].Visible = false;
            
        }

        private void refresh()
        {
            cbpro.DataSource = null;
            listprovince.DataSource = null;
            Helpers.FillComboBox(cbpro,"name","id","Select * from locations where master_id=0");
            //Helpers.FillComboBox(listprovince,"")
            Helpers.FillComboBox(listprovince, "name", "id", "Select * from locations where master_id=0");

            ReloadView();
            cbcomm.DataSource = null;
            cbdis.DataSource = null;

        }



        private void Cbdis_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbcomm.DataSource = null;
            Helpers.FillComboBox(cbcomm, "name", "id", "Select * from locations where master_id="+cbdis.SelectedValue);

        }

        private string setlocation(ComboBox cb,string location,string master)
        {
           
            if (cb.Text.Trim() == "")
            {
               
                return "";
            }
            string id = Database.QueryScalar("Exec dbo.setLocation '" +location +"' , "+master)+"";
            return id;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {

            string pid = setlocation(cbpro, cbpro.Text, "0");
            if (pid == "")
            {
                MessageBox.Show("Please Insert Province ");
                goto refresh;
            }
            string did = setlocation(cbdis, cbdis.Text, pid);
            if (did == "")
            {
                MessageBox.Show("Updated Province ");
                goto refresh;
            }
            string cid = setlocation(cbcomm, cbcomm.Text, did);
            if (cid == "")
            {
                MessageBox.Show("Updated District ");
                goto refresh;
            }
        refresh:

            refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //if (dataLocations.SelectedRows.Count <= 0)
            //    return;
            //string communeid = dataLocations.SelectedRows[0].Cells["cid"].Value+"";
            //string districtid= dataLocations.SelectedRows[0].Cells["did"].Value + "";
            //string provinceid= dataLocations.SelectedRows[0].Cells["pid"].Value + "";

            // action remove

            // end action
            
            refresh();
        }

        private void listprovince_SelectedIndexChanged(object sender, EventArgs e)
        {
            listcomm.DataSource = null;
            listdistrict.DataSource = null;

            Helpers.FillComboBox(listdistrict, "name", "id", "Select * from locations where master_id=" + listprovince.SelectedValue);

        }

        private void listdistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            listcomm.DataSource = null;
            Helpers.FillComboBox(listcomm, "name", "id", "Select * from locations where master_id=" + listdistrict.SelectedValue);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            refresh();
        }

        private void Cbpro_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbcomm.DataSource = null;
            cbdis.DataSource = null;

            Helpers.FillComboBox(cbdis, "name", "id", "Select * from locations where master_id="+cbpro.SelectedValue);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
