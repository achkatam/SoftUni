namespace InterfaceSegregation
{
using System;

    public class BankAccount : IBankAccount
    {
        public BankAccount(decimal balance)
        {
            this.Balance = balance;
        }

        public decimal Balance { get; set; }

        public void CheckBalance()
        {
            Console.WriteLine($"You have {this.Balance:f2} amount of money.");
        }

        public decimal Deposit(decimal sum) => this.Balance += sum;

        public void Pay(decimal sum)
        {
            if (this.Balance >= sum)
                this.Balance-= sum;

            Console.WriteLine("Transaction successful.");
        }

        public void Withdraw(decimal sum)
        {
            if (this.Balance >= sum)
                this.Balance-= sum;

            Console.WriteLine($"Available balance {this.Balance:f2}");
        }
    }
}
