using System;

namespace Warmup
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/diagonal-difference
    /// </summary>
    public class DiagonalDifference
    {
        public static void Main()
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var array = new int[n][];

            for (int i = 0; i < n; i++)
            {
                var aTmp = Console.ReadLine().Split(' ');
                array[i] = Array.ConvertAll(aTmp, int.Parse);
            }

            var sumOfDiagonals = GetSumOfDiagonals(array);

            Console.WriteLine(Math.Abs(sumOfDiagonals));
        }

        private static int GetSumOfDiagonals(int[][] array)
        {
            int firstSum = 0;
            int secondSum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                var lastElement = array[i].Length - 1 - i;
                firstSum += array[i][i];
                secondSum += array[i][lastElement];
            }

            return firstSum - secondSum;
        }
    }
}
