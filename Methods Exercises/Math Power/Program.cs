using System;
using System.Text;

namespace Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            RepeatString(text, count);
        }
        static void RepeatString(string text, int num)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < num; i++)
            {
                result.Append(text);
            }

            Console.WriteLine(result.ToString());
        }
    }
}
