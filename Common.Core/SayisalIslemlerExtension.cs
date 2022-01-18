using System;
using System.Collections.Generic;

namespace Common.Core
{
    public static class SayisalIslemlerExtension
    {
        #region Sqrt Methods

        public static double Sqrt(this double num)
        {
            return Math.Sqrt(num);
        }

        public static int Sqrt(this int num)
        {
            return (int)Math.Sqrt(num);
        }

        public static long Sqrt(this long num)
        {
            return (long)Math.Sqrt(num);
        }

        public static short Sqrt(this short num)
        {
            return (short)Math.Sqrt(num);
        }

        public static byte Sqrt(this byte num)
        {
            return (byte)Math.Sqrt(num);
        }

        #endregion Sqrt Methods

        #region Power Methods

        public static double Pow(this double num, double power)
        {
            return Math.Pow(num, power);
        }

        public static int Pow(this int num, int power)
        {
            return (int)Math.Pow(num, power);
        }

        public static long Pow(this long num, long power)
        {
            return (long)Math.Pow(num, power);
        }

        public static short Pow(this short num, short power)
        {
            return (short)Math.Pow(num, power);
        }

        public static byte Pow(this byte num, byte power)
        {
            return (byte)Math.Pow(num, power);
        }

        #endregion Power Methods

        public static bool Contains(this int num, int containsNum)
        {
            if (num < containsNum)
            {
                return false;
            }

            if (num == containsNum)
            {
                return true;
            }

            int digitCountOfContainsNum = containsNum.DigitCount();

            for (int n = num; n >= 0; n /= 10)
            {

                int mod = n % 10.Pow(digitCountOfContainsNum);


                if (mod == containsNum)
                {
                    return true;
                }
            }

            // Döngüden çıkıldığı zaman containsNum içeren sayı bulunamadığı anlamına gelmektedir.
            return false;
        }

        public static int DigitCount(this int num)
        {
            int digitCount = 0;
            for (int n = num; n > 0; n /= 10)
            {
                digitCount++;
            }

            return digitCount;
        }

        public static bool EndWith(this int num, int endedNum)
        {
            if (endedNum > num)
            {
                return false;
            }
            else if (endedNum == num)
            {
                return true;
            }

            int i = 1;
            int n = num % 10.Pow(i);

            while (endedNum >= n)
            {
                if (n == endedNum)
                {
                    return true;
                }

                i++;
                n = num % 10.Pow(i);
            }

            // Döngüden çıkıldığı zaman endedNum ile biten sayı bulunamadığı anlamına gelmektedir.
            return false;
        }

        public static int MaxOfDigit(this int num)
        {
            int maxDigit = 0;

            for (int n = num; n > 0; n /= 10)
            {
                int digit = n % 10;

                if (digit > maxDigit)
                {
                    maxDigit = digit;
                }
            }

            return maxDigit;
        }

        public static int MinOfDigit(this int num)
        {
            int minDigit = 9;

            for (int n = num; n > 0; n /= 10)
            {
                int digit = n % 10;

                if (digit < minDigit)
                {
                    minDigit = digit;
                }
            }

            return minDigit;
        }

        public static bool StartWith(this int num, int startedNum)
        {
            int i = 0;
            int n = num / 10.Pow(i);

            while (startedNum <= n)
            {
                if (n == startedNum)
                {
                    return true;
                }

                i++;
                n = num / 10.Pow(i);
            }

            // Döngüden çıkıldığı zaman startedNum ile başlayan sayı bulunamadığı anlamına gelmektedir.
            return false;
        }

        public static int SumOfDigits(this int num)
        {
            int sumOfDigits = 0;

            for (int n = num; n > 0; n /= 10)
            {
                int digit = n % 10;
                sumOfDigits += digit;
            }

            return sumOfDigits;
        }

        public static int SubNumber(this int num, int start, int size)
        {
            List<int> digitList = new List<int>();

            for (int n = num; n > 0; n /= 10)
            {
                int digit = n % 10;
                digitList.Insert(0, digit);
            }

            int j = start;
            int subNumber = 0;
            for (int i = size; i > 0; i--)
            {
                subNumber += (digitList[j] * 10.Pow(i - 1));
            }

            return subNumber;

        }

        public static int FirstSubNumber(this int num, int size) => num / 10.Pow(num.DigitCount() - size);
        public static int LastSubNumber(this int num, int size) => num % 10.Pow(size);

        public static int NumberOfLastZero(this int num)
        {

            int zeroCount = 0;

            for (int n = num; n % 10 == 0; n /= 10)
            {

                zeroCount++;

            }

            return zeroCount;
        }


    }
}