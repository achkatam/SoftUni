namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            StringBuilder sb = new StringBuilder();

            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                string line = String.Empty;
                int row = 0;

                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();

                    if (row % 2 == 0)
                    {
                        string replacedSymbols = ReplaceSymbols(line);
                        string reversed = ReverseWords(replacedSymbols);
                        sb.AppendLine(reversed);
                    }

                    row++;
                }

                return sb.ToString().TrimEnd();
            }

        }


        static string ReplaceSymbols(string line)
        {
            return
                line.Replace('.', '@')
                .Replace(',', '@')
                .Replace('-', '@')
                .Replace('!', '@')
                .Replace('?', '@');
        }
        static string ReverseWords(string replacedSymbols)
        {
            string[] reversedWords = replacedSymbols
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Reverse().ToArray();

            return string.Join(" ", reversedWords);
        }
    }
}
