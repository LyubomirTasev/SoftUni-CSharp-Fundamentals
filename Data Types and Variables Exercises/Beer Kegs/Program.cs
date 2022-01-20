using System;

namespace Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int nKegs = int.Parse(Console.ReadLine());
            string biggestKeg = string.Empty;
            double biggestVolume = 0;

            for (int i = 0; i < nKegs; i++)
            {
                string currentKeg = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int heigth = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * heigth;
                
                if (volume > biggestVolume)
                {
                    biggestVolume = volume;
                    biggestKeg = currentKeg;
                }
            }

            Console.WriteLine(biggestKeg);
        }
    }
}
