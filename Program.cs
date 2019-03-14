using System;

namespace euler
{
    class Program
    {
        static  int[] arr1to19 = new int[] {
           0,
          "one".Length,
          "two".Length,
          "three".Length,
          "four".Length,
          "five".Length,
          "six".Length,
          "seven".Length,
          "eight".Length,
          "nine".Length,
          "ten".Length,
          "eleven".Length,
          "twelve".Length,
          "thirteen".Length,
          "fourteen".Length,
          "fifteen".Length,
          "sixteen".Length,
          "seventeen".Length,
          "eighteen".Length,
          "nineteen".Length
        };

        // tenth prefixes
        static int[] arraytenth = new int[] {
          "twenty".Length,
          "thirty".Length,
          "forty".Length,
          "fifty".Length,
          "sixty".Length,
          "seventy".Length,
          "eighty".Length,
          "ninety".Length};

        static int below100(int number)
        {
            if (number < 20)
                return arr1to19[number];
            return arraytenth[number / 10 - 2] + arr1to19[number % 10];
        }

        static int numberLength(int n)
        {

            if (n < 100)
                return below100(n);

            var res = 0;
            int h = (int) Math.Floor((double)n / 100) % 10;
            int t = (int)Math.Floor((double)n / 1000);
            int s = n % 100;

            if (n > 999)
                res += below100(t) + "thousand".Length;
            if (h != 0)
                res += arr1to19[h] + "hundred".Length;
            if (s != 0)
                res += "and".Length + below100(s);
            return res;
        }

        static int solution(int number)
        {
            var num = 0;
            for (var i = 1; i <= number; i++)
            {
                num += numberLength(i);
            }
            return num;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(solution(1000).ToString());
            Console.ReadKey();
        }
    }
}
