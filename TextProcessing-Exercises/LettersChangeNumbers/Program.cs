﻿using System;

namespace LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double result = 0;

            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int i = 0; i < input.Length; i++)
            {
                string curr = input[i];
                char firstLetter = curr[0];
                char lastLetter = curr[curr.Length - 1];

                double number = double.Parse(curr.Substring(1, curr.Length - 2));

                int firstElementIndex = alphabet.IndexOf(char.ToUpper(firstLetter));
                int secondElementIndex = alphabet.IndexOf(char.ToUpper(lastLetter));

                if (firstLetter >= 65 && firstLetter <= 90)
                {
                    number = number / (firstElementIndex + 1);
                }
                else
                {
                    number = number * (firstElementIndex + 1);
                }

                if (lastLetter >= 65 && lastLetter <= 90)
                {
                    number = number - (secondElementIndex + 1);
                }
                else
                {
                    number = number + (secondElementIndex + 1);
                }

                result += number;
            }

            Console.WriteLine($"{result:f2}");
        }
    }
}
