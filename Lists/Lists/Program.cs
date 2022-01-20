using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            // Reading Lists (по сложен начин):

            string values = Console.ReadLine();
            List<string> items = values.Split(' ').ToList();

            List<int> nummern = new List<int>();

            for (int i = 0; i < items.Count; i++)
            {
                nummern.Add(int.Parse(items[i]));
            }

            // Reading Lists From Single Line:

            List<int> nums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

        }
    }
}
