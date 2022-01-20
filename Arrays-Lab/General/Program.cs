using System;

namespace General
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myArray = new string[6];
            Console.WriteLine(myArray[0]); // масивът е празен

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = $"my {i} element";
            }

            //Console.WriteLine(string.Join(Environment.NewLine, myArray));
            Console.WriteLine(myArray[myArray.Length - 1]);
        }
    }
}
