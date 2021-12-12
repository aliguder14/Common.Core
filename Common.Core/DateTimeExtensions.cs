using System;
using System.Globalization;

namespace Common.Core
{
    public static class DateTimeExtensions
    {
        public static int GetCentury(this DateTime dt)
        {

            return (dt.Year / 100) + 1;
        }

        public static int GetThousandYear(this DateTime dt)
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

        public static DateTime AddWeeks(this DateTime dt, double days)
        {

            return dt.AddDays(days * 7);
        }

        public static string GetMothnName(this DateTime dt)
        {
            return dt.ToString("MMMM");
        }

        public static string GetMonthName(this DateTime dt, CultureInfo cultureInfo)
        {
            return cultureInfo.DateTimeFormat.GetMonthName(dt.Month);
        }

        public static string GetWeekName(this DateTime dt)
        {
            return dt.ToString("dddd");
        }

        public static string GetWeekName(this DateTime dt, CultureInfo cultureInfo)
        {
            return cultureInfo.DateTimeFormat.GetDayName(dt.DayOfWeek);
        }
    }
}
