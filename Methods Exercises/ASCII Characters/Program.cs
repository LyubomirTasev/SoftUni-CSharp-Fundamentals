using System;

namespace ASCII_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            char input1 = char.Parse(Console.ReadLine());
            char input2 = char.Parse(Console.ReadLine());

            PrintInBetween(input1, input2);
        }

        private static void PrintInBetween(char input1, char input2)
        {

            if (input1 > input2)
            {
                char first = input1;
                input1 = input2;
                input2 = first;
            }

            for (int i = input1 + 1; i < input2; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
