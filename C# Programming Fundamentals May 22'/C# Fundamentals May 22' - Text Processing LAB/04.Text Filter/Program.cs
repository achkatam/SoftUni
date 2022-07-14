using System;

namespace _04.Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable for banned words
            var words = Console.ReadLine().Split(", ");

            string text = Console.ReadLine();

            foreach (var word in words)
            {
                //string replacingElement = new string('*', word.Length);

                text = text.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(text);
        }
    }
}
