using SMLOGX.Core;
using System;
using System.Windows.Forms;

namespace CustomerCare
{
    internal class Function : Helpers
    {
        public string name;

        public static ComboBox ComboPro { get; set; }
        public static ComboBox ComboDis { get; set; }
        public static ComboBox ComboCom { get; set; }
        public static Control TextAddress { get; set; }

        public static void SetCombo(ComboBox pro, ComboBox Dis, ComboBox Com, Control Txt)
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
            FillComboBox(ComboCom, "name", "id", "Select * from viewCommunes where refer_id=" + ComboDis.SelectedValue);
        }

        private static void ComboPro_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboDis.DataSource = null;
            ComboCom.DataSource = null;
            FillComboBox(ComboDis, "name", "id", "Select * from viewDistricts where refer_id=" + ComboPro.SelectedValue);
        }

        public static string AddAddress()
        {
            string id;
            id = Database.QueryScalar("EXEC InsertLocation '" + ComboPro.Text + "' , 0") + "";
            id = Database.QueryScalar("EXEC InsertLocation '" + ComboDis.Text + "' , " + id) + "";
            id = Database.QueryScalar("EXEC InsertLocation '" + ComboCom.Text + "' , " + id) + "";
            id = Database.QueryScalar("EXEC InsertLocation '" + TextAddress.Text + "' , " + id) + "";
            return id;
        }
    }
}