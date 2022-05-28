using System;

namespace Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will receive a key(integer) and n characters afterward. Add the key to each of the characters and append them to a message. At the end print the message, which you decrypted. 
            //Input
            //•	On the first line, you will receive the key
            //•	On the second line, you will receive n – the number of lines, which will follow
            //•	On the next n lines – you will receive lower and uppercase characters from the Latin alphabet

            //input
            int key = int.Parse(Console.ReadLine());//this integer will be added to a letter
            int n = int.Parse(Console.ReadLine());
            //add-ons
            string message = string.Empty;
            //Attempt Solution
            for (int i = 0; i < n; i++)
            {
                char input = char.Parse(Console.ReadLine());
                int result = key + (int)input;
                char endChar = (char)result;
                message += endChar;
            }
            Console.WriteLine(message);
        }
    }
}
