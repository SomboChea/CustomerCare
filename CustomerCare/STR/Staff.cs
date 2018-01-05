using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCare
{
    public class Staff : People
    {
        public string Name_KH { get; set; } = null;
        public string Position { get; set; }
        public string Emp_Date { get; set; }
        public string Tel { get; set; }
        public string Tel_2 { get; set; }
        public string Tel_Com { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }
        public string Emp_Note { get; set; }
        public int Line_Id { get; set; }
        public string Other { get; set; }
    }
}