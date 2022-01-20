using System;

namespace Searching_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string b = "Hello, C#";

            Console.WriteLine(b.Contains("C#"));
            Console.WriteLine(b.IndexOf("C#"));
            Console.WriteLine(b.Substring(7));
        }
    }
}
