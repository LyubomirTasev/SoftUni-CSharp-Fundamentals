using System;

namespace SortElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string digits = string.Empty;
            string letters = string.Empty;
            string symbols = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                var curr = text[i];

                if (char.IsDigit(curr))
                {
                    digits += curr;
                }
                else if (char.IsLetter(curr))
                {
                    letters += curr;
                }
                else if (char.IsSymbol(curr))
                {
                    symbols += curr;
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(symbols);
        }
    }
}
