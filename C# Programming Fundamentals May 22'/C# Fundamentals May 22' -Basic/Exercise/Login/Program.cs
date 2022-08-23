using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            //On the first line, you will be given a username, your task is to try to log in the user. The user’s password is username reversed. On the next lines, you will receive passwords:
            //•	If the password is incorrect print "Incorrect password. Try again."
            // •	If the password is correct print: "User {username} logged in." and stop the program
            // Keep in mind, on the fourth attempt if the password is still not correct print: "User {username} blocked!"
            // Then the program stops.

            string username = Console.ReadLine();
            string password = string.Empty;

            for (int value = username.Length - 1; value >= 0; value--)
            {
                password += username[value];
            }

            int counterOfWrongPass = 0;

            string inputPassword = Console.ReadLine();

            while (inputPassword != password)
            {
                counterOfWrongPass++;
                if(counterOfWrongPass > 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }

                Console.WriteLine($"Incorrect password. Try again.");
                inputPassword = Console.ReadLine();
            }
            if(inputPassword == password)
            {
                Console.WriteLine($"User {username} logged in.");
            }
            

        }
    }
}
