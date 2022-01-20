using System;

namespace Value_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            int number =  8;
            Increment(number, 2);
            Console.WriteLine(number);
        }

        static void Increment(int nums, int inc)
        {
            nums += inc;
        }
    }
}
