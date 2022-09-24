using System;
using System.IO;

namespace MergeFiles
{
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\input1.txt";
            var secondInputFilePath = @"..\..\..\input2.txt";
            var outputFilePath = @"..\..\..\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {

            using var firstReader = new StreamReader(firstInputFilePath);
            using var secReader = new StreamReader(secondInputFilePath);
            using var writer = new StreamWriter(outputFilePath);

            var max = (Math.Max(firstInputFilePath.Length, secondInputFilePath.Length));

            for (int i = 0, j = 0; i <= Math.Max(firstInputFilePath.Length, secondInputFilePath.Length); i++, j++)
            {
                if (i % 2 == 0 && j % 2 == 0)
                {
                    writer.WriteLine(firstReader.ReadLine());
                }
                else
                {
                    writer.WriteLine(secReader.ReadLine());
                }

            }

        }
    }
}
