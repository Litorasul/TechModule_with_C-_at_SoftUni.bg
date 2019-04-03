using System;

namespace _04.PasswordValidator
{
    class PasswordValidator
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool lenght = CheckForLenght(password);
            bool alphaNumeric = CheckForAlphaNumeric(password);
            bool atLeastTwoDigits = CheckForAtLeastTwoDigits(password);

            CheckForLenght(password);
            CheckForAlphaNumeric(password);
            CheckForAtLeastTwoDigits(password);

            if (lenght == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (alphaNumeric == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (atLeastTwoDigits == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (lenght && alphaNumeric && atLeastTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }

           
        }

        private static bool CheckForAtLeastTwoDigits(string password)
        {
            int digitCounter = 0;

            foreach (char item in password)
            {
                if (char.IsDigit(item))
                {
                    digitCounter++;
                }
            }

            if (digitCounter >= 2)
            {
                return true;
            }

            return false;
            
        }

        private static bool CheckForAlphaNumeric(string password)
        {
            foreach (char item in password)
            {
                if (!char.IsLetterOrDigit(item))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool CheckForLenght(string password)
        {
            int lenght = password.Length;
            if (lenght > 10 || lenght < 6 )
            {
                return false;
            }

            return true;
        }
    }
}
