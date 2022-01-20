using System;
using System.Collections.Generic;

namespace Associative_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, double> fruits = new SortedDictionary<string, double>()
            {
                { "orange", 2.3}               
            };

            fruits.Add("banana", 2.2);
            fruits.Add("apple", 0.90);

            foreach (var item in fruits)
            {
                Console.WriteLine($"the price of {item.Key} is {item.Value}");
            }
        }
    }
}
