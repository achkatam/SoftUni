namespace Facade
{
    using System;
    

    public class PaymentSystemFacade : IPaymentSystem
    {
        private Bank bank = new Bank();
        private BlackList blackList = new BlackList();
        private ThreeDSVerification verification = new ThreeDSVerification();
        public bool MakePayment(Account from, Account to)
        {
            if (!blackList.CheckIfAccountIsBlackListed(from) &&                   
              !blackList.CheckIfAccountIsBlackListed(to))   
            {
                if (!verification.VerifyAccount(from) &&
                    !verification.VerifyAccount(to))
                {
                    bank.MakePayment(from, to, 20);

                    return true;
                }
            }

            return false;
        }
    }
}
