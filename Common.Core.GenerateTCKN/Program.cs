// See https://aka.ms/new-console-template for more information

using Common.Core;
using System.Linq.Expressions;
using System.Linq;
using System.Collections.Generic;

long minimumTCKN = GenerationIslemleri.GetMinimumValidTCKN();
long maksimumTCKN = GenerationIslemleri.GetMaximumValidTCKN();

Console.WriteLine($"Minimum TCKN: {minimumTCKN}");
Console.WriteLine($"Maksinmum TCKN: {maksimumTCKN}");

Expression<Func<int, int>> expression = x => x + 5;
Func<int, int> func = expression.Compile();


Console.WriteLine(expression.ToString());
int cv = commonChild("HARRY", "SALLY");


static int commonChild(string s1, string s2)
{

    int eliminatedCount = s2.Length - 1;
    int commonLength = 0;

    for (int i = 1; i < s1.Length; i++)
    {
        string subStr1 = s1;
        string subStr2 = s2;
        int k = eliminatedCount;
        for (int j = 1; j <= i; j++)
        {
            subStr1 = subStr1.Replace(s2[k].ToString(), string.Empty);
            subStr2 = subStr2.Replace(s2[k].ToString(), string.Empty);
            k--;
        }

        if (subStr1 == subStr2)
        {
            return subStr1.Length;
        }
    }

    return 0;
}


 static int camelcase(string s)
{

    int wordCount = 1;

    if (s.Length < 2)
    {
        return 0;
    }


    for (int i = 2; i < s.Length; i++)
    {
        if (char.IsUpper(s[i]) && i + 1 < s.Length && char.IsLower(s[i + 1]))
        {
            wordCount++;
        }


    }

    return wordCount;
}

int _minMunber = minimumNumber(4, "4700");

 static int minimumNumber(int n, string password)
{
    // Return the minimum number of characters to make the password strong
    string numbers = "0123456789";
    string lower_case = "abcdefghijklmnopqrstuvwxyz";
    string upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    string special_characters = "!@#$%^&*()-+";
    int passLength = n;
    int requiredChars = 0;
    int upperCount = 0;
    int lowerCount = 0;
    int numberCount = 0;
    int specialCharCount = 0;


    for (int i = 0; i < password.Length; i++)
    {
        char ch = password[i];

        if (numbers.Contains(ch))
        {
            numberCount++;
        }

        else if (lower_case.Contains(ch))
        {
            lowerCount++;
        }

        else if (upper_case.Contains(ch))
        {
            upperCount++;
        }

        else if (special_characters.Contains(ch))
        {
            specialCharCount++;
        }

    }




    int eksikCharCount = 0;
    if (specialCharCount == 0)
    {
        eksikCharCount++;
    }

    if (numberCount == 0)
    {
        eksikCharCount++;
    }

    if (upperCount == 0)
    {
        eksikCharCount++;
    }

    if (lowerCount == 0)
    {
        eksikCharCount++;
    }


    if (6 - passLength >= eksikCharCount)
    {
        return 6 - passLength;
    }

    else if(passLength >= 6 && eksikCharCount > 0)
    {
        return eksikCharCount;
    }

    else if(6 - passLength <= eksikCharCount)
    {
        return eksikCharCount;
    }



    return 0;

}


List<int> numbers = new List<int>()
{ 8, 5, 5, 4,8,9,0,45,4,21,45,12,9,12,34,30, 9,0,21,17,17,34,21 };

int result = FindMaximumAndRepeatingNumber(numbers);

Console.WriteLine($"En Maximum Repeating Number {result}");

static int FindMaximumAndRepeatingNumber(List<int> numbers)
{
    var numberCounts = numbers.GroupBy(x => x).Select(x => new
    {
        Num = x.Key,
        Count = x.Count()

    });

    var sortedNumberCounts = numberCounts.OrderByDescending(x => x.Num).ThenByDescending(x => x.Count);

    foreach (var soretedNum in sortedNumberCounts)
    {
        Console.WriteLine($"Number: {soretedNum.Num} Count: {soretedNum.Count}");
    }

    return sortedNumberCounts.Max(x => x.Num + x.Count);
}

static List<int> compareTriplets(List<int> a, List<int> b)
{
    int aSumOfPoints = 0;
    int bSumOfPoints = 0;

    for (int i = 0; i < a.Count; i++)
    {
        if (a[i] > b[i])
        {
            aSumOfPoints++;
        }

        else if (a[i] < b[i])
        {
            bSumOfPoints++;
        }
    }

    return new List<int>() { aSumOfPoints, bSumOfPoints };


    static int diagonalDifference(List<List<int>> arr)
    {
        int leftOfSum = 0;
        int rigthOfSum = 0;
        int j = arr[0].Count - 1;

        for (int i = 0; i < arr.Count; i++)
        {
            leftOfSum += arr[i][i];
            rigthOfSum += arr[i][j];

            j--;
        }

        return Math.Abs(rigthOfSum - leftOfSum);
    }

    static void plusMinus(List<int> arr)
    {
        double positiveCount = 0;
        double negativeCount = 0;
        double zeroCount = 0;
        double totalCount = arr.Count;

        foreach (var num in arr)
        {
            if (num > 0)
            {
                positiveCount++;
            }

            else if (num < 0)
            {
                negativeCount++;
            }

            else
            {
                zeroCount++;
            }
        }

        Console.WriteLine($"{(positiveCount / totalCount).ToString("0.######")}\n{(negativeCount / totalCount).ToString("0.######")}\n{(zeroCount / totalCount).ToString("0.######")}");


    }


    static void staircase(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            string bosluklar = new string(' ', n - i);
            string stairs = new string('#', i);

            Console.WriteLine(bosluklar + stairs);

        }
    }

    static void miniMaxSum(List<int> arr)
    {
        int ilkSayi = arr[0];

        int max = ilkSayi;
        int min = ilkSayi;
        long sumOfMin = 0;
        long sumOfMax = 0;
        long sum = 0;
        //IEnumerable<int> sortedArr = arr.OrderBy(x=>x);


        foreach (var num in arr)
        {
            if (num > max)
            {
                max = num;
            }

            if (num < min)
            {
                min = num;
            }
        }


        if (max == min)
        {
            sumOfMin = min * (arr.Count - 1);
            sumOfMax = max * (arr.Count - 1);
        }

        else
        {
            foreach (var num in arr)
            {
                if (num < max)
                {
                    sumOfMin += num;
                }

                if (num > min)
                {
                    sumOfMax += num;
                }
            }
        }

        //for (int i = 1; i < arr.Count-1; i++)
        //{
        //    sum +=arr[i];
        //}


        Console.WriteLine($"{sumOfMin} {sumOfMax}");
    }

    static int birthdayCakeCandles(List<int> candles)
    {
        int max = candles.Max();

        return candles.Count(x => x == max);
    }


    static string timeConversion(string s)
    {
        DateTime time = DateTime.Parse(s);

        return time.ToString("HH:mm:ss");
    }




}


