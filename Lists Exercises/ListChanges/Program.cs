using System;
using System.Collections.Generic;
using System.Linq;

namespace ListChanges
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfInts = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandArgs = command.Split();
                string firstCommand = commandArgs[0];
                int element = int.Parse(commandArgs[1]);

                if (firstCommand == "Delete")
                {
                    listOfInts.RemoveAll(x => x == element);
                }
                else if (firstCommand == "Insert")
                {
                    int index = int.Parse(commandArgs[2]);
                    listOfInts.Insert(index, element);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", listOfInts));
        }
    }
}
