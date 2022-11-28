namespace SingletonPatternExample
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before initializing");

            Console.WriteLine(UserSingleton.Instance.DeviceID); 
            Console.WriteLine(UserSingleton.Instance.DeviceID); 
            Console.WriteLine(UserSingleton.Instance.DeviceID); 
            Console.WriteLine(UserSingleton.Instance.DeviceID); 
        }
    }
}
