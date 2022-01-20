using System;

namespace Optional_Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintRange();
            PrintRange(10);
            PrintRange(15,87);
            PrintRange(end: 87);
        }

        static void PrintRange(int start = 0, int end = 100)
        {
            Console.WriteLine($"Range is from {start} to {end}.");
        }
    }
}
