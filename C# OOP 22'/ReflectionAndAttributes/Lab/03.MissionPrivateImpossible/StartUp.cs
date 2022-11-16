namespace Stealer
{
    using System;

    public class StartUp
    {
        static void Main(string[] args)
        {
            //Spy spy = new Spy();
            //string result = spy.StealFieldInfo("Stealer.Hacker", "username", "password");

            //Console.WriteLine(result);

            //Spy spy = new Spy();
            //string result = spy.AnalyzeAccessModifiers("Stealer.Hacker");

            //Console.WriteLine(result);

            Spy spy = new Spy();
            string result = spy.RevealPrivateMethods("Stealer.Hacker");

            Console.WriteLine(result);
        }
    }
}
