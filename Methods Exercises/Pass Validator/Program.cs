using System;

namespace Pass_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isTrue = ValidateLength(password) && 
                          ValidateLsAndDgs(password) && 
                          ValidateTwoDigits(password);

            if (isTrue)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (!ValidateLength(password))
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if (!ValidateLsAndDgs(password))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (!ValidateTwoDigits(password))
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
            
        }

        private static bool ValidateTwoDigits(string password)
        {
            int count = 0;

            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    count++;
                }
            }

            if (count >= 2)
            {
                return true;
            }
            return false;
        }

        private static bool ValidateLsAndDgs(string password)
        {
            foreach (char c in password)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool ValidateLength(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                bool isTrue = true;
                return isTrue;

                // return true;
            }
            return false;
        }
    }
}
