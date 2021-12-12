using System;

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

        #endregion


        #region Power Methods
        public static double Pow(this double num, double kuvvet)
        {
            return Math.Pow(num, kuvvet);
        }

        public static int Pow(this int num, int kuvvet)
        {
            return (int)Math.Pow(num, kuvvet);
        }

        public static long Pow(this long num, long kuvvet)
        {
            return (long)Math.Pow(num, kuvvet);
        }

        public static short Pow(this short num, short kuvvet)
        {
            return (short)Math.Pow(num, kuvvet);
        }
        public static byte Pow(this byte num, byte kuvvet)
        {
            return (byte)Math.Pow(num, kuvvet);
        }

        #endregion
    }
}
