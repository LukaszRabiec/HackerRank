using System;
using System.Globalization;
using System.Linq;

namespace Warmup
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/plus-minus
    /// </summary>
    public class PlusMinus
    {
        public static void Main()
        {
            var n = Convert.ToSingle(Console.ReadLine());
            var tmpArray = Console.ReadLine().Split(' ');
            var array = Array.ConvertAll(tmpArray, int.Parse);

            var positiveFraction = array.Count(e => e > 0) / n;
            var negativeFraction = array.Count(e => e < 0) / n;
            var zerosFraction = array.Count(e => e == 0) / n;

            Console.WriteLine(positiveFraction.ToString("N6", new CultureInfo("en-US")));
            Console.WriteLine(negativeFraction.ToString("N6", new CultureInfo("en-US")));
            Console.WriteLine(zerosFraction.ToString("N6", new CultureInfo("en-US")));
        }
    }
}
