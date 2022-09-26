namespace LineNumbers
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            var lines = File.ReadAllLines(inputFilePath);

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < lines.Length; i++)
            {
                //counters
                int letters = lines[i].Count(x => char.IsLetter(x));
                int symbols = lines[i].Count(x => char.IsPunctuation(x));

                sb.AppendLine($"Line {i + 1}: {lines[i]} ({letters})({symbols})");
            }

            File.WriteAllText(outputFilePath, sb.ToString());
        }
    }
}
