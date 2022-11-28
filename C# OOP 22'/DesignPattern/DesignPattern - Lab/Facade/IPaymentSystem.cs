namespace Facade
{
    //Facade
    public interface IPaymentSystem
    {
        bool MakePayment(Account from, Account to);
    }
}
