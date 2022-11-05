namespace Telephony.Models
{
    using System;
    using System.Linq;


    using Telephony.Exceptions;
    using Telephony.Models.Contracts;

    public class Smartphone : ISmartphone
    {
        public string Call(string phoneNumber)
        {
            if (!this.ValidatePhoneNumber(phoneNumber))
            {
                throw new InvalidPhoneNumberException();
            }

            return $"Calling... {phoneNumber}";
        }

        public string BrowseURL(string url)
        {
            if (!this.ValidURL(url))
            {
                throw new InvalidURLException();
            }

            return $"Browsing: {url}!";
        }

        private bool ValidatePhoneNumber(string phoneNumber) => phoneNumber.All(ch => char.IsDigit(ch));

        private bool ValidURL(string url)
            => url.All(ch => !char.IsDigit(ch));
    }
}
