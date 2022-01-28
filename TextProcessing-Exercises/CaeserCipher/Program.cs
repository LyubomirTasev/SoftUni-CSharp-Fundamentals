using System;

namespace CaeserCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            foreach (char word in text)
            {
                var currentChar = (char)(word + 3);
                Console.Write(currentChar);
            }
        }
    }
}
