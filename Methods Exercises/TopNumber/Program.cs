using System;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            FindTopNumber(n);
        }

        private static void FindTopNumber(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                string currentNumber = i.ToString();
                bool isOddDigit = false;
                int sumOfDigits = 0;

                foreach (int curr in currentNumber)
                {
                    //int parseNumber = curr;

                    if (curr % 2 != 0)
                    {
                        isOddDigit = true;
                    }

                    sumOfDigits += curr;
                }

                if (sumOfDigits % 8 == 0 && isOddDigit)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
