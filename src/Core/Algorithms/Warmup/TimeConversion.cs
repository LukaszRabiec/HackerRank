using System;

namespace Warmup
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/time-conversion
    /// </summary>
    public class TimeConversion
    {
        public static void Main()
        {
            string time = Console.ReadLine();
            var convertedTime = ConvertTo24Hours(time); //DateTime.Parse(time);

            Console.WriteLine(convertedTime); //.ToString("HH:mm:ss"));
        }

        private static string ConvertTo24Hours(string time)
        {
            var sufix = time.Substring(time.Length - 2);
            var trimed = time.TrimEnd(sufix.ToCharArray());
            var splited = trimed.Split(':');
            if (sufix == "PM")
            {
                splited[0] = Convert.ToString(Convert.ToInt32(splited[0]) % 12 + 12);
            }
            if (splited[0] == "12" && sufix == "AM")
            {
                splited[0] = "00";
            }
            return $"{splited[0]}:{splited[1]}:{splited[2]}";
        }
    }
}
