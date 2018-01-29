using CustomerCare.GUI.Components;
using CustomerCare.STR;
using SMLOGX.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CustomerCare
{
    public partial class frmMain : Form
    {
        private Color[] menuColor = { Color.DeepSkyBlue, Color.DeepPink, Color.DodgerBlue, Color.Crimson, Color.DeepPink, Color.DeepSkyBlue, Color.Chocolate, Color.Crimson, Color.DeepPink, Color.DodgerBlue, Color.Aqua, Color.Bisque };
        private List<ItemList> menuItem = new List<ItemList>();

        public frmMain()
        {
            InitializeComponent();

            DataTable dt = Database.QueryModel("EXEC getRoleOptionsById " + 28);
            Tag[] tags = new Tag[dt.Rows.Count];
            for (int i = 0; i < tags.Length; i++)
                tags[i] = new Tag(dt.Rows[i]["tag"] + "", dt.Rows[i]["option_name"] + "");

            for (int j = 0; j < tags.Length; j++)
            {
                if (tags[j].TagName == "home")
                    menuItem.Add(new ItemList(null, tags[j].TagTitle, "Images\\home.png", menuColor[j]));
                else if (tags[j].TagName == "call_list")
                    menuItem.Add(new ItemList(new frmCallList(), tags[j].TagTitle, "Images\\call_list.png", menuColor[j]));
                else if (tags[j].TagName == "hcp")
                    menuItem.Add(new ItemList(new frmHcp(), tags[j].TagTitle, "Images\\hcp.png", menuColor[j]));
                else if (tags[j].TagName == "retail")
                    menuItem.Add(new ItemList(new frmRetail(), tags[j].TagTitle, "Images\\retail.png", menuColor[j]));
                else if (tags[j].TagName == "mom")
                    menuItem.Add(new ItemList(new frmMum(), tags[j].TagTitle, "Images\\mum.png", menuColor[j]));
                else if (tags[j].TagName == "kid")
                    menuItem.Add(new ItemList(new frmKid(), tags[j].TagTitle, "Images\\kid.png", menuColor[j]));
                else if (tags[j].TagName == "staff")
                    menuItem.Add(new ItemList(new frmStaff(), tags[j].TagTitle, "Images\\staff.png", menuColor[j]));
                else if (tags[j].TagName == "address")
                    menuItem.Add(new ItemList(new frmAddress(), tags[j].TagTitle, "Images\\address.png", menuColor[j]));
                else if (tags[j].TagName == "position")
                    menuItem.Add(new ItemList(new frmPosition(), tags[j].TagTitle, "Images\\position.png", menuColor[j]));
                else if (tags[j].TagName == "products")
                    menuItem.Add(new ItemList(new frmProduct(), tags[j].TagTitle, "Images\\product.png", menuColor[j]));
                else if (tags[j].TagName == "user")
                    menuItem.Add(new ItemList(new frmUser(), tags[j].TagTitle, "Images\\user.png", menuColor[j]));
            }

            for (int i = 0; i < menuItem.Count; i++)
                panMain.Controls.Add(new Item(menuItem[i]));
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            //App.ExitAll();
            this.Dispose();
            Temp.frm_login.Show();
        }

        private void btnMinz_Click(object sender, EventArgs e)
        {
            App.Minimized(this);
        }
    }
}