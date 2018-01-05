using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerCare.Core
{
    public interface BaseHelper
    {
        void BindGridView(DataGridView dg);

        void ForceExit(Form context);

        void ExitThread(Form context);
    }
}