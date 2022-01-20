using System;

namespace Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int counter = 0;
            double tempPower = power * 0.5;

            while (power >= distance)
            {
                counter++;
                power -= distance;

                if (power == tempPower && exhaustionFactor != 0)
                {
                    power /= exhaustionFactor;
                    //power = power / exhaustionFactor;
                }                
            }

            Console.WriteLine(power);
            Console.WriteLine(counter);
        }
    }
}
