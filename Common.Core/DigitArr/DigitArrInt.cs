using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Core.HelperClasses
{
    public sealed class DigitArrInt : DigitArr<int>
    {

        public override int Value
        {
            get
            {
                int sayiDegeri = 0;
                int kuvvetDegeri = RakamList.Count-1;

                foreach (var rakam in base.RakamList)
                {

                    sayiDegeri += (rakam * (int)Math.Pow(10, kuvvetDegeri));
                    kuvvetDegeri--;

                }

                return sayiDegeri;
            }
        }

        #region Ctor
        public DigitArrInt(int num)
            :base(num)
        {
            RakamList = new List<int>();

            for (long n = num; n > 0; n /= 10)
            {
                int rakam = (int)(n % 10);
                RakamList.Insert(0, rakam);
            }
        }

        public DigitArrInt(IEnumerable<int> gelenRakamlar)
          : base(gelenRakamlar)
        {
            
        }

        #endregion

        #region Overloaded Operators

        public static implicit operator DigitArrInt(int num)
        {
            var rakamlar = new List<int>();

            for (long n = num; n > 0; n /= 10)
            {
                byte rakam = (byte)(n % 10);
                rakamlar.Insert(0, rakam);

            }
            
            return new DigitArrInt(rakamlar);
        }


        public static implicit operator DigitArrInt(List<int> gelenRakamlar)
        {
            return new DigitArrInt(gelenRakamlar);
        }

        public static implicit operator DigitArrInt(int[] gelenRakamlar)
        {
            return new DigitArrInt(gelenRakamlar);
        }


        public static DigitArrInt operator +(DigitArrInt rakamlar1, DigitArrInt rakamlar2)
        {
            if ((object)rakamlar1 == null || (object)rakamlar2 == null)
            {
                return null;
            }

            else
            {
                return rakamlar1.Value + rakamlar2.Value;
            }
        }

        public static DigitArrInt operator -(DigitArrInt rakamlar1, DigitArrInt rakamlar2)
        {

            if ((object)rakamlar1 == null || (object)rakamlar2 == null)
            {
                return null;
            }

            else
            {
                return rakamlar1.Value - rakamlar2.Value;
            }
        }

        public static DigitArrInt operator *(DigitArrInt rakamlar1, DigitArrInt rakamlar2)
        {

            if ((object)rakamlar1 == null || (object)rakamlar2 == null)
            {
                return null;
            }

            else
            {
                return rakamlar1.Value * rakamlar2.Value;
            }
        }

        public static DigitArrInt operator /(DigitArrInt rakamlar1, DigitArrInt rakamlar2)
        {

            if ((object)rakamlar1 == null || (object)rakamlar2 == null)
            {
                return null;
            }

            else
            {
                return rakamlar1.Value / rakamlar2.Value;
            }
        }

        public static DigitArrInt operator %(DigitArrInt rakamlar1, DigitArrInt rakamlar2)
        {

            if ((object)rakamlar1 == null || (object)rakamlar2 == null)
            {
                return null;
            }

            else
            {
                return rakamlar1.Value % rakamlar2.Value;
            }
        }


        #endregion

       
    }
}
