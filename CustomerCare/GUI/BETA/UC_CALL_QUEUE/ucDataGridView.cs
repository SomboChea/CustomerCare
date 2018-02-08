using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMLOGX.Core;

namespace CustomerCare.GUI.BETA.UC_CALL_QUEUE
{
    public partial class ucDataGridView : UserControl
    {
        public ucDataGridView(int idx)
        {
            InitializeComponent();
            SampleData(idx);
        }

        private string[] data_one = { "C001", "Chea Sambo", "07/02/1996", "OK" };
        private string[] data_two = { "C002", "Chea Somben", "05/06/1998", "OK" };
        private string[] data_three = { "C003", "Chea Ponlork", "07/02/2007", "OK" };

        private void SampleData(int idx)
        {
            string[][] data = { data_one, data_two, data_three };

            dataGridView.Rows.Add(data[idx]);
            dataGridView.Rows.Add(data[idx]);
            dataGridView.Rows.Add(data[idx]);
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                new frmCallDetail(dataGridView.SelectedRows[0].Cells[1].Value + "").ShowDialog();
            }
        }
    }
}