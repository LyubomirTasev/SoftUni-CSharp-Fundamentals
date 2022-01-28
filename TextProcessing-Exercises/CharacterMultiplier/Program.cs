using System;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split();

            string firstWord = tokens[0];
            string secondWord = tokens[1];

            string longestWord = firstWord;
            string shortestWord = secondWord;

            if (firstWord.Length < secondWord.Length)
            {
                longestWord = secondWord;
                shortestWord = firstWord;
            }

            int total = CharValidation(longestWord, shortestWord);
            Console.WriteLine(total);
        }

        public static int CharValidation(string longestWord, string shortestWord)
        {
            int sum = 0;

            for (int i = 0; i < shortestWord.Length; i++)
            {
                int multiply = longestWord[i] * shortestWord[i];
                sum += multiply;
            }

            for (int i = shortestWord.Length; i < longestWord.Length; i++)
            {
                sum += longestWord[i];
            }

            return sum;
        }
    }
}
