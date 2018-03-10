using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerCare.STR
{
    public class Temp
    {
        public static int logger_id { get; set; }
        public static string logger_fullname { get; set; }
        public static Form frm_login { get; set; }
        public static Form frm_luanch { get { return new GUI.frmQuickLuanch(); } }
        public static Form frm_hcp { get; set; }
        public static Form frm_retail { get; set; }
        public static Form frm_mom { get; set; }
    }
}