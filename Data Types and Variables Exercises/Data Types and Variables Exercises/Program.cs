using System;

namespace Data_Types_and_Variables_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());

            int courseCount = 0;

            while (numberOfPeople > 0)
            {
                numberOfPeople -= elevatorCapacity;
                courseCount++;
            }

            Console.WriteLine(courseCount);
        }
    }
}
