using System;

namespace Warmup
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/solve-me-first
    /// </summary>
    public class SolveMeFirst
    {
        public static void Main()
        {
            int val1 = Convert.ToInt32(Console.ReadLine());
            int val2 = Convert.ToInt32(Console.ReadLine());
            int sum = SolveMeFirstAddition(val1, val2);
            Console.WriteLine(sum);
        }

        private static int SolveMeFirstAddition(int a, int b)
        {
            return a + b;
        }
    }
}