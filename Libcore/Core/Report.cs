using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMLOGX.Core
{
    public   class Report
    {
        private static Report _report;
        public static Report get()
        {
            if (_report == null)
            {
                _report = new Report();
            }
            return _report;
        }
        public void showReport(ReportDocument rep,List<object> source)
        {
            frmReport frm = new frmReport();
            CrystalReportViewer report = frm.getviewer();
            rep.SetDataSource(source);
            report.ReportSource = rep;
            report.RefreshReport();
            frm.ShowDialog();
        }
    }
}
