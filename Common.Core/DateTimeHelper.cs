using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Core
{
    public class DateTimeHelper
    {
        public static IEnumerable<DateTime> GetBusinessDays(int year, IEnumerable<DateTime> bankHolidays)
        {

            DateTime firstDayOfYear = new DateTime(year, 1, 1);
            DateTime lastDayOfYear = new DateTime(year, 12, 31);

            for (DateTime day = firstDayOfYear; day <= lastDayOfYear; day.AddDays(1))
            {

                // Gün haftasonları ve resmi tatiller içinde ise iş günlerine ekleme
                if ((day.DayOfWeek == DayOfWeek.Saturday || day.DayOfWeek == DayOfWeek.Sunday)
                    || bankHolidays.Contains(day))
                {
                    continue;
                }
            
                yield return day;

            }


        }
    }
}
