using System;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowballs = int.Parse(Console.ReadLine());
            int biggestSnow = 0;
            int biggestTime = 0;
            int biggestQuality = 0;

            double biggestValue = 0;

            for (int i = 1; i <= snowballs; i++)
            {                
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                int snowDividedByTime = snowballSnow / snowballTime;
                double snowBallValue = Math.Pow(snowDividedByTime, snowballQuality);

                if (snowBallValue > biggestValue)
                {
                    biggestValue = snowBallValue;
                    biggestSnow = snowballSnow;
                    biggestTime = snowballTime;
                    biggestQuality = snowballQuality;
                }
                
            }
            //{snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})
            Console.WriteLine($"{biggestSnow} : {biggestTime} = {biggestValue} ({biggestQuality})");
            
        }
    }
}
