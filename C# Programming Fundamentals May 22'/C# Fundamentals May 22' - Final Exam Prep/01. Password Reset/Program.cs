using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace _01._Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a password reset program that performs a series of commands upon a predefined string. First, you will receive a string, and afterward, until the command "Done" is given, you will be receiving strings with commands split by a single space. The commands will be the following:
            var password = Console.ReadLine();

            string command = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            while (command != "Done")
            {
                var tokens = command.Split(" "
                    , StringSplitOptions.RemoveEmptyEntries);
                string cmd = tokens[0];

                switch (cmd)
                {
                    case "TakeOdd":
                        password = TakeOdd(password);
                        break;
                    case "Cut":
                        int startIndex = int.Parse(tokens[1]);
                        int lenght = int.Parse(tokens[2]);
                        password = password.Remove(startIndex, lenght);

                        Console.WriteLine(password);
                        break;
                    case "Substitute":
                        var substring = tokens[1];
                        string sub = tokens[2];
                        if (!password.Contains(substring))
                        {
                            Console.WriteLine("Nothing to replace!");
                            command = Console.ReadLine();
                            continue;
                        }
                        password = password.Replace(substring, sub);

                        Console.WriteLine(password);
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {password}");
        }

        public static string TakeOdd(string password)
        {
            string newPass = string.Empty;
            for (int i = 0; i < password.Length; i++)
            {
                if (i % 2 != 0)
                {
                    newPass += password[i];
                }
            }
            password = newPass;

            Console.WriteLine(password);

            return password;
        }
    }
}
