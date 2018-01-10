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
using CustomerCare.GUI.Components;
using CustomerCare.STR;

namespace CustomerCare
{
    public partial class frmMain : Form
    {
        private string[] menu = { "Dashboard", "Call List", "Hospital", "Retail", "Staff", "Mum", "Kids", "Users", "Other" };
        private Color[] menuColor = { Color.DeepSkyBlue, Color.DeepPink, Color.DodgerBlue, Color.Crimson, Color.DeepPink, Color.DeepSkyBlue, Color.Chocolate, Color.Crimson, Color.DeepPink, Color.DodgerBlue, Color.Aqua, Color.Bisque };
        private List<ItemList> menuItem = new List<ItemList>();

        private string[] tags = { "home", "call_list", "hcp", "retail", "staff", "mum", "kid", "product", "category", "address", "position", "user" };

        public frmMain()
        {
            InitializeComponent();

            for (int j = 0; j < tags.Length; j++)
            {
                if (tags[j] == "home")
                    menuItem.Add(new ItemList(new frmHcp(), "Dashboard", "Images\\home.png", menuColor[j]));
                else if (tags[j] == "call_list")
                    menuItem.Add(new ItemList(new frmHcp(), "Call List", "Images\\call_list.png", menuColor[j]));
                else if (tags[j] == "hcp")
                    menuItem.Add(new ItemList(new frmHcp(), "HCP", "Images\\hcp.png", menuColor[j]));
                else if (tags[j] == "retail")
                    menuItem.Add(new ItemList(new frmRetail(), "Retail", "Images\\retail.png", menuColor[j]));
                else if (tags[j] == "mum")
                    menuItem.Add(new ItemList(new frmMum(), "Mum", "Images\\mum.png", menuColor[j]));
                else if (tags[j] == "kid")
                    menuItem.Add(new ItemList(new frmKid(), "Kid", "Images\\kid.png", menuColor[j]));
                else if (tags[j] == "staff")
                    menuItem.Add(new ItemList(new frmStaff(), "Staff", "Images\\staff.png", menuColor[j]));
                else if (tags[j] == "address")
                    menuItem.Add(new ItemList(new frmHcp(), "Address", "Images\\address.png", menuColor[j]));
                else if (tags[j] == "position")
                    menuItem.Add(new ItemList(new frmHcp(), "Position", "Images\\position.png", menuColor[j]));
                else if (tags[j] == "products")
                    menuItem.Add(new ItemList(new frmHcp(), "Products", "Images\\product.png", menuColor[j]));
                else if (tags[j] == "category")
                    menuItem.Add(new ItemList(new frmHcp(), "Category", "Images\\category.png", menuColor[j]));
                else if (tags[j] == "user")
                    menuItem.Add(new ItemList(new frmHcp(), "Users", "Images\\user.png", menuColor[j]));
            }

            for (int i = 0; i < menuItem.Count; i++)
            {
                panMain.Controls.Add(new Item(menuItem[i]));
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            App.ExitAll();
        }
    }
}