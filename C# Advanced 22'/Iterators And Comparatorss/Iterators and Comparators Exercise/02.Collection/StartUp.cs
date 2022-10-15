using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Collection
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<string> item = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Skip(1).ToList();

            ListyIterator<string> listyIterator = new ListyIterator<string>(item);


            string command = Console.ReadLine();


            while (command != "END")
            {
                switch (command)
                {
                    case "Move":
                        Console.WriteLine(listyIterator.Move());
                        break;
                    case "HasNext":
                        Console.WriteLine(listyIterator.HasNext());
                        break;
                    case "Print":
                        try
                        {
                            listyIterator.Print();
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine(exception.Message);
                            throw;
                        }
                        break;
                    case "PrintAll":
                        foreach (var list in listyIterator)
                        {
                            Console.Write($"{list} ");
                        }
                        Console.WriteLine();
                        break;
                }


                command = Console.ReadLine();
            }

        }
    }
}
