using System;

namespace Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int amountInTank = 0;

            for (int i = 0; i < n; i++)
            {
                int waterToPour = int.Parse(Console.ReadLine());                

                bool isFull = waterToPour > 255;
                bool isOverflow = amountInTank + waterToPour > 255;

                if (isFull || isOverflow)
                {
                    Console.WriteLine("Insufficient capacity!");                   
                    continue;
                }

                amountInTank += waterToPour;
            }

            Console.WriteLine(amountInTank);
        }

        
    }
}
