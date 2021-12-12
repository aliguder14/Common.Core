using System;

namespace Common.Core.DigitArr.DigitArrHelpers
{
    public class DigitArrOperatorHelper : DigitArrHelper
    {
        #region Sum Operations

        internal static DigitArr<T> SumOfBytes<T>(DigitArr<T> digits1, DigitArr<T> digits2) where T : struct, IComparable<T>
        {
            byte sum = (byte)((byte)(object)digits1.Value + (byte)(object)digits2.Value);

            return new DigitArr<T>((T)Convert.ChangeType(sum, typeof(T)));
        }

        internal static DigitArr<T> SumOfInts<T>(DigitArr<T> digits1, DigitArr<T> digits2) where T : struct, IComparable<T>
        {
            int sum = (int)((object)digits1.Value) + (int)((object)digits2.Value);

            return new DigitArr<T>((T)Convert.ChangeType(sum, typeof(T)));
        }

        internal static DigitArr<T> SumOfLongs<T>(DigitArr<T> digits1, DigitArr<T> digits2) where T : struct, IComparable<T>
        {
            long sum = (long)((object)digits1.Value) + (long)((object)digits2.Value);

            return new DigitArr<T>((T)Convert.ChangeType(sum, typeof(T)));
        }

        internal static DigitArr<T> SumOfShorts<T>(DigitArr<T> digits1, DigitArr<T> digits2) where T : struct, IComparable<T>
        {
            short sum = (short)((short)(object)digits1.Value + (short)(object)digits2.Value);

            return new DigitArr<T>((T)Convert.ChangeType(sum, typeof(T)));
        }

        #endregion Sum Operations

        #region Minus Operation

        internal static DigitArr<T> MinusOfBytes<T>(DigitArr<T> digits1, DigitArr<T> digits2) where T : struct, IComparable<T>
        {
            byte minus = (byte)((byte)(object)digits1.Value - (byte)(object)digits2.Value);

            return new DigitArr<T>((T)Convert.ChangeType(minus, typeof(T)));
        }

        internal static DigitArr<T> MinusOfInts<T>(DigitArr<T> digits1, DigitArr<T> digits2) where T : struct, IComparable<T>
        {
            int minus = (int)((object)digits1.Value) - (int)((object)digits2.Value);

            return new DigitArr<T>((T)Convert.ChangeType(minus, typeof(T)));
        }

        internal static DigitArr<T> MinusOfLongs<T>(DigitArr<T> digits1, DigitArr<T> digits2) where T : struct, IComparable<T>
        {
            long minus = (long)((object)digits1.Value) - (long)((object)digits2.Value);

            return new DigitArr<T>((T)Convert.ChangeType(minus, typeof(T)));
        }

        internal static DigitArr<T> MinusOfShorts<T>(DigitArr<T> digits1, DigitArr<T> digits2) where T : struct, IComparable<T>
        {
            short minus = (short)((short)(object)digits1.Value - (short)(object)digits2.Value);

            return new DigitArr<T>((T)Convert.ChangeType(minus, typeof(T)));
        }

        #endregion Minus Operation

        #region Multiply Operation

        internal static DigitArr<T> MuliplyOfBytes<T>(DigitArr<T> digits1, DigitArr<T> digits2) where T : struct, IComparable<T>
        {
            byte Muliply = (byte)((byte)(object)digits1.Value * (byte)(object)digits2.Value);

            return new DigitArr<T>((T)Convert.ChangeType(Muliply, typeof(T)));
        }

        internal static DigitArr<T> MuliplyOfInts<T>(DigitArr<T> digits1, DigitArr<T> digits2) where T : struct, IComparable<T>
        {
            int Muliply = (int)((object)digits1.Value) * (int)((object)digits2.Value);

            return new DigitArr<T>((T)Convert.ChangeType(Muliply, typeof(T)));
        }

        internal static DigitArr<T> MuliplyOfLongs<T>(DigitArr<T> digits1, DigitArr<T> digits2) where T : struct, IComparable<T>
        {
            long Muliply = (long)((object)digits1.Value) * (long)((object)digits2.Value);

            return new DigitArr<T>((T)Convert.ChangeType(Muliply, typeof(T)));
        }

        internal static DigitArr<T> MuliplyOfShorts<T>(DigitArr<T> digits1, DigitArr<T> digits2) where T : struct, IComparable<T>
        {
            short Muliply = (short)((short)(object)digits1.Value * (short)(object)digits2.Value);

            return new DigitArr<T>((T)Convert.ChangeType(Muliply, typeof(T)));
        }

        #endregion Multiply Operation

        #region Division Operation

        internal static DigitArr<T> DivisionOfBytes<T>(DigitArr<T> digits1, DigitArr<T> digits2) where T : struct, IComparable<T>
        {
            byte Division = (byte)((byte)(object)digits1.Value / (byte)(object)digits2.Value);

            return new DigitArr<T>((T)Convert.ChangeType(Division, typeof(T)));
        }

        internal static DigitArr<T> DivisionOfInts<T>(DigitArr<T> digits1, DigitArr<T> digits2) where T : struct, IComparable<T>
        {
            int Division = (int)((object)digits1.Value) / (int)((object)digits2.Value);

            return new DigitArr<T>((T)Convert.ChangeType(Division, typeof(T)));
        }

        internal static DigitArr<T> DivisionOfLongs<T>(DigitArr<T> digits1, DigitArr<T> digits2) where T : struct, IComparable<T>
        {
            long Division = (long)((object)digits1.Value) / (long)((object)digits2.Value);

            return new DigitArr<T>((T)Convert.ChangeType(Division, typeof(T)));
        }

        internal static DigitArr<T> DivisionOfShorts<T>(DigitArr<T> digits1, DigitArr<T> digits2) where T : struct, IComparable<T>
        {
            short Division = (short)((short)(object)digits1.Value / (short)(object)digits2.Value);

            return new DigitArr<T>((T)Convert.ChangeType(Division, typeof(T)));
        }

        #endregion Division Operation
    }
}