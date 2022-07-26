using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace D02._Fancy_Barcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfInputs = int.Parse(Console.ReadLine());

            string pattern = @"@[#]+(?<barcode>[A-Z][A-Za-z0-9]{4,}[A-Z])@[#]+";

            for (int i = 0; i < numOfInputs; i++)
            {
                string input = Console.ReadLine();
                var match = Regex.Match(input, pattern);

                string productGroup = "00";
                string tempGroup = string.Empty;

                if (match.Success)
                {
                    string currChar = match.Groups["barcode"].Value;

                    foreach (var symbol in currChar.Where(symbol => char.IsDigit(symbol)))
                    {
                        tempGroup += symbol;
                        productGroup = tempGroup;
                    }

                    Console.WriteLine($"Product group: {productGroup}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
