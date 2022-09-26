namespace CopyBinaryFile
{
    using System;
    using System.IO;

    public class CopyBinaryFile
    {
        static void Main()
        {
            //Write a program that copies the contents of a binary file (e. g. copyMe.png) to another binary file (e. g. copyMe-copy.png) using FileStream. You are not allowed to use the File class or similar helper classes.

            string inputFilePath = @"..\..\..\copyMe.png";
            string outputFilePath = @"..\..\..\copyMe-copy.png";

            CopyFile(inputFilePath, outputFilePath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            //File.Copy(inputFilePath, outputFilePath);

            using (FileStream reader = new FileStream(inputFilePath, FileMode.Open))
            {
                using (FileStream writer = new FileStream(outputFilePath, FileMode.Create))
                {
                    while (true)
                    {
                        byte[] buffer = new byte[512];

                        int size = reader.Read(buffer, 0, buffer.Length);

                        if (size == 0) break;

                        writer.Write(buffer, 0, size);
                    }
                }
            }


        }
    }
}
