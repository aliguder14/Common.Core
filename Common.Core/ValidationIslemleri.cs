using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Common.Core
{
    public class ValidationIslemleri
    {
        public static bool ValidTCKN(string tckn)
        {


            // İlk hane 0 veya 11 haneli değil ise veya son rakam çift sayı değilse 
            // diğer işlemler yapılmadan false döndür
            if (tckn.Length != 11)
            {
                return false;
            }

            char lastChar = tckn[10];
            int lastDigit = lastChar - '0';

            if (lastChar == '0' || !lastChar.IsDigit() || lastDigit % 2 != 0)
            {
                return false;
            }

            int sumOfFirstTenDigits = 0;

            for (int i = 0; i < tckn.Length - 1; i++)
            {
                if (!tckn[i].IsDigit())
                {
                    return false;
                }

                sumOfFirstTenDigits += tckn[i] - '0';
            }

            int sumOfOddSequenceDigits = (tckn[0] - '0') + (tckn[2] - '0') + (tckn[4] - '0') + (tckn[6] - '0') + (tckn[8] - '0');
            int sumOfEvenSequenceDigits = (tckn[1] - '0') + (tckn[3] - '0') + (tckn[5] - '0') + (tckn[7] - '0');


            if (sumOfFirstTenDigits % 10 != lastDigit || sumOfOddSequenceDigits * 8 % 10 != lastDigit)
            {
                return false;
            }

            int operationResult = (sumOfOddSequenceDigits * 7 + sumOfEvenSequenceDigits * 9);

            if (operationResult % 10 != tckn[9] - '0')
            {
                return false;
            }

            return true;
        }

        public static bool ValidTCKN(long tckn)
        {
            // TCKN 11 haneli mi kontrol et.
            int bolum = (int)(tckn / 10L.Pow(10L));

            // TCKN 11 haneli değil ise veya tek sayısı ise metotdan çık
            if (bolum == 0 || bolum >= 10 || tckn % 2 != 0)
            {
                return false;
            }
            
            int sumOfFirstTenDigits = 0;
            //int sumOfEvenSequenceDigits = 0;
            //int sumOfOddSequenceDigits = 0;
            int finalDigit = (int)(tckn % 10);

            for (long n=tckn/10; n > 0; n /= 10)
            {
                sumOfFirstTenDigits += (int)(n % 10);
            }

            long sumOfOddSequenceDigits = (tckn / 10L.Pow(10L) % 10) + (tckn / 10L.Pow(8L) % 10) + (tckn / 10L.Pow(6L) % 10) + (tckn / 10L.Pow(4L) % 10) + (tckn / 10L.Pow(2L) % 10);
            long sumOfEvenSequenceDigits = (tckn / 10L.Pow(9L) % 10) + (tckn / 10L.Pow(7L) % 10) + (tckn / 10L.Pow(5L) % 10) + (tckn / 10L.Pow(3L) % 10);

            if (sumOfFirstTenDigits % 10 != finalDigit || sumOfOddSequenceDigits * 8 % 10 != finalDigit)
            {
                return false;
            }

            long operationResult = (sumOfOddSequenceDigits * 7 + sumOfEvenSequenceDigits * 9);

            if (operationResult % 10 != (int)(tckn / 10 % 10))
            {
                return false;
            }

            return true;
        }

        public static bool ValidateEmail(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);

            return match.Success;
        }
    }
}
