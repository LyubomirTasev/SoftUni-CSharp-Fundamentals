using System;

namespace Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            int result = PrintVowels(text);
            Console.WriteLine(result);
        }

        private static int PrintVowels(string text)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];// !!!!!!!!!!!! //

                if (currentChar == 'a' || currentChar == 'o' || currentChar == 'u' || currentChar == 'e' || currentChar == 'i')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
