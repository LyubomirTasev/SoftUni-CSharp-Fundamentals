using System;
using System.Collections.Generic;

namespace Associative_Arrays_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> people = new Dictionary<string, int>();

            people.Add("Lubo", 22);
            people.Add("Sando", 25);
            people.Add("Pepi", 32);
            people.Add("Mitko", 34);
            people.Add("Niki", 34);

            foreach (var item in people)
            {
                Console.WriteLine($"Hi, my name is {item.Key} and I'm {item.Value} years old.");
            }
        }
    }
}
