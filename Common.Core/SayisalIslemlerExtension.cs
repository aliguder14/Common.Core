using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Core
{
    public static class SayisalIslemlerExtension
    {
        
       public static double Pow(this double num,double kuvvet)
        {
            return Math.Pow(num, kuvvet);
        }

        public static double Sqrt(this double num)
        {
            return Math.Sqrt(num);
        }

        public static int Pow(this int num, int kuvvet)
        {
            return (int)Math.Pow(num, kuvvet);
        }

        public static long Pow(this long num, long kuvvet)
        {
            return (long)Math.Pow(num, kuvvet);
        }
    }
}
