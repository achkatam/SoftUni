using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace D02._Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(@#+)(?<barcode>[A-Z][A-Za-z\d]{4,}[A-Z])(@#+)";

            //Next, you have to determine the product group of the item from the barcode. The product group is obtained by concatenating all the digits found in the barcode. If there are no digits present in the barcode, the default product group is "00".
            //        Examples:
            //@#FreshFisH@# -> product group: 00
            //@###Brea0D@### -> product group: 0
            //@##Che4s6E@## -> product group: 46

            //num of inputs
            int num = int.Parse(Console.ReadLine());

            string defaultGroup = "00";

            for (int i = 0; i < num; i++)
            {
                string input = Console.ReadLine();

                var matches = Regex.Matches(input, pattern);

                if (matches.Count > 0)
                {
                    foreach (Match match in matches)
                    {
                        var digits = input.Where(x => char.IsDigit(x)).ToArray();

                        if (digits.Length == 0)
                        {
                            defaultGroup = "00";

                            Console.WriteLine($"Product group: {defaultGroup}");
                        }
                        else
                        {
                            defaultGroup = string.Join("", digits);

                            Console.WriteLine($"Product group: {defaultGroup}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }

            }
        }
    }
}
