using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            double factorialFirstNum = GetFactorial(firstNum);
            double factorialSecondNum = GetFactorial(secondNum);

            double result = factorialFirstNum / factorialSecondNum;
            Console.WriteLine($"{result:f2}");
        }

        public static double GetFactorial(int number)
        {
            double result = 1;
            while (number != 1)
            {
                result = result * number;
                number = number - 1;
            }
            return result;
        }


    }
}
