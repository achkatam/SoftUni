using System;
using System.Linq;

namespace Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	It should contain 6 – 10 characters(inclusive)
            //•	It should contain only letters and digits
            //•	It should contain at least 2 digits
            //If it is not valid, for any unfulfilled rule print the corresponding message:
            //•	"Password must be between 6 and 10 characters"
            //•	"Password must consist only of letters and digits"
            //•	"Password must have at least 2 digits"
            string password = Console.ReadLine();
            //Set the true value of the booleans
            bool isPasswordLengthValid = ValidatePasswordLength(password);
            bool isPasswordContainsValidSymbols = ValidatePasswordText(password);
            bool isDigitPasswordAtLeastTwo = ValidatePasswordDigit(password);

            if (!isPasswordLengthValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!isPasswordContainsValidSymbols)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!isDigitPasswordAtLeastTwo)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isDigitPasswordAtLeastTwo && isPasswordContainsValidSymbols && isPasswordLengthValid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool ValidatePasswordDigit(string password)
        {
            int count = 0;
            foreach (var symbol in password)
            {
                if (char.IsDigit(symbol))
                {
                    count++;
                }
            }
            return count >= 2;
        }

        private static bool ValidatePasswordText(string password)
        {

            //return password.All(symbol => char.IsLetterOrDigit(symbol));
            //Using foreachLoop
            foreach (char symbol in password)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool ValidatePasswordLength(string password)
        {
            return password.Length >= 6 && password.Length <= 10;
        }
    }
}
