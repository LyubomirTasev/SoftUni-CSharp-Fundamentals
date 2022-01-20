using System;
using System.Linq;

namespace Arrays_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            //for (int i = n - 1; i >= 0; i--)
            //{
                //Console.Write("{0} ", arr[i]);
                //Console.Write($"{arr[i] + " "}");
                Console.Write(string.Join(' ', arr.Reverse()));
            //}
        }
    }
}
