using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMLOGX.Core
{
    public class AutoAlert : IAutoAlert
    {
        private string msg;
        private string when;

        public void Alert(string message, string when)
        {
            this.msg = message;
            this.when = when;
        }
    }
}