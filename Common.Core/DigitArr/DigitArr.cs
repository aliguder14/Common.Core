using Common.Core.DigitArr.DigitArrHelpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;

namespace Common.Core.DigitArr
{
    public class DigitArr<T> : IEnumerable<byte>, IComparable<T> where T : struct, IComparable<T>
    {
        #region Fields

        private static readonly IReadOnlyDictionary<Type, string> _typeNames = new Dictionary<Type, string>()
        {
            { typeof(int), "Int" },
            { typeof(long), "Long" },
            { typeof(short), "Short" },
            { typeof(byte), "Byte" },
            { typeof(BigInteger), "BigInteger" }
        };
        
        private readonly T _currentValue;

        #endregion Fields

        #region Properties

        public int Length => _digitList.Count;

        public T Value
        {
            get { return _currentValue; }
        }

        private readonly List<byte> _digitList;

        #endregion Properties

        #region Ctor

        public DigitArr(T tValue)
        {
            string creationMethodName = $"Create{_typeNames[typeof(T)]}DigitArr";
            MethodInfo builderMethod1 = typeof(DigitArrCreationHelper).GetMethod(creationMethodName, BindingFlags.NonPublic | BindingFlags.Static);
            _digitList = (List<byte>)builderMethod1.Invoke(null, new object[] { tValue, _digitList });
            _currentValue = tValue;
            //SetDigitArrayValue();
        }

        public DigitArr(IEnumerable<byte> incomingDigits)
        {
            _digitList = incomingDigits.ToList();
            _currentValue = SetDigitArrayValue();
        }

        #endregion Ctor

        #region Indexer
        public byte this[int index]
        {
            get { return _digitList[Length - index - 1]; }
        }
       
        #endregion

        #region Implicit Operators

        public static implicit operator DigitArr<T>(T value)
        {
            return new DigitArr<T>(value);
        }

        public static implicit operator DigitArr<T>(List<byte> incomingDigits)
        {
            return new DigitArr<T>(incomingDigits);
        }

        public static implicit operator DigitArr<T>(byte[] incomingDigits)
        {
            return new DigitArr<T>(incomingDigits);
        }

        #endregion Implicit Operators

        #region Explicit Operators

        public static explicit operator byte[](DigitArr<T> digitArr)
        {
            return digitArr.ToArray();
        }

        public static explicit operator List<byte>(DigitArr<T> digitArr)
        {
            return digitArr._digitList;
        }

        public static explicit operator T(DigitArr<T> digitArr)
        {
            return digitArr.Value;
        }

        #endregion Explicit Operators

        #region Artithmetic Operator Loadings

        public static DigitArr<T> operator -(DigitArr<T> digits1, DigitArr<T> digits2)
        {
            if ((object)digits1 == null || (object)digits2 == null)
            {
                return null;
            }
            else
            {
                string inputMethodName = $"MinusOf{_typeNames[typeof(T)]}s";
                MethodInfo builderMethod = typeof(DigitArrOperatorHelper).GetMethod(inputMethodName, BindingFlags.NonPublic | BindingFlags.Static);
                var method = builderMethod.MakeGenericMethod(typeof(T));
                DigitArr<T> sum = (DigitArr<T>)method.Invoke(null, new object[] { digits1, digits2 });
                return sum;
            }
        }

        public static DigitArr<T> operator *(DigitArr<T> digits1, DigitArr<T> digits2)
        {
            if ((object)digits1 == null || (object)digits2 == null)
            {
                return null;
            }
            else
            {
                string inputMethodName = $"MultiplyOf{_typeNames[typeof(T)]}s";
                MethodInfo builderMethod = typeof(DigitArrOperatorHelper).GetMethod(inputMethodName, BindingFlags.NonPublic | BindingFlags.Static);
                var method = builderMethod.MakeGenericMethod(typeof(T));
                DigitArr<T> sum = (DigitArr<T>)method.Invoke(null, new object[] { digits1, digits2 });
                return sum;
            }
        }

