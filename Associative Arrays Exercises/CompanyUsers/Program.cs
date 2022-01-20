using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> company = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] cmdArgs = command.Split(" -> ");
                string companyName = cmdArgs[0];
                string employeeId = cmdArgs[1];

                if (!company.ContainsKey(companyName))
                {
                    company.Add(companyName, new List<string>());
                }

                company[companyName].Contains(employeeId);

                command = Console.ReadLine();
            }

            foreach (var item in company.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}");
                Console.WriteLine($"-- {item.Value}");
            }
        }
    }
}
