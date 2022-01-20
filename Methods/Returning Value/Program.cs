using System;

namespace Returning_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 8;
            number = Increment(number, 2);
            Console.WriteLine(number);
        }

        static int Increment( int number, int inc)
        {
            number += inc;

            return number;
        }
    }
}
