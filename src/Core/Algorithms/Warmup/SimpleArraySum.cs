using System;
using System.Linq;

namespace Warmup
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/simple-array-sum
    /// </summary>
    public class SimpleArraySum
    {
        public static void Main()
        {
            Console.ReadLine();
            string[] tmpArray = Console.ReadLine().Split(' ');
            int[] array = Array.ConvertAll(tmpArray, int.Parse);
            Console.WriteLine(array.Sum());
        }
    }
}