﻿using System;
using System.Numerics;

namespace Factorial_BigInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            BigInteger result = 1;

            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            Console.WriteLine(result);
        }
    }
}
