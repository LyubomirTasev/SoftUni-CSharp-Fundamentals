using System;
using System.Text.RegularExpressions;

namespace Regular_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([A-Z])\w+";

            var regex = new Regex(pattern);

            string text = "Explore";

            Console.WriteLine(regex.IsMatch(text));
        }
    }
}
