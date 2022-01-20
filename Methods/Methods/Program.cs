using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintNumberSign(number);
        }
        static void PrintNumberSign(int number)
        {
            if (number < 0)
            {
                Console.WriteLine($"Number {number} is negative.");
            }
            else if (number > 0)
            {
                Console.WriteLine($"Number {number} is positive.");
            }
            else
            {
                Console.WriteLine($"Number {number} is zero.");
            }
        }
    }
}
