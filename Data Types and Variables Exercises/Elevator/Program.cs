using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int coursesCount = 0;

            while (countOfPeople > 0)
            {
                countOfPeople -= capacity;
                coursesCount++;
            }
            Console.WriteLine(coursesCount);
        }
    }
}
