using System;
using System.Text;

namespace Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            string result = PrintString(text, count);
            Console.WriteLine(result);
        }

        static string PrintString(string str, int count)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                result.Append(str);
            }

            //Console.WriteLine(result.ToString());
            return result.ToString();
        }
    }
}
