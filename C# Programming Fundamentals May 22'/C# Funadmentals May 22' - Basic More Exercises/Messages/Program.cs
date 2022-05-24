using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int digits = int.Parse(Console.ReadLine());

            int mainDigit = 0;
            int digitCntr = 0;
            int counter = 0;
            int letterIndex = 0;
            string text = string.Empty;

            //Digit   2   3   4   5   6   7   8   9
            //•	Index  0 1 2   •	3 4 5   •	6 7 8   •	9 11 12 •	13 14 15    •	16 17 18 19 •	20 21 22    •	23 24 25 26
            //•	Letter  •	a b c   •	d e f   •	g h i   •	j k  l •	m n  o •	p q  r s	•	t u v   •	w x  y z
            //•	Let’s take the number 222(c) for example.Our algorithm would look like this:
            //o   Find the number of digits the number has "e.g. 222  3 digits"
            //o   Find the main digit of the number “e.g.  222  2”
            //o   Find the offset of the number.To do that, you can use the formula: (main digit - 2) *3
            //o If the main digit is 8 or 9, we need to add 1 to the offset, since the digits 7 and 9 have 4 letters each
            //o Finally, find the letter index(a  0, c  2, etc.).To do that, we can use the following formula: (offset + digit length - 1).
            //o After we’ve found the letter index, we can just add that to the ASCII code of the lowercase letter "a"(97)


            for (int i = 0; i < digits; i++)
            {
                string chars = Console.ReadLine();
                string figures = string.Empty;
                counter = 0;
                for (int k = 0; k <= chars.Length - 1; k++)
                {
                    counter++;
                    figures += chars[k];
                }
                digitCntr = int.Parse(figures);
                mainDigit = digitCntr % 10;

                int offset = (mainDigit - 2) * 3;

                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset += 1;
                }

                letterIndex = 97 + offset + counter - 1;
                if (digitCntr == 0)
                {
                    letterIndex = 32;
                }
                text += (char)(letterIndex);


            }
            Console.WriteLine(text);

        }
    }
}