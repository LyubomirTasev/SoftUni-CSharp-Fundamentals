using System;

namespace MaxSequenceEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ");

            int bestCount = 0;
            int bestIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                string currentElement = arr[i];
                int counter = 1;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (currentElement == arr[j])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (counter > bestCount)
                {
                    bestCount = counter;
                    bestIndex = i;
                }
            }

            for (int i = 0; i < bestCount; i++)
            {
                Console.Write(arr[bestIndex] + " ");
            }
        }
    }
}
