using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCare
{
    public class Reporting
    {
        private static Reporting _instanceReport = null;
        public static IEnumerable<Reporting> GetReport()
        {
            if (_instanceReport == null)
                _instanceReport = new Reporting();
            yield return _instanceReport;
        }

        public void get()
        {

        }

    }

    class Report
    {
        public int Id { get; set; }
        public void get() => Reporting.GetReport().GetEnumerator();

        public void getReporter()
        {
            Reporter p = new Reporter();
            
        }

    }

    class Reporter : Meanitry
    {
        public Reporter()
        {
            SetInstance(this);
        }

        public void print()
        {
            Reporter.GetInstance().SetInstance(this);
            Console.WriteLine("Report has printed!");
        }
    }
}
