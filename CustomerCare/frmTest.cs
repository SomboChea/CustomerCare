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
    public partial class frmTest : Form
    {

        public frmTest()
        {
            InitializeComponent();
            Database.Server = "localhost";
            Database.DBName = "CustomerCare";
            Database.Open();
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            function.SetCombo(cbProvince, cbDistrict, cbCommune, textBox1);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            function.OKClick();
        }
    }

    class function : Helpers
    {
        public static ComboBox ComboPro { get; set; }
        public static ComboBox ComboDis { get; set; }
        public static ComboBox ComboCom { get; set; }
        public static Control TextAddress { get; set; }

        public static void SetCombo(ComboBox pro,ComboBox Dis,ComboBox Com,Control Txt)
        {
            ComboPro = pro;
            ComboDis = Dis;
            ComboCom = Com;
            TextAddress = Txt;

            ComboPro.SelectedIndexChanged += ComboPro_SelectedIndexChanged;
            ComboDis.SelectedIndexChanged += ComboDis_SelectedIndexChanged;
            FillComboBox(ComboPro, "name", "id", "Select * from viewProvinces");
        }

        private static void ComboDis_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ComboCom.DataSource = null;
            FillComboBox(ComboCom, "name", "id", "Select * from viewCommunes where refer_id="+ComboDis.SelectedValue);
        }

        private static void ComboPro_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ComboDis.DataSource = null;
            ComboCom.DataSource = null;
            FillComboBox(ComboDis, "name", "id", "Select * from viewDistricts where refer_id="+ComboPro.SelectedValue);
        }

        public static string OKClick()
        {
            string id;
            id = Database.QueryScalar("EXEC check_location '"+ComboPro.Text+"' , 0")+"";
            id = Database.QueryScalar("EXEC check_location '" + ComboDis.Text + "' , "+id) + "";
            id = Database.QueryScalar("EXEC check_location '" + ComboCom.Text + "' , "+id) + "";
            id = Database.QueryScalar("Insert into tbl_location(name,refer_id) values('"+TextAddress.Text+"',"+id+");select ident_current('tbl_location');")+"";
            return id;
        }
    }
}
