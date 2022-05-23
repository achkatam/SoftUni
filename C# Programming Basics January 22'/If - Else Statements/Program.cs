using System;

namespace If___Else_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // I F E L S E S T A T E M E N T

            bool isStudent = false;
            bool isSmart = false;

            if (isSmart && isStudent)
            {
                Console.WriteLine($"You are a student");
            }
            else if (isStudent && !isSmart) 
            {
                Console.WriteLine($"You are not a smart student");
            }
            else
            {
                Console.WriteLine($"You are not a student and not smart.");
            }

            Console.WriteLine();

            // >, <, >=, <= ,!= ,==
            if (1 < 3)
            {
                Console.WriteLine($"Number comparison was true");
            }
        }
    }
}
