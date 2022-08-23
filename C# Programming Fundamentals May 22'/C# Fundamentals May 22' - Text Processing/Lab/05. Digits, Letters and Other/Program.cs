using System;
using System.Linq;
using System.Diagnostics;
using System.Text;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            //Using String Builder
            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder symbols = new StringBuilder();

            foreach (var element in input)
            {
                if (char.IsDigit(element))
                {
                    digits.Append(element);
                }
                else if (char.IsLetter(element))
                {
                    letters.Append(element);
                }
                else
                {
                    symbols.Append(element);
                }
                
            }

            //Using LINQ

            //char[] digits = input
            //    .Where(ch => char.IsDigit(ch))
            //    .ToArray();

            //char[] letters = input
            //    .Where(ch => char.IsLetter(ch))
            //    .ToArray();

            //char[] symbols = input
            //    .Where(ch => !char.IsLetterOrDigit(ch))
            //    .ToArray();

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(symbols);


        }
    }
}
