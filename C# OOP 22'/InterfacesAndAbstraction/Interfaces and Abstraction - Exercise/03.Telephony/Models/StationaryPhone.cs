namespace Telephony.Models
{
    using System;
    using System.Linq;
    using Models.Contracts;

    using Telephony.Exceptions;

    public class StationaryPhone : IStationaryPhone
    {
        public StationaryPhone()
        {

        }

        public string Call(string phoneNumber)
        {
            if (!this.ValidatePhoneNumber(phoneNumber))
            {
                throw new InvalidPhoneNumberException();
            }

            return $"Dialing... {phoneNumber}";
        }

        private bool ValidatePhoneNumber(string phoneNumber)
            => phoneNumber.All(ch => char.IsDigit(ch));
           // => !phoneNumber.Any(ch => !char.IsDigit(ch));
    }
}
