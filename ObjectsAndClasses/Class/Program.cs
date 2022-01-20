using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student("Lyubomir", "Tasev");
            string learn = stud.Learning("History");
            Console.WriteLine(learn);

            //Console.WriteLine($"Hi, my name is {stud.FirstName} {stud.LastName}.");
        }
    }

    class Student
    {
        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Learning(string subject)
        {
            return $"I'm learning {subject}";
        }
    }
}