        public static DigitArr<T> operator /(DigitArr<T> digits1, DigitArr<T> digits2)
        {
            if ((object)digits1 == null || (object)digits2 == null)
            {
                return null;
            }
            else
            {
                string inputMethodName = $"DivisionOf{_typeNames[typeof(T)]}s";
                MethodInfo builderMethod = typeof(DigitArrOperatorHelper).GetMethod(inputMethodName, BindingFlags.NonPublic | BindingFlags.Static);
                var method = builderMethod.MakeGenericMethod(typeof(T));
                DigitArr<T> sum = (DigitArr<T>)method.Invoke(null, new object[] { digits1, digits2 });
                return sum;
            }
        }

        public static DigitArr<T> operator +(DigitArr<T> digits1, DigitArr<T> digits2)
        {
            if ((object)digits1 == null || (object)digits2 == null)
            {
                return null;
            }
            else
            {
                string inputMethodName = $"SumOf{_typeNames[typeof(T)]}s";
                MethodInfo builderMethod = typeof(DigitArrOperatorHelper).GetMethod(inputMethodName, BindingFlags.NonPublic | BindingFlags.Static);
                var method = builderMethod.MakeGenericMethod(typeof(T));
                DigitArr<T> sum = (DigitArr<T>)method.Invoke(null, new object[] { digits1, digits2 });
                return sum;
            }
        }

        #endregion Artithmetic Operator Loadings

        #region Logical Operator Overloadings

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

        #endregion Logical Operator Overloadings

        #region Methods

        public int CompareTo(T tOther)
        {
            return this.Value.CompareTo(tOther);
        }

        public byte DigitAt(int sequence)
        {
            return this[sequence - 1];
        }

        public bool Equals(DigitArr<byte> other)
        {
            return this.Value.Equals(other.Value);
        }

        public int GetDigitPlace(byte digit)
        {
            int digitPlace = 1;
            foreach (var digitItem in this)
            {
                if (digitItem == digit)
                {
                    return digitPlace;
                }

                digitPlace++;
            }

            return -1;
        }

        public IEnumerable<int> GetDigitPlaces(byte digit)
        {
            int digitPlace = 1;
            foreach (var digitItem in this)
            {
                if (digitItem == digit)
                {
                    yield return digitPlace;
                }

                digitPlace++;
            }
        }

        public int GetDigitPlaceWithDecimalPlace(byte digit)
        {
            int digitPlace = 1;
            foreach (var digitItem in this)
            {
                if (digitItem == digit)
                {
                    return digitPlace;
                }

                digitPlace *= 10;
            }

            return 0;
        }

        public IEnumerable<int> GetDigitPlaceWithDecimalPlaces(byte digit)
        {
            int digitPlace = 1;
            foreach (var digitItem in this)
            {
                if (digitItem == digit)
                {
                    yield return digitPlace;
                }

                digitPlace *= 10;
            }
        }

        public IEnumerator<byte> GetEnumerator()
        {
            foreach (var item in _digitList)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerable<int> GetIndexes(byte digit)
        {
            int index = 0;
            foreach (var digitItem in this)
            {
                if (digitItem == digit)
                {
                    yield return index;
                }

                index++;
            }
        }

        public int IndexOf(byte digit)
        {
            int index = 0;
            foreach (var digitItem in this)
            {
                if (digitItem == digit)
                {
                    return index;
                }

                index++;
            }

            return -1;
        }

        public DigitArr<T> Reverse()
        {
            _digitList.Reverse();
            
            return new DigitArr<T>(_digitList.ToList());
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }

        private T SetDigitArrayValue()
        {
            string getMethodName = $"Get{_typeNames[typeof(T)]}Value";
            MethodInfo builderMethod2 = typeof(DigitArrGetHelper).GetMethod(getMethodName, BindingFlags.NonPublic | BindingFlags.Static);

            T value = (T)builderMethod2.Invoke(null, new object[] { _digitList });
            return value;
        }

        #endregion Methods
    }
}