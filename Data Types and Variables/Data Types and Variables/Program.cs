using System;

namespace Data_Types_and_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            decimal kilo = meters / 1000.0M;
            Console.WriteLine($"{kilo:f2}");
        }

    }
}
