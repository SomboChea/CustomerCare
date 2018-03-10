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

            menuItem.Add(new ItemList(new frmSources(),"Sources", "Images\\home.png", menuColor[0]));
            menuItem.Add(new ItemList(new frmMum(), "Mom", "Images\\mum.png", menuColor[1]));
            panMain.Controls.Add(new Item(menuItem[0]));
            panMain.Controls.Add(new Item(menuItem[1]));

            /*
                        DataTable dt = Database.QueryModel("EXEC getRoleOptionsById " + 28);
                        Tag[] tags = new Tag[dt.Rows.Count];
                        for (int i = 0; i < tags.Length; i++)
                            tags[i] = new Tag(dt.Rows[i]["tag"] + "", dt.Rows[i]["option_name"] + "");

                        for (int j = 0; j < tags.Length; j++)
                        {
                            if (tags[j].TagName == "home")
                            {
                                menuItem.Add(new ItemList(null, tags[j].TagTitle, "Images\\home.png", menuColor[j]));
                            }
                            else if (tags[j].TagName == "call_list")
                            {
                                menuItem.Add(new ItemList(null, tags[j].TagTitle, "Images\\call_list.png", menuColor[j]));
                            }
                            else if (tags[j].TagName == "hcp")
                            {
                                Temp.frm_hcp = new frmSources();
                                menuItem.Add(new ItemList(Temp.frm_hcp, tags[j].TagTitle, "Images\\hcp.png", menuColor[j]));
                            }
                            else if (tags[j].TagName == "retail")
                            {
                                Temp.frm_retail = new frmRetail();
                                menuItem.Add(new ItemList(Temp.frm_retail, tags[j].TagTitle, "Images\\retail.png", menuColor[j]));
                            }
                            else if (tags[j].TagName == "mom")
                            {
                                Temp.frm_mom = new frmMum();
                                menuItem.Add(new ItemList(Temp.frm_mom, tags[j].TagTitle, "Images\\mum.png", menuColor[j]));
                            }
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

                */
        }

        private void picClose_Click(object sender, EventArgs e)
        {
        }

        private void btnMinz_Click(object sender, EventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Temp.frm_login.Show();
        }

        private void btnClose_MouseDown(object sender, MouseEventArgs e)
        {
            btnClose.BackColor = Color.Crimson;
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Crimson;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = panHead.BackColor;
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            App.Minimized(this);
        }

        private void btnMini_MouseEnter(object sender, EventArgs e)
        {
            btnMini.BackColor = Color.DeepSkyBlue;
        }

        private void btnMini_MouseLeave(object sender, EventArgs e)
        {
            btnMini.BackColor = panHead.BackColor;
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            Temp.frm_luanch.Show();
        }
    }
}