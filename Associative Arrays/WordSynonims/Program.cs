using System;
using System.Collections.Generic;

namespace WordSynonims
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWords = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

            for (int i = 0; i < numberOfWords; i++)
            {
                string word = Console.ReadLine();
                string synomim = Console.ReadLine();

                if (dictionary.ContainsKey(word))
                {
                    dictionary[word].Add(synomim);
                }
                else
                {
                    dictionary.Add(word, new List<string>() { synomim });
                }
            }

            foreach (var synonims in dictionary)
            {
                Console.WriteLine($"{synonims.Key} - {string.Join(", ", synonims.Value)}");
            }
        }
    }
}
