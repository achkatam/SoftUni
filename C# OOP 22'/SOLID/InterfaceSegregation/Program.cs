namespace InterfaceSegregation
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAcc = new BankAccount(2000);

            bankAcc.Pay(200);

            bankAcc.CheckBalance();

            bankAcc.Withdraw(400);

            bankAcc.Deposit(111);
        }
    }
}
