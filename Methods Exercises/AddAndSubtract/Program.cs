using System;

namespace AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2, num3);
            Console.WriteLine(sum);
        }

        private static int Sum(int num1, int num2, int num3)
        {
            int sumOfFirstTwo = num1 + num2;
            return Subtract(sumOfFirstTwo, num3);
        }

        private static int Subtract(int sumOfFirstTwo, int num3)
        {
            return sumOfFirstTwo - num3;
        }
    }
}
