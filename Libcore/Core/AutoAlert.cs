using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMLOGX.Core
{
    public interface IAutoAlert
    {
        void Alert(string message, string when);
    }
}