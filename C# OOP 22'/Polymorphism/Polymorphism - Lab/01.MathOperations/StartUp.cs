﻿namespace Operations
{
    using System;

    public class StartUp
    {
        static void Main(string[] args)
        {
            MathOperations mo = new MathOperations();

            Console.WriteLine(mo.Add(1, 4));
            Console.WriteLine(mo.Add(2.2, 3.3, 5.5));
            Console.WriteLine(mo.Add(2.2m, 3.3m, 4.4m));
        }
    }
}
