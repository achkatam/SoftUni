namespace SquareRoot
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 0)
                    throw new ArithmeticException("Invalid number.");

                Console.WriteLine(Math.Sqrt(number));
            }
            catch (ArithmeticException ae)
            {
                Console.WriteLine(ae.Message);
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }

        }
    }
}
