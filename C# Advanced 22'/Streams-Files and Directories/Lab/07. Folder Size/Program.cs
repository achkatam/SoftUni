using System.IO;

namespace FolderSize
{
    public class FolderSize
    {
        static void Main()
        {
            string folderPath = @"..\..\..\TestFolder";
            string outputPath = @"..\..\..\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            var folderInfo = new DirectoryInfo(folderPath);
            FileInfo[] files = folderInfo.GetFiles("*", SearchOption.AllDirectories);

            double size = 0;
            foreach (var file in files)
            {
                size += file.Length;
            }

            using (var writer = new StreamWriter(outputFilePath))
            {
                writer.Write(size / 1024);
            }
        }
    }
}
