namespace SingleResponsibilityAfter
{
    using System;


    internal class UserAuthentication
    {
        private EmailValidator emailValidator;
        private PasswordValidator passwordValidator;

        public UserAuthentication()
        {
        }

        public UserAuthentication(EmailValidator emailValidator, PasswordValidator passwordValidator)
        {
            this.emailValidator = emailValidator;
            this.passwordValidator = passwordValidator;
        }

        public void Register(string email, string password)
        {
            ////20 lines to register a user to database
            //if (!emailValidator.ValidateEmail(email))
            //{
            //    throw new ArgumentException("");
            //}

            //if (!passwordValidator.ValidatePassword(password))
            //{
            //    throw new ArgumentException("");
            //}
        }
    }
}
