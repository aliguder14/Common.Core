using Common.Core.DigitArr;
using Xunit;

namespace Common.Core.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(45)]
        [InlineData(51)]
        public void TestRakamArr(int num)
        {
            DigitArr<int> digitArr = num;
            DigitArr<int> digitArr2 = 56;
            DigitArr<int> digitArr3 = digitArr + digitArr2;
            System.Console.WriteLine(digitArr.Value);
        }
    }
}