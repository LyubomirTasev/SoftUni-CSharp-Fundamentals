using System;

namespace Sum_Of_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                //int currentDigit = (int)Char.GetNumericValue(input[i]);
                int currentDigit = int.Parse(input[i].ToString());
                sum += currentDigit;
            }

            Console.WriteLine(sum);
        }
    }
}
