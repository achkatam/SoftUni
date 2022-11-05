namespace Telephony.IO
{
    using System;
    using System.IO;

    using Telephony.IO.Contracts;

    public class FileReader : IReader
    {
        private string filePath;
        private string[] fileAllLines;

        public string FilePath
        {
            get => this.filePath;
            private set
            {
                if (!Directory.Exists(value))
                {
                    throw new ArgumentException("Invalid file path");
                }

                this.filePath = value;
            }
        }

        public FileReader(string filePath)
        {
            this.FilePath = filePath;
            this.fileAllLines = File.ReadAllLines(filePath);
            this.RowNumber = 0;
        }

        public int RowNumber { get; private set; }

        public string ReadLine()
        {
            if (this.RowNumber >= fileAllLines.Length)
            {
                throw new ArgumentException("Too long");
            }

            return this.fileAllLines[this.RowNumber++];
        }
    }
}
