using Common.Core.DigitArr;
using System;
using System.Collections.Generic;
using System.Linq;
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

            string st = pangrams(@"We promptly judged antique ivory buckles for the next prize");

            int gecisSayisi =pageCount(6, 2);
        }


        [Theory]
        [InlineData("07:05:45PM")]
        [InlineData("12:01:00PM")]
        public void timeConversion(string s)
        {


            if (DateTime.TryParse(s, out DateTime dt))
            {
                string st = dt.ToString("HH:mm:ss");
            }

            miniMaxSum(new List<int> { 1, 2, 3, 4, 5 });

            ulong sayi = 342432;
            long sayi2 = Convert.ToInt64((~sayi));

        }

        public static void miniMaxSum(List<int> arr)
        {
            long sumOfMin = arr.Select(x => (long)x).OrderBy(x => x).Take(arr.Count - 1).Sum();
            long sumOfMax = arr.Select(x => (long)x).OrderBy(x => x).Skip(1).Sum();
            arr.Chunk(2);
            //for (int i = 0; i < arr.Count; i++)
            //{
            //    if (i > 0)
            //    {
            //        sumOfMax += arr[i];
            //    }

            //    if (i < arr.Count - 1)
            //    {
            //        sumOfMin = +arr[i];
            //    }
            //}

            Console.Write($"{sumOfMin} {sumOfMax}");


        }


        public static void plusMinus(List<int> arr)
        {
            double length = arr.Count;
            double positiveCount = 0;
            double negativeCount = 0;
            double zeroCount = 0;


            foreach (var sayiItem in arr)
            {
                if (sayiItem > 0)
                {
                    positiveCount++;
                }

                else if (sayiItem < 0)
                {
                    negativeCount++;
                }

                else
                {
                    zeroCount++;
                }
            }

            Console.WriteLine((positiveCount / length).ToString("0.#######"));
            Console.WriteLine((negativeCount / length).ToString("0.#######"));
            Console.WriteLine((zeroCount / length).ToString("0.#######"));

        }

        public static List<int> matchingStrings(List<string> strings, List<string> queries)
        {

            List<int> results = new List<int>();

            foreach (string query in queries)
            {

                int result = strings.Where(x => x == query).Count();
                results.Add(result);

            }

            return results;
        }

        public static int lonelyinteger(List<int> a)
        {

            Dictionary<int, int> dicCount = new Dictionary<int, int>();

            foreach (int i in a)
            {
                if (dicCount.ContainsKey(i))
                {
                    dicCount[i]++;
                }

                else
                {
                    dicCount[i] = 1;
                }
            }

            return dicCount.FirstOrDefault(x => x.Value == 1).Key;

        }

        public static int diagonalDifference(List<List<int>> arr)
        {

            int i = 0;
            int j = arr.Count - 1;
            int sum1 = 0;
            int sum2 = 0;

            foreach (var arrItem in arr)
            {
                sum1 += arrItem[i];
                sum2 += arrItem[j];

                i++;
                j--;
            }

            return Math.Abs(sum1 - sum2);


        }

        public static string pangrams(string s)
        {
            string lowerLetters = "abcdefghijklmnopqrstuvwxyz";
            string upperLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";


            char[] chars = s.Where(c => lowerLetters.Contains(c) || upperLetters.Contains(c)).Select(c => char.ToLower(c)).ToArray();



            if (lowerLetters.All(c => chars.Contains(c)))
            {
                return "pangram";
            }
            else
            {
                return "not pangram";

            }

        }

        public static string twoArrays(int k, List<int> A, List<int> B)
        {

            int sum1 = A.Sum();
            int sum2 = B.Sum();


            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] + B[i] < k)
                {
                    return "NO";
                }
            }

            return "YES";


        }


        [Theory]
        [InlineData(5,4)]
        [InlineData(6,2)]
        public static int pageCount(int n, int p)
        {
            int gecis1 = 0;
            int gecis2 = 0;

            for (int i = 1; i <= n; i++)
            {

                if (i == p)
                {
                    break;
                }

                if (i % 2 == 1)
                {
                    gecis1++;
                }
            }

            for (int j = n; j >= 1; j--)
            {

                if (j == p)
                {
                    break;
                }

                if (j % 2 == 0)
                {
                    gecis2++;
                }
            }

            return (int)Math.Min(gecis1, gecis2);
        }

        public static int countPairs(List<int> numbers, int k)
        {

            int satisfyCount = 0;
            List<List<int>> pairs = new List<List<int>>();
            
            for (int i = 0; i < numbers.Count; i++)
            {

                bool iceriyorMu = false;

                for (int j = 0; j < numbers.Count; j++)
                {
                    if (numbers[i] + k == numbers[j] && (numbers[i] != numbers[j] || i==j))
                    {
                        iceriyorMu = true;
                        break;
                    }
                }

                if (iceriyorMu)
                {
                    satisfyCount++;
                }



            }


            return satisfyCount;

        }

        public static long closestSquaredDistance(List<int> x, List<int> y)
        {
            


            //long toplam = (long)Math.Pow((x[x.Count - 1] - y[y.Count - 1]), 2) +
            //    (long)Math.Pow((y[y.Count - 1] - y[y.Count - 2]), 2);

            List<int> farklar = new List<int>();
            
            for (int i = 0; i < x.Count; i++)
            {
                if (i != 0)
                {
                    int fark = Math.Abs(x[i] - x[i - 1]);
                    farklar.Add(fark);
                }
            }

            int ilkMinimumFark = farklar.Min();

            farklar = new List<int>();

            for (int i = 0; i < y.Count; i++)
            {
                if (i != 0)
                {
                    int fark = Math.Abs(y[i] - y[i - 1]);
                    farklar.Add(fark);
                }
            }

            int İkinciMinimumFark = farklar.Min();


            return (long)Math.Pow(ilkMinimumFark, 2) +
                (long)Math.Pow(İkinciMinimumFark, 2);

        }

    }
}