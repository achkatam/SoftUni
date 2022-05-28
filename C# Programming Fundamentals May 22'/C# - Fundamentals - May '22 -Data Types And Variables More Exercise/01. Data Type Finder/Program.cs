using System;

namespace _01._Data_Type_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will receive input until you receive "END".Find what data type is the input. Possible data types are:
            //•	Integer
            //•	Floating point 
            //•	Characters
            //•	Boolean
            //•	Strings
            //Print the result in the following format: "{input} is {data type} type"

            //input
            string input = Console.ReadLine();
            //add-ons
            int valueInt = 0;
            float valueFloat = 0.0f;
            char valueChar;
            bool valueBool;

            //Attempt solution
            while (input != "END")
            {
                if(int.TryParse(input, out valueInt))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (float.TryParse(input, out valueFloat))
                {
                    Console.WriteLine($"{input} is floating point type");

                }
                else if (char.TryParse(input, out valueChar))
                {
                    Console.WriteLine($"{input} is character type");

                }
                else if (bool.TryParse(input, out valueBool))
                {
                    Console.WriteLine($"{input} is boolean type");

                }
                else
                {
                    Console.WriteLine($"{input} is string type");

                }

                input = Console.ReadLine();
            }
        }
    }
}
