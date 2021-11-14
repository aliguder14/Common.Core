using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Core.HelperClasses
{
    public abstract class DigitArr<T> : IEnumerable<T> where T : struct,IComparable<T>
    {
        public abstract T Value { get; }
        protected List<T> RakamList { get; set; }

        public DigitArr(T t)
        {

        }

        public DigitArr(IEnumerable<T> gelenRakamlar)
        {
             RakamList = gelenRakamlar.ToList();
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in RakamList)
            {
                yield return item;
            }
        }

        public T this[int index]
        {
            get { return RakamList[index]; }
            set { RakamList[index] = value; }
        }

        public int Length => RakamList.Count;

        public long LongLength => RakamList.LongCount();





        public static bool operator ==(DigitArr<T> rakamlar1, DigitArr<T> rakamlar2)
        {
            if ((object)rakamlar1 != null && (object)rakamlar2 != null)
            {
                return rakamlar1.Value.Equals(rakamlar2.Value);
            }

            else
            {
                return (object)rakamlar1 == (object)rakamlar2;
            }
        }

        public static bool operator !=(DigitArr<T> rakamlar1, DigitArr<T> rakamlar2)
        {
            if ((object)rakamlar1 != null && (object)rakamlar2 != null)
            {
                return !rakamlar1.Value.Equals(rakamlar2.Value);

            }

            else
            {
                return (object)rakamlar1 != (object)rakamlar2;

            }
        }

        public static bool operator >(DigitArr<T> rakamlar1, DigitArr<T> rakamlar2)
        {
            if ((object)rakamlar1 != null && (object)rakamlar2 != null)
            {
                return rakamlar1.Value.CompareTo(rakamlar2.Value) == 1;
            }

            else
            {
                return false;

            }
        }

        public static bool operator <(DigitArr<T> rakamlar1, DigitArr<T> rakamlar2)
        {
            if ((object)rakamlar1 != null && (object)rakamlar2 != null)
            {
                return rakamlar1.Value.CompareTo(rakamlar2.Value) == -1;

            }

            else
            {
                return false;
            }
        }

        public static bool operator >=(DigitArr<T> rakamlar1, DigitArr<T> rakamlar2)
        {
            if ((object)rakamlar1 != null && (object)rakamlar2 != null)
            {
                
                return rakamlar1.Value.CompareTo(rakamlar2.Value) == 1 || 
                    rakamlar1.Value.CompareTo(rakamlar2.Value) == 0;

            }

            else
            {
                return false;
            }
        }

        public static bool operator <=(DigitArr<T> rakamlar1, DigitArr<T> rakamlar2)
        {
            if ((object)rakamlar1 != null && (object)rakamlar2 != null)
            {
                return rakamlar1.Value.CompareTo(rakamlar2.Value) == -1 ||
                    rakamlar1.Value.CompareTo(rakamlar2.Value) == 0;
            }

            else
            {
                return false;
            }
        }



        IEnumerator IEnumerable.GetEnumerator()
        {
            
            return this.GetEnumerator();
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }


        public bool Equals(DigitArr<T> other)
        {
            return this == other;
        }
    }
}
