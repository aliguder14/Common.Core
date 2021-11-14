using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Core
{
    public static class DateTimeExtensions
    {
        public static int GetCentury(this ref DateTime dt)
        {

            return (dt.Year / 100) + 1;
        }

        public static int GetBininciYil(this DateTime dt)
        {

            return (dt.Year / 1000) + 1;

        }

        public static int GetDecade(this DateTime dt)
        {

            return (dt.Year / 10) + 1;
        }

        public static int GetWeekNumber(this DateTime dt)
        {

            return dt.DayOfWeek == DayOfWeek.Sunday ? 7 : ((int)dt.DayOfWeek);
        }
    }
}
