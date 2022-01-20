using System;

namespace Reference_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 8 };
            Increment(number, 2);
            Console.WriteLine(number[0]);

        }
        static void Increment(int[] nums, int inc)
        {
            nums[0] += inc;
        }
    }
}
