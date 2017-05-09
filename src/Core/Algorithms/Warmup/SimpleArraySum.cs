using System;
using System.Linq;

namespace Warmup
{
    public class SimpleArraySum
    {
        public static void Main()
        {
            Console.ReadLine();
            string[] tmpArray = Console.ReadLine().Split(' ');
            int[] array = Array.ConvertAll(tmpArray, Int32.Parse);
            Console.WriteLine(array.Sum());
        }
    }
}