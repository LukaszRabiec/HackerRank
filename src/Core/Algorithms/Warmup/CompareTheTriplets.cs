using System;

namespace Warmup
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/compare-the-triplets
    /// </summary>
    public class CompareTheTriplets
    {
        public static void Main()
        {
            var tmpTokensA = Console.ReadLine().Split(' ');
            var tokensA = Array.ConvertAll(tmpTokensA, int.Parse);
            var tmpTokensB = Console.ReadLine().Split(' ');
            var tokensB = Array.ConvertAll(tmpTokensB, int.Parse);

            int[] result = Solve(tokensA, tokensB);
            Console.WriteLine(string.Join(" ", result));
        }

        private static int[] Solve(int[] tokensA, int[] tokensB)
        {
            var result = new int[2];

            for (int i = 0; i < tokensA.Length; i++)
            {
                if (tokensA[i] > tokensB[i])
                {
                    result[0]++;
                }

                if (tokensA[i] < tokensB[i])
                {
                    result[1]++;
                }
            }

            return result;
        }
    }
}
