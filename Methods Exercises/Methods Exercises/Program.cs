using System;

namespace Methods_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int heigth = int.Parse(Console.ReadLine());

            double area = RectangleArea(width, heigth);
            Console.WriteLine(area);
        }

        static double RectangleArea(int width, int heigth)
        {
            return width * heigth;
        }
    }
}
