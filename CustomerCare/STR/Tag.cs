using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCare.STR
{
    internal class Tag
    {
        public Tag(string tagName, string tagTitle)
        {
            TagName = tagName;
            TagTitle = tagTitle;
        }

        public string TagName { get; set; }
        public string TagTitle { get; set; }
    }
}