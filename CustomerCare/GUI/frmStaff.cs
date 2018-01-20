using SMLOGX.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerCare
{
    public partial class frmStaff : Form
    {
        public frmStaff()
        {
            InitializeComponent();

            Database.Server = "localhost";
            Database.DBName = "CustomerCare";
            Database.Open();

            panel1.AutoScroll = false;
            panel1.HorizontalScroll.Visible = false;
            panel1.AutoScroll = true;

            //bool t=System.IO.File.Exists(function.Path_Prefix+"Staff\\computer1.png");


            function.FillDatagridviewColumn(dataGridView1, "Select top 1 * from viewStaff");
            dataGridView1.Columns["Photo"].Width = 0;
            StaffID = int.Parse(Database.GetLastId("tbl_mststaff") + "") + 1;
            //MessageBox.Show(t + "");
            panel1.MouseWheel += Panel1_MouseWheel;
        }

        private void Panel1_MouseWheel(object sender, MouseEventArgs e)
        {
            panel1_Scroll(panel1, new ScrollEventArgs(ScrollEventType.LargeDecrement, panel1.VerticalScroll.Value));
        }

        public void Clear()
        {
            function.ClearRed(this);
            function.Clear(this);
            pictureBox1.Image = Properties.Resources.employee;
            btnadd.Text = "Add";
            dthiredate.Value = DateTime.Now;
            imgPath = "";
            StaffID = int.Parse(Database.GetLastId("tbl_mststaff")+"")+1;
        }

       

        public object StaffID { get; set; }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(dataGridView1.CurrentRow.Cells["Photo"].Value + "");
            function.AutoFilltextboxfromDatagridview(dataGridView1.CurrentRow, this);
            dthiredate.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells["Hire Date"].Value + "");

            try
            {
                // Add Image
                MessageBox.Show(function.Path_Prefix + "Staff\\" + dataGridView1.SelectedRows[0].Cells["Photo"].Value+" "+File.Exists(function.Path_Prefix + "Staff\\" + dataGridView1.SelectedRows[0].Cells["Photo"].Value));
                pictureBox1.Image = Image.FromFile(function.Path_Prefix+"Staff\\"+dataGridView1.SelectedRows[0].Cells["Photo"].Value);
            }
            catch (Exception)
            {
                pictureBox1.Image = Properties.Resources.employee;
                //MessageBox.Show("");
            }
            btnadd.Text = "Update";
            imgname = dataGridView1.CurrentRow.Cells["Photo"].Value+"";
            StaffID = dataGridView1.CurrentRow.Cells["ID"].Value;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            //Database.Update("tbl_mststaff","Where ID=2", "Name,Password", "sun,som");
            function.ClearRed(this);
            if (!function.CheckExist(txtEnName, txttel1, dthiredate, cbPos))
                return;
            if (Database.QueryModel("SELECT * from tbl_mststaff where '" + txttel1.Text.Trim() + "' in (tel_per1,tel_per2) and staff_id!=" + StaffID).Rows.Count > 0)
            {
                function.SetRedbox(txttel1);
                return;

            }
            if (txttel2.Text.Trim() != "")
            {
                if (Database.QueryModel("SELECT * from tbl_mststaff where '" + txttel2.Text.Trim() + "' in (tel_per1,tel_per2) and staff_id!=" + StaffID).Rows.Count > 0)
                {
                    function.SetRedbox(txttel2);
                    return;

                }
            }
            // 
            bool Execute = true;
            if (PicChange)
                imgname = imgPath == "" ? "" : function.Upload_Photo(imgPath, function.Path_Prefix + "Staff\\");

            if (btnadd.Text == "Add")
            {
                string columns = "[name_en], [name_kh], [pos_id], [emp_date], [tel_per1], [tel_per2], [tel_com], [email], [photo], [emp_note], [other]";
                Execute = Database.Insert("tbl_mststaff", columns, txtEnName.Text, txtKhName.Text, cbPos.SelectedValue, dthiredate.Value, txttel1.Text, txttel2.Text, txttelcom.Text, txtemail.Text, imgname, txtNote.Text, txtother.Text);
            }
            if (btnadd.Text == "Update")
            {
                string columns = "[name_en], [name_kh], [pos_id], [emp_date], [tel_per1], [tel_per2], [tel_com], [email], [photo], [emp_note], [other]";
                Execute = Database.Update("tbl_mststaff", "Where staff_id=" + StaffID, columns, txtEnName.Text, txtKhName.Text, cbPos.SelectedValue, dthiredate.Value, txttel1.Text, txttel2.Text, txttelcom.Text, txtemail.Text, imgname, txtNote.Text, txtother.Text);
            }
            if (!Execute)
            {
                MessageBox.Show("Execution Failed !", "Execute", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // after process
            btnadd.Text = "Add";
            Clear();
            frmStaff_Load(null, null);
            PicChange = false;
        }

        public bool PicChange { get; set; } = false;
        public string imgname { get; set; } = "";
        public string imgPath { get; set; } = "";
        private void btnbrowse_Click(object sender, EventArgs e)
        {
            imgPath = "";
            OpenFileDialog opf = new OpenFileDialog();
            opf.Title = "Browse Staff Image ...";
            opf.Filter = "Image PNG (*.png)|*.png|Image JPG (*.jpg)|*.jpg";
            //opf.AutoUpgradeEnabled = true;
            //opf.CheckFileExists = true;
            //opf.CheckPathExists = true;
            //opf.DereferenceLinks = true;
            opf.Multiselect = false;
            //opf.ShowHelp = true;
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = opf.FileName;
                imgPath = opf.FileName;
                PicChange = true;
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (txtsearch.Text.Trim() == "")
            {
                frmStaff_Load(null, null);
            }
            else
            {
                function.FillGridviewWithoutDataTable("select * from viewStaff where [Name in Khmer] like '%"+txtsearch.Text+"%' and [Name in English] like '%"+txtsearch.Text+"%'", dataGridView1);
            }
        }

        private void panel1_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.NewValue == 0)
                return;
            if (e.NewValue > (panel1.VerticalScroll.Maximum - panel1.VerticalScroll.LargeChange))
            {
                function.FillGridviewWithoutDataTable("select * from viewStaff where ID<"+dataGridView1.Rows[dataGridView1.Rows.Count].Cells["ID"].Value, dataGridView1);
            }
            
        }
        private void frmStaff_Load(object sender, EventArgs e)
        {
            function.FillGridviewWithoutDataTable("Select top 20 * from viewStaff order by ID desc", dataGridView1);
            function.FillComboBox(cbPos, "pos_en", "pos_id", "Select * from tbl_pos");
            //function.Upload_Pic(@"C:\Users\DELL\Desktop\OldRam.PNG", function.Path_Prefix+"Staff\\");
            //function.Upload_Photo(@"C:\Users\DELL\Desktop\OldRam.PNG", function.Path_Prefix + "Staff\\");
        }
    }
    public class function : frmHcp.helper
    {
       
    }
}
