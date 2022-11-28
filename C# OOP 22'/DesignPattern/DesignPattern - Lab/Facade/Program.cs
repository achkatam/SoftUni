namespace Facade
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            Account jimmys = new Account();
            Account stephanies = new Account();
             

            IPaymentSystem paymentSystem = new PaymentSystemFacade();

            paymentSystem.MakePayment(jimmys, stephanies);
        }
    }
}
