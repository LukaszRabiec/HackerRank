using System;
using System.Linq;

namespace Warmup
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/mini-max-sum
    /// </summary>
    public class MiniMaxSum
    {
        public static void Main()
        {
            var tmpArray = Console.ReadLine().Split(' ');
            var array = Array.ConvertAll(tmpArray, long.Parse);

            var allSums = GetAllSums(array);

            Console.WriteLine($"{allSums.Min()} {allSums.Max()}");
        }

        private static long[] GetAllSums(long[] array)
        {
            var sums = new long[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                sums[i] = SumWithoutElement(array, i);
            }

            return sums;
        }

        private static long SumWithoutElement(long[] array, int elementIndex)
        {
            return array.Sum() - array[elementIndex];
        }
    }
}
