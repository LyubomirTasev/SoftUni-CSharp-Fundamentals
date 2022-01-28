﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<int> endList = new List<int>();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                int[] numbers = list[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                foreach (var num in numbers)
                {
                    endList.Add(num);
                }
            }
            Console.WriteLine(string.Join(" ", endList));
        }
    }
}
