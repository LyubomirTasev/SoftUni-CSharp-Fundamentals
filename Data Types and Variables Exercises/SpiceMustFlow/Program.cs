using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            // !?!
            int startingYield = int.Parse(Console.ReadLine());
            int extractionPerDay = 0;
            int total = 0;

            int daysCount = 0;

            while (startingYield >= 100)
            {
                extractionPerDay = startingYield;
                extractionPerDay -= 26;
                total += extractionPerDay;
                startingYield -= 10;

                daysCount++;
            }

            total -= 26;

            Console.WriteLine(daysCount);
            Console.WriteLine(total);
        }
    }
}
