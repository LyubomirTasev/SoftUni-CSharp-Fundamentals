﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            int maxIndex = numbers.Count / 2;

            for (int i = 0; i < maxIndex; i++)
            {
                numbers[i] += numbers[numbers.Count - 1];
                numbers.Remove(numbers[numbers.Count - 1]);
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
