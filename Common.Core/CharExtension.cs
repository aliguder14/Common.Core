using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Core
{
    public static class CharExtension
    {
        public static bool IsDigit(this char ch)
        {
            if (ch <= '9' && ch >= '0')
            {
                return true;
            }

            return false;

        }
    }
}
