using System;
using System.Linq;

namespace Warmup
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/a-very-big-sum
    /// </summary>
    public class AVeryBigSum
    {
        public static void Main()
        {
            Console.ReadLine();
            var tmpArray = Console.ReadLine().Split(' ');
            var array = Array.ConvertAll(tmpArray, long.Parse);
            Console.WriteLine(array.Sum());
        }
    }
}
