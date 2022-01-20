using System;
using System.Collections.Generic;

namespace Occurences
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            Dictionary<char, int> occurences = new Dictionary<char, int>();

            foreach (var letter in input)
            {
                if (letter != ' ')
                {
                    if (!occurences.ContainsKey(letter))
                    {
                        occurences.Add(letter, 0);
                    }
                    occurences[letter]++;
                }
            }

            foreach (var c in occurences)
            {
                Console.WriteLine($"{c.Key} -> {c.Value}");
            }
        }
    }
}
