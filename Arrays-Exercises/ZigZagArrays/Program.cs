using System;

namespace ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] firstArray = new string[n];
            string[] secondArray = new string[n];

            for (int i = 0; i < n; i++)
            {
                string[] currentArray = Console.ReadLine()
                    .Split(" ");

                string indexZeroElement = currentArray[0];
                string indexFirstElement = currentArray[1];

                if (i % 2 == 0)
                {
                    firstArray[i] = indexZeroElement;
                    secondArray[i] = indexFirstElement;
                }
                else if (i % 2 == 1)
                {
                    firstArray[i] = indexFirstElement;
                    secondArray[i] = indexZeroElement;
                }
            }

            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondArray));
        }
    }
}
