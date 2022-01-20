using System;
using System.Collections.Generic;

namespace Occurences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Dictionary<string, int> occurences = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string wordInLowerCase = word.ToLower();

                if (occurences.ContainsKey(wordInLowerCase))
                {
                    occurences[wordInLowerCase]++;
                }
                else
                {
                    occurences.Add(wordInLowerCase, 1);
                }
            }

            foreach (var occur in occurences)
            {
                if (occur.Value % 2 != 0)
                {
                    Console.Write(occur.Key + " ");
                }
            }
        }
    }
}
