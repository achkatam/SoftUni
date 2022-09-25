using System.IO;
using System.Net.Http.Headers;

namespace ExtractBytes
{
    public class ExtractBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\example.png";
            string bytesFilePath = @"..\..\..\bytes.txt";
            string outputPath = @"..\..\..\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            using (FileStream image = new FileStream(binaryFilePath, FileMode.Open))
            {
                using (FileStream bytes = new FileStream(bytesFilePath, FileMode.Open))
                {
                    byte[] bufferBytes = new byte[bytes.Length];

                    bytes.Read(bufferBytes, 0, (int)bytes.Length);

                    byte[] bufferImage = new byte[bytes.Length];

                    bytes.Read(bufferImage, 0, (int)bytes.Length);

                    using (FileStream output = new FileStream(outputPath, FileMode.Create))
                    {
                        for (int i = 0; i < bufferImage.Length; i++)
                        {
                            for (int j = 0; j < bufferBytes.Length; j++)
                            {
                                if (bufferImage[i] == bufferBytes[j])
                                {
                                    output.Write(new byte[] { bufferImage[i] });
                                }
                            }
                        }
                    }

                }
            }



        }
    }
}
