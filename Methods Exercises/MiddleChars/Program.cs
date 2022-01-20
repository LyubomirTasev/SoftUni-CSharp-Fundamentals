using System;

namespace MiddleChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string output = string.Empty;

            if (input.Length % 2 == 0)
            {
                output = GetMiddleCharFromEvenString(input);                
            }
            else
            {
                output = GetMiddleCharFromOddString(input);               
            }

            Console.WriteLine(output);
        }

        private static string GetMiddleCharFromOddString(string input)
        {
            int index = input.Length / 2;
            string chars = input.Substring(index, 1);
            return chars;
        }

        private static string GetMiddleCharFromEvenString(string input)
        {
            int index = input.Length / 2;
            string chars = input.Substring(index - 1, 2);
            return chars;
        }
    }
}
