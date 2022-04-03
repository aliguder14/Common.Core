using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Core
{
    public struct TurkishDateTime
    {
        private readonly DateTime _dt;
        private readonly CultureInfo _turkceCulture;

        public int Year => _dt.Year;

        public int Month => _dt.Month;
        public int Hour => _dt.Hour;
        public int Minute => _dt.Minute;
        public int Second => _dt.Second;
        public string MonthName => _dt.GetMonthName(_turkceCulture);
        public string WeekName => _dt.GetWeekName(_turkceCulture);

        public DateTime DateTime => _dt;


        public TurkishDateTime(DateTime dt)
        {
            _dt = dt;
            _turkceCulture = new CultureInfo("tr-TR");
    }

        public TurkishDateTime(int day,int month,int year)
        {
            _dt = new DateTime(year, month, day);
            _turkceCulture = new CultureInfo("tr-TR");

        }

        public TurkishDateTime(string strDateTime)
        {
            try
            {
                _turkceCulture = new CultureInfo("tr-TR");
                _dt = Convert.ToDateTime(strDateTime, _turkceCulture);
            }
            catch (Exception)
            {

                throw new FormatException("Invalid DateTime Format");
            }
        }

        public static implicit operator TurkishDateTime(DateTime dt)
        {
            return new TurkishDateTime(dt);
        }

        public static explicit operator DateTime(TurkishDateTime tdt)
        {
            return tdt.DateTime;
        }

        public override string ToString()
        {
            return _dt.ToString("dd.MM.yyyy HH:mm:ss");
        }

        public string LongDateTimeString()
        {
            return _dt.ToString("dd MMM yyyy, dddd", _turkceCulture);

        }
    }
}
