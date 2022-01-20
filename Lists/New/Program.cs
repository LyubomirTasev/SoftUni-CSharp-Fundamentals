using System;
using System.Collections.Generic;

namespace New
{
    class Program
    {
        static void Main(string[] args)
        {
            // Printing Lists using for loop:

            List<string> list = new List<string>()
            {
                "one", "two", "three", "four", "five", "six"
            };

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("arr[{0}] = 1", i, list[i]);
            }

            // Printing Lists using String.Join():

            List<string> listenko = new List<string>()
            {
                "one", "two", "three", "four", "five", "six"
            };
            Console.WriteLine(string.Join("; ", listenko));
        }
    }
}
