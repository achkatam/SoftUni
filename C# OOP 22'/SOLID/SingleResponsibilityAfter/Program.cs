namespace SingleResponsibilityAfter
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your email?");
            string email = Console.ReadLine();

            Console.WriteLine("What is your password");
            string password = Console.ReadLine();

            EmailValidator emailValidator = new EmailValidator();
            PasswordValidator passwordValidator= new PasswordValidator();
            UserAuthentication auth = new UserAuthentication();

            if (emailValidator.ValidateEmail(email) && passwordValidator.ValidatePassword(password))
            { 
                auth.Register(email, password);
            }

            UserReports reports = new UserReports();

            reports.GetAllUsers();
        }
    }
}
