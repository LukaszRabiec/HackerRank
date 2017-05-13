using System;
using System.Linq;

namespace Warmup
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/birthday-cake-candles
    /// </summary>
    public class BirthdayCakeCandles
    {
        public static void Main()
        {
            Console.ReadLine();
            var tmpHeights = Console.ReadLine().Split(' ');
            var heights = Array.ConvertAll(tmpHeights, int.Parse);

            var highest = heights.Max();
            var highestCount = heights.Count(h => h == highest);

            Console.WriteLine(highestCount);
        }
    }
}
