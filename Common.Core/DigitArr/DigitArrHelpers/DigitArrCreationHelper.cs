using System.Collections.Generic;

namespace Common.Core.DigitArr.DigitArrHelpers
{
    public class DigitArrCreationHelper : DigitArrHelper
    {
        internal static List<byte> CreateIntDigitArr(int num, List<byte> digitList)
        {
            digitList = new List<byte>();

            for (int n = num; n > 0; n /= 10)
            {
                byte rakam = (byte)(n % 10);
                digitList.Insert(0, rakam);
            }

            return digitList;
        }

        internal static List<byte> CreateLongDigitArr(long num, List<byte> digitList)
        {
            digitList = new List<byte>();

            for (long n = num; n > 0; n /= 10)
            {
                byte rakam = (byte)(n % 10);
                digitList.Insert(0, rakam);
            }

            return digitList;
        }

        internal static List<byte> CreateShortDigitArr(short num, List<byte> digitList)
        {
            digitList = new List<byte>();

            for (short n = num; n > 0; n /= 10)
            {
                byte rakam = (byte)(n % 10);
                digitList.Insert(0, rakam);
            }

            return digitList;
        }

        internal static List<byte> CreateByteDigitArr(byte num, List<byte> digitList)
        {
            digitList = new List<byte>();

            for (byte n = num; n > 0; n /= 10)
            {
                byte rakam = (byte)(n % 10);
                digitList.Insert(0, rakam);
            }

            return digitList;
        }
    }
}