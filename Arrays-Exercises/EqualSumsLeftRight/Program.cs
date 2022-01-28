using System;
using System.Linq;

namespace EqualSumsLeftRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            bool isFound = false;

            for (int currentEl = 0; currentEl < arr.Length; currentEl++)
            {
                int sumRight = 0;

                for (int i = currentEl + 1; i < arr.Length; i++)
                {
                    sumRight += arr[i];
                }

                int sumLeft = 0;

                for (int i = currentEl - 1; i >= 0; i--)
                {
                    sumLeft += arr[i];
                }

                if (sumLeft == sumRight)
                {
                    Console.WriteLine(currentEl);
                    isFound = true;
                    break;
                }
            }

            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
