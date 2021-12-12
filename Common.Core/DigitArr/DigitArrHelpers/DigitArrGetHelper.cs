using System;
using System.Collections.Generic;
using System.Numerics;

namespace Common.Core.DigitArr.DigitArrHelpers
{
    public class DigitArrGetHelper : DigitArrHelper
    {
        internal static int GetIntValue(List<byte> digitList)
        {
            int value = 0;
            int powerValue = digitList.Count - 1;

            foreach (var digit in digitList)
            {
                value += (digit * (int)Math.Pow(10, powerValue));
                powerValue--;
            }

            return value;
        }

        internal static long GetLongValue(List<byte> digitList)
        {
            long value = 0;
            long powerValue = digitList.Count - 1;

            foreach (var digit in digitList)
            {
                value += (digit * (long)Math.Pow(10, powerValue));
                powerValue--;
            }

            return value;
        }

        internal static BigInteger GetBigIntegerValue(List<byte> digitList)
        {
            BigInteger value = 0;
            int powerValue = digitList.Count - 1;

            foreach (var digit in digitList)
            {
                value += (digit * BigInteger.Pow(10, powerValue));
                powerValue--;
            }

            return value;
        }

        internal static short GetShortValue(List<byte> digitList)
        {
            short value = 0;
            short powerValue = (short)(digitList.Count - 1);

            foreach (var digit in digitList)
            {
                value += (short)(digit * Math.Pow(10, powerValue));
                powerValue--;
            }

            return value;
        }

        internal static byte GetByteValue(List<byte> digitList)
        {
            byte value = 0;
            byte powerValue = (byte)(digitList.Count - 1);

            foreach (var digit in digitList)
            {
                value += (byte)(digit * Math.Pow(10, powerValue));
                powerValue--;
            }

            return value;
        }
    }
}