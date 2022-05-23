using System;

namespace Switch_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // S W I T C H S T A T E M E N T S
            char myGrade = 'A';

            switch (myGrade)
            {
                case 'A':
                    Console.WriteLine($"You pass.");
                    break;
                case 'F':
                    Console.WriteLine($"You fail.");
                    break;
                default:
                    Console.WriteLine($"Invalid grade.");
                    break;
            }
        }
    }
}
