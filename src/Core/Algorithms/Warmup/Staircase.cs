using System;
using System.Text;

namespace Warmup
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/staircase
    /// </summary>
    public class Staircase
    {
        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(BuildStaircase(n));
        }

        private static string BuildStaircase(int n)
        {
            string staircase = default(string);
            var stringBuilder = new StringBuilder();

            for (int hashes = 1; hashes <= n; hashes++)
            {
                stringBuilder.Clear();

                stringBuilder.Append(' ', n - hashes);
                stringBuilder.Append('#', hashes);
                stringBuilder.Append(new[] { '\r', '\n' });

                staircase += stringBuilder;
            }

            return staircase;
        }
    }
}
