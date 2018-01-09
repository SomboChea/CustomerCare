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

namespace CustomerCare
{
    public partial class frmMain : Form
    {
        private string[] menu = { "Dashboard", "Call List", "Hospital", "Retail", "Staff", "Mum", "Kids", "Users", "Other" };
        private Color[] menuColor = { Color.DeepSkyBlue, Color.DeepPink, Color.DodgerBlue, Color.Crimson, Color.DeepPink, Color.DeepSkyBlue, Color.Crimson, Color.DeepPink, Color.DodgerBlue };

        public frmMain()
        {
            InitializeComponent();

            Item[] t = new Item[menu.Length];
            for (int i = 0; i < menu.Length; i++)
            {
                t[i] = new Item(menu[i], menuColor[i], "Images\\" + (i) + ".png", new frmHcp());
                panMain.Controls.Add(t[i]);
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            App.ExitAll();
        }
    }
}