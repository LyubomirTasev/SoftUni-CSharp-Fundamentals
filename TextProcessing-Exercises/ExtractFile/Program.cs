using System;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(@"\");

            string lastFile = input[input.Length - 1];

            string[] arr = lastFile.Split(".");

            string name = arr[0];
            string ext = arr[1];

            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {ext}");
        }
    }
}
