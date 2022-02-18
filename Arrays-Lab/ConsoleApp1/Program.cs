using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
