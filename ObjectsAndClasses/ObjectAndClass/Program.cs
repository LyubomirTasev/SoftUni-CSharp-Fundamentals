using System;

namespace ObjectAndClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice dice6 = new Dice();
            dice6.Side = 6;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(dice6.Roll());
            }
        }
    }
}
