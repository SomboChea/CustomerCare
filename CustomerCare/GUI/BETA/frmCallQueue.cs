using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerCare.GUI.BETA
{
    public partial class frmCallQueue : Form
    {
        public frmCallQueue()
        {
            InitializeComponent();
            initPages();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState != FormWindowState.Maximized ? FormWindowState.Maximized : FormWindowState.Normal;
            btnMax.Image = this.WindowState == FormWindowState.Maximized ? Properties.Resources.Maximize_WF : Properties.Resources.Box_32_2;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Colors State [0] is Normal [1] is Active
        private Color[] colorState = { Color.DeepPink, Color.Crimson };

        private int stateLast = -1;
        private UC_CALL_QUEUE.ucDataGridView[] pages = new UC_CALL_QUEUE.ucDataGridView[3];

        private void initPages()
        {
            pages[0] = new UC_CALL_QUEUE.ucDataGridView(0);
            pages[1] = new UC_CALL_QUEUE.ucDataGridView(1);
            pages[2] = new UC_CALL_QUEUE.ucDataGridView(2);
        }

        private void clickState(int idx)
        {
            if (stateLast.Equals(idx))
                return;

            colorStateReset();
            switch (idx)
            {
                case 0:
                    btnNew.BackColor = colorState[1];
                    break;

                case 1:
                    btnPregnent.BackColor = colorState[1];
                    break;

                case 2:
                    btnStep.BackColor = colorState[1];
                    break;
            }
            if (!stateLast.Equals(-1))
                panContent.Controls.Remove(pages[stateLast]);

            pages[idx].Dock = DockStyle.Fill;
            panContent.Controls.Add(pages[idx]);

            stateLast = idx;
        }

        private void colorStateReset()
        {
            btnNew.BackColor = colorState[0];
            btnPregnent.BackColor = colorState[0];
            btnStep.BackColor = colorState[0];
        }

        private void btnPregnent_Click(object sender, EventArgs e)
        {
            clickState(1);
        }

        private void btnNewmom_Click(object sender, EventArgs e)
        {
            clickState(0);
        }

        private void btnFollowup_Click(object sender, EventArgs e)
        {
            clickState(2);
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

        private void btnMax_MouseEnter(object sender, EventArgs e)
        {
            btnMax.BackColor = Color.DodgerBlue;
        }

        private void btnMax_MouseLeave(object sender, EventArgs e)
        {
            btnMax.BackColor = panHead.BackColor;
        }
    }
}