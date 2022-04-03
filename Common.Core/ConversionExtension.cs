using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Core
{
    public static class ConversionExtension
    {
        public static int ToIntManually(this double num)
        {

            int stageCount = 0;


            double n = num;

            while (n % 1 != 0)
            {
                n *= 10;
                stageCount++;
            }

            return (int)(n/ 10.Pow(stageCount));

        }

        public static int ToIntManually(this char ch)
        {

            return ch -'0';

        }

        public static int ToIntManually(this string st)
        {


            int sifirSayisi = st.Length - 1;
            int result = 0;
            foreach (char ch in st)
            {
                int digit = ch - '0';

                if (digit >= 0 && digit <= 9)
                {
                    result += digit * (int)Math.Pow(10, sifirSayisi);
                    sifirSayisi--;
                }

                else
                {
                    throw new FormatException("Invalid Format for convertion");
                }
            }

            return result;

        }

        public static char ToCharManually(this int digit)
        {

            return (char)('0' + digit);
           
        }

        public static DateTime ToDateTime(this string strDateTime)
        {

            return Convert.ToDateTime(strDateTime);
        }

        public static DateTime ToDateTime(this string strDateTime, CultureInfo cultureInfo)
        {

            return Convert.ToDateTime(strDateTime,cultureInfo);
        }

    }
}
