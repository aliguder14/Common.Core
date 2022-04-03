using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Common.Core.Test
{
    public class HackerRankTest
    {
        public static long flippingBits(long n)
        {
            return 0 - (~n);
        }
        public static int lonelyinteger(List<int> a)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            foreach (var num in a)
            {
                if (dic.ContainsKey(num))
                {
                    dic[num]++;
                }

                else
                {
                    dic[num] = 1;
                }
            }

            return dic.FirstOrDefault(x => x.Value == 1).Key;
        }


        public static string pangrams(string s)
        {

            char firstLowerChar = 'a';
            List<char> lowerCases = new List<char>();
            char upperLowerChar = 'A';
            List<char> upperCases = new List<char>();

            for (char c = firstLowerChar; c <= 'z'; c++)
            {
                lowerCases.Add(c);
            }



            s = s.Trim().Replace(" ", string.Empty);

            bool includeAllLowerCases = lowerCases.All(x => s.Contains(x) || s.Contains(char.ToUpper(x)));

            if (includeAllLowerCases)
            {
                return "pangram";
            }

            else
            {
                return "not pangram";
            }
        }

        public static int birthday(List<int> s, int d, int m)
        {
            int skippedSize = 0;
            int satisfiedCount = 0;
            int count = 0;





            do
            {
                var temp = s.Skip(skippedSize).Take(m);
                int sum = temp.Sum();
                count = temp.Count();

                if (sum == d)
                {
                    satisfiedCount++;
                }


            } while (count == 2);

            return satisfiedCount;
        }

        private static bool IsPalindrom(int number)
        {
            long tersCevrilenSayi = 0;
            for (long n = number; n > 0; n /= 10)
            {
                byte rakam = (byte)(n % 10);
                tersCevrilenSayi = tersCevrilenSayi * 10 + rakam;
            }

            if (number == tersCevrilenSayi)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        private static int SumPalindromNumbers(int maxNumber)
        {
            // IsPalindrom metodundan yararlanarak palindrom sayiyi tespit ediniz.
            // 0'dan verilen maxNumber degerine kadarina olan asal ve palindrom sayıların toplamını donen kodu yazınız.
            int sumOfPalindrom = 0;
            for (int i = 0; i <= maxNumber; i++)
            {
                if (IsPalindrom(i))
                {
                    sumOfPalindrom += i;
                }
            }

            return sumOfPalindrom;
        }

        public static bool CheckPolindrom(string value)
        {
            int sonInds = value.Length - 1;

            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] != value[sonInds])
                {
                    return false;
                }

                sonInds--;
            }

            return true;

        }


        public static bool DortSayiCompare(int a1, int a2, int b1, int b2)
        {
            if ((a1 < b1 && a1 < b2) && (a2 < b1 && a2 < b2))
            {
                return false;
            }

            //else if(a2 < b1 && a2 < b2)
            //{
            //    return false;
            //}


            if ((a1 > b1 && a1 > b2) && (a2 > b1 && a2 > b2))
            {
                return false;
            }

            //else if (a2 > b1 && a2 > b2)
            //{
            //    return false;
            //}


            return true;
        }


        public static List<List<int>> MergeSchedule(List<List<int>> scheduleList)
        {

            var mergedList = new List<List<int>>();
            bool mergedBulunduMu = false;
            int i = 0;

            while (i < scheduleList.Count - 1)
            {

                if (DortSayiCompare(scheduleList[i][0], scheduleList[i][1], scheduleList[i + 1][0], scheduleList[i + 1][1]))
                {
                    mergedList.Add(new List<int>() { scheduleList[i][0], scheduleList[i + 1][1] });
                    mergedBulunduMu = true;
                    i += 2;
                }

                else
                {
                    mergedList.Add(new List<int>() { scheduleList[i][0], scheduleList[i][1] });
                    mergedBulunduMu = false;
                    i++;

                }

            }

            if (mergedBulunduMu)
            {
                mergedList.Add(new List<int>() { scheduleList[scheduleList.Count - 1][0], scheduleList[scheduleList.Count - 1][1] });

            }

            return mergedList;
        }


        public static string FindRepetitiveMaximumNumber(List<string> salesManager, List<int> salesCount)
        {
            var maxAndRepeatedNumbers = salesCount.GroupBy(x => x).Select(x => new
            {
                Number = x.Key,
                Count = x.Count()
            }).OrderByDescending(x => x.Number).ThenByDescending(x => x.Count);

            int findNumber = maxAndRepeatedNumbers.FirstOrDefault().Number;
            List<int> findIndexes = new List<int>();
            List<string> findManagers = new List<string>();

            for (int i = 0; i < salesManager.Count; i++)
            {
                if (salesCount[i] == findNumber)
                {
                    //findIndexes.Add(i);
                    findManagers.Add(salesManager[i]);


                }
            }

            return findManagers.OrderBy(x => x).FirstOrDefault() + " " + findNumber;
        }

        public static List<int> gradingStudents(List<int> grades)
        {

            for (int i = 0; i < grades.Count; i++)
            {
                
                int grade = grades[i];
                int finalGrade = grade;

                if (grade % 5 < 3)
                {
                    finalGrade = grade;
                }

                else
                {
                    finalGrade = grade + (5 - (grade % 5)); 
                }

                grades[i] = finalGrade < 40 ? grade : finalGrade;
            }

            return grades;
        }

        public static int sockMerchant(int n, List<int> ar)
        {

            Dictionary<int, int> dicConut = new Dictionary<int, int>();
            int pairCount = 0;

            foreach (var num in ar)
            {
                if (dicConut.ContainsKey(num))
                {
                    dicConut[num]++;
                }

                else
                {
                    dicConut[num] = 1;
                }

                if (dicConut[num] != 0 && dicConut[num] % 2 == 0)
                {
                    pairCount++;
                }
            }

            return pairCount;
        }

        public static string balancedSums(List<int> arr)
        {
            int middeIndex = arr.Count / 2;
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < middeIndex; i++)
            {
                leftSum +=arr[i];
            }

            for (int i = middeIndex+1; i < arr.Count; i++)
            {
                rightSum +=arr[i];
            }

            if (leftSum == rightSum)
            {
                return "YES";
            }

            else
            {
                return "NO";
            }
        }

        public static int superDigit(string n, int k)
        {

            //StringBuilder sb = new StringBuilder();


            //for (int i = 1; i <= k; i++)
            //{
            //    sb.Append(n);
            //}

            //string newString = sb.ToString();

            BigInteger newNum = BigInteger.Parse(n);

            BigInteger sumOfDigits = RakamlariTopla(newNum) * k;

            while (sumOfDigits > 10)
            {
                sumOfDigits = RakamlariTopla(sumOfDigits);
            }

            return (int)sumOfDigits;

        }

        public static BigInteger RakamlariTopla(string str)
        {
            BigInteger sum = 0;
            for (int i=0; i < str.Length; i++)
            {
                BigInteger rakam = str[i] - '0';
                sum += rakam;
            }

            return sum;
        }


        public static BigInteger RakamlariTopla(BigInteger total)
        {
            BigInteger rakamlarinToplami = 0;
            for (BigInteger n = total; n > 0; n /= 10)
            {
                BigInteger rakam = n % 10;
                rakamlarinToplami += rakam;
            }

            return rakamlarinToplami;
        }

        public static string isValid(string s)
        {
            char[] distinctChars = s.Distinct().ToArray();
            //char[] chars = s.ToArray();
            bool isValid = IsValidForAllChars(s);

            if (isValid)
            {
                return "YES";
            }

            else
            {


                for (int i = 0; i < distinctChars.Length; i++)
                {

                    int indx = s.IndexOf(distinctChars[i]);
                    string modifiedStr = s.Remove(indx, 1);

                    //string modifiedStr = s.Replace(distinctChars[i], '\0',);
                    isValid = IsValidForAllChars(modifiedStr);

                    if (isValid)
                    {
                        return "YES";
                    }

                }

                return "NO";
                

            }

        }


        public static bool IsValidForAllChars(string s)
        {
            Dictionary<char, int> dicCharsCount = new Dictionary<char, int>();

            foreach (var ch in s)
            {
                if (!dicCharsCount.ContainsKey(ch))
                {
                    dicCharsCount[ch] = 1;
                }

                else
                {
                    dicCharsCount[ch]++;
                }

            }

            int firstCharCount = dicCharsCount[s[0]];

            bool allCharsCountEqaul = dicCharsCount.Values.All(x => x == firstCharCount);

            return allCharsCountEqaul;
           
        }

        public static int maxMin(int k, List<int> arr)
        {
            arr.Sort();
            int minimumFairnes = int.MaxValue;
            int arrLength = arr.Count;

            for (int i = 0; (arrLength - i) >= k; i++)
            {

                int firstNum = arr[i];
                int lastNum = arr[i+k-1];

                int fairness = lastNum-firstNum;

                if (fairness < minimumFairnes)
                {
                    minimumFairnes = fairness;
                }
            }

            return minimumFairnes;


        }


        public static int FindMaxMin(IEnumerable<int> arr)
        {

            int max = arr.ElementAt(arr.Count()-1);
            int min = arr.ElementAt(0);


            return Math.Abs(max - min);


        }

        public static int findMedian(List<int> arr)
        {
            arr.Sort();

            int meadianInds = arr.Count / 2;

            int median = arr[meadianInds];

            if (median % 2 != 0)
            {
                return median;
            }

            for (int i = meadianInds+1; i < arr.Count; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    return arr[i];
                }
            }

            return 0;

        }

        public static string gridChallenge(List<string> grid)
        {


            //for (int j = 0; j < grid[0].Length - 1; j++)
            //{
            //    if (grid[0][j] > grid[0][j + 1])
            //    {
            //        return "NO";
            //    }
            //}

            char[] chrArr = grid[0].ToCharArray();
            Array.Sort(chrArr);
            grid[0] = new string(chrArr);

            for (int i = 1; i < grid.Count; i++)
            {

                chrArr = grid[i].ToCharArray();
                Array.Sort(chrArr);
                grid[i] = new string(chrArr);

                for (int j = 0; j < grid[i].Length-1; j++)
                {
                    if (grid[i][j] < grid[i-1][j])
                    {
                        return "NO";
                    }
                }




            }

            return "YES";
        }

        public static string caesarCipher(string s, int k)
        {

            char[] cipherChar = new char[s.Length];
            int lowerLetterIncreaseNo = 'a' - 1;
            int UpperLetterIncreaseNo = 'A' - 1;


            for (int i = 0; i < cipherChar.Length; i++)
            {
                if (char.IsLetter(s[i]))
                {
                    char cipherCh = (char)(s[i] + k);

                    if (char.IsUpper(s[i]))
                    {
                        int letterNo = (cipherCh - UpperLetterIncreaseNo) % 26;

                        if (letterNo == 0)
                        {
                            cipherChar[i] = 'Z';
                        }

                        else
                        {
                            cipherChar[i] = (char)('A' + (letterNo - 1));
                        }
                    }

                    else
                    {
                        int letterNo = (cipherCh - lowerLetterIncreaseNo) % 26;

                        if (letterNo == 0)
                        {
                            cipherChar[i] = 'z';
                        }

                        else
                        {
                            cipherChar[i] = (char)('a' + (letterNo - 1));
                        }
                    } // else of if (char.IsUpper(s[i]))




                    //if (char.IsLower(s[i]) && cipherCh > 'z')
                    //{
                    //    cipherChar[i] = (char)('a' + ((cipherCh - 'z')-1));
                    //}

                    //else if (char.IsUpper(s[i]) && cipherCh > 'Z')
                    //{
                    //    cipherChar[i] = (char)('A' + ((cipherCh - 'Z') - 1));

                    //}

                    //else
                    //{
                    //    cipherChar[i] = (char)(s[i] + k); 
                    //}
                }

                else
                {
                    cipherChar[i] = s[i];

                }
            }

            return new string(cipherChar);
        }


        private static long NumberOfSetBits(ulong i)
        {
            i = i - ((i >> 1) & 0x5555555555555555UL);
            i = (i & 0x3333333333333333UL) + ((i >> 2) & 0x3333333333333333UL);
            return (int)(unchecked(((i + (i >> 4)) & 0xF0F0F0F0F0F0F0FUL) * 0x101010101010101UL) >> 56);
        }
        private static long SumVsXoR(long n)
        {
            if (n > 0)
            {
                ulong uNumber = (ulong)n;
                long numberOfBits = (long)Math.Log(uNumber, 2) + 1;
                return 1 << (int)(numberOfBits - NumberOfSetBits(uNumber)); 
            }

            else
            {
                return 1;
            }
        }

        public static int migratoryBirds(List<int> arr)
        {
            var arrGroup = arr.GroupBy(num => num).Select(item=> new
            {
                Number = item.Key,
                CountNumber = item.Count()
            }).OrderByDescending(item=>item.CountNumber).ThenBy(item=>item.Number);


            var maxNumberItem = arrGroup.FirstOrDefault();

            return maxNumberItem != null ? maxNumberItem.Number : 0;


        }

        public static string dayOfProgrammer(int year)
        {
            if (year <= 2700 && year >= 1700)
            {
                DateTime dt = new DateTime(year, 1, 1);
                DateTime newDt;

                if (year <= 1900 && year % 4 == 0)
                {
                    newDt = dt.AddDays(254);
                }

                else
                {
                    newDt = dt.AddDays(255);
                }

                return newDt.ToString("dd.MM.yyyy"); 
            }

            else
            {
                return String.Empty;
            }

        }

        public static int divisibleSumPairs(int n, int k, List<int> ar)
        {
            int satisfiedCount = 0;
            for (int i = 0; i < ar.Count; i++)
            {

                for (int j = i+1; j < ar.Count; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    if ((ar[i] + ar[j]) % k == 0)
                    {
                        satisfiedCount++;
                    }
                }

            }

            return satisfiedCount;


        }

        static string catAndMouse(int x, int y, int z)
        {

            if (x < y && y < z && x < z)
            {
                return "Cat B";
            }

            if (x > y && y < z && x < z)
            {
                return "Cat A";
            }

            else
            {
                return "Mouse C";
            }
        }

        static List<int> countingSort(List<int> arr)
        {

            arr.Sort();
            List<int> newFrequencyList = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                newFrequencyList.Add(arr.Count(item => item == i));
            }

            return newFrequencyList;
        }

    }

}
