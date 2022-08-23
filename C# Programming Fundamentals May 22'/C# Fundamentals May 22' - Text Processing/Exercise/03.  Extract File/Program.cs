using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _03.__Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads the path to a file and subtracts the file name and its extension.

            string input = Console.ReadLine();

            int indexFileExtension = input.LastIndexOf('.');

            //Find the index of the separator, the extension is one position after that index
            string extension = input.Substring(indexFileExtension + 1);
            //Remove the everything after the separator, otherwise it will print the extension as well
            input = input.Remove(indexFileExtension);

            //Same for the name
            int name = input.LastIndexOf('\\');
            string fileName = input.Substring(name + 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");

        }
    }
}
