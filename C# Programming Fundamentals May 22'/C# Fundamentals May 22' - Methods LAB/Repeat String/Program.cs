using System;
using System.Text;

namespace Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int repeatCnt = int.Parse(Console.ReadLine());

            string result = RepeatString(input, repeatCnt);
            Console.WriteLine(result);
            //Console.WriteLine(RepeatString(input, repeatCnt));
        }
        //Create method which receives two parameters string and integer
        //This will represent how many times the string will be repeated
        static string RepeatString(string input, int repeat)
        {
            //Using StringBuilder will make the program running smoother.
            //This method doesn't create a new string every cycle of the loop but adds it tot the 
            //existing one. Creates new string at the end, so doesn't bother the memory at all.
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < repeat; i++)
            {
                result.Append(input);// adds the string to the existing one
            }
            return result.ToString();

            //Using for loop creates new strings every cycle of the loop. In case of 50 000 000 repetitions it will create 50 000 000 new string which make the program too big for nothing. Using StringBuilder is recommended !!!
            //string result = string.Empty;
            ////For loop
            //for (int i = 0; i < repeat; i++)
            //{
            //    result += input;
            //}

            //return result;
        }
    }
}
