using System;
using System.Text;


namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            string b = "Hello, C#";

            Console.WriteLine(b.IndexOf("C#,"));
        }
    }
}
