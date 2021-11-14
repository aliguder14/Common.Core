using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Core
{
    public class SplitInfo
    {
        internal List<char> DelimeterChars { get; set; }
        internal List<string> DelimetedStrings { get; set; }

        internal SplitInfo()
        {

        }

    }
}
