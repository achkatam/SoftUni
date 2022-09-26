namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
           // string path = @"C:\Users\agmat\Downloads";
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            //         .ext    
            SortedDictionary<string, List<FileInfo>> dict = new SortedDictionary<string, List<FileInfo>>();

            string[] files = Directory.GetFiles(inputFolderPath);

            foreach (var file in files)
            {
                FileInfo fileInfo = new FileInfo(file);

                if (!dict.ContainsKey(fileInfo.Extension))
                {
                    dict.Add(fileInfo.Extension, new List<FileInfo>());
                }

                dict[fileInfo.Extension].Add(fileInfo);
            }

            //order the files
            var orderedFiles = dict.OrderByDescending(x => x.Value.Count())
                .ToDictionary(x => x.Key, x => x.Value);

            StringBuilder sb = new StringBuilder();

            foreach (var file in orderedFiles)
            {
                sb.AppendLine(file.Key);

                var ordered = file.Value.OrderByDescending(x => x.Length);

                foreach (var item in ordered)
                {
                    sb.AppendLine($"--{item.Name} - {(double)item.Length / 1024:f3}kb");
                }
            }
            Console.WriteLine(sb.ToString());

            return sb.ToString().TrimEnd();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + reportFileName;

            //override the file
            File.WriteAllText(filePath, textContent);
        }
    }
}
