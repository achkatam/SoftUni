namespace MoneyTransactions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class BankAccount
    {

        public BankAccount(int accNumber, double accBalance)
        {
            this.AccNumber = accNumber;
            this.AccBalance = accBalance;
        }

        public int AccNumber { get; set; }
        public double AccBalance { get; set; }

        public List<BankAccount> BankAccounts { get; set; }

        public void AddBalance(int accNumber, double balance)
        {
            BankAccount account = BankAccounts.FirstOrDefault(x => x.AccNumber == accNumber);

            if (account == null)
                throw new ArgumentException("Invalid account!");

            account.AccBalance += balance;
        }
        public void Subtract(int accNumber, double balance)
        {
            BankAccount account = BankAccounts.FirstOrDefault(x => x.AccNumber == accNumber);

            if (account == null)
                throw new ArgumentException("Invalid account!");

            if (balance > account.AccBalance)
                throw new ArgumentException("Insufficient balance!");

            account.AccBalance -= balance;
        }

        public override string ToString()
        {
            return $"Account {this.AccNumber} has new balance: {this.AccBalance:f2}";
        }
    }

    public class StartUp
    {
        static void Main(string[] args)
        {
            List<BankAccount> accounts = new List<BankAccount>();

            string[] accInfo = Console.ReadLine()
                .Split(",", StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var acc in accInfo)
            {
                string[] accData = acc.Split("-", StringSplitOptions.RemoveEmptyEntries);
                int accNumber = int.Parse(accData[0]);
                double accBalance = double.Parse(accData[1]);

                BankAccount account = new BankAccount(accNumber, accBalance);

                accounts.Add(account);
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                var tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    string cmd = tokens[0];

                    switch (cmd)
                    {
                        case "Deposit":
                            {
                                int accNumber = int.Parse(tokens[1]);
                                double accBalance = double.Parse(tokens[2]);

                                //BankAccount acc = accounts.FirstOrDefault(x => x.AccNumber == accNumber);
                                //acc.AddBalance(accNumber, accBalance);
                                BankAccount account = accounts.FirstOrDefault(x => x.AccNumber == accNumber);

                                if (account == null)
                                    throw new ArgumentException("Invalid account!");

                                account.AccBalance += accBalance;

                                Console.WriteLine(account.ToString());
                            }
                            break;

                        case "Withdraw":
                            {
                                int accNumber = int.Parse(tokens[1]);
                                double accBalance = double.Parse(tokens[2]);

                                BankAccount account = accounts.FirstOrDefault(x => x.AccNumber == accNumber);

                                if (account == null)
                                    throw new ArgumentException("Invalid account!");

                                if (accBalance > account.AccBalance)
                                    throw new ArgumentException("Insufficient balance!");

                                account.AccBalance -= accBalance;

                                Console.WriteLine(account.ToString());
                            }
                            break;
                        default:
                            throw new FormatException("Invalid command!");
                            break;
                    }

                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
                catch (FormatException fr)
                {
                    Console.WriteLine(fr.Message);
                }
                catch (Exception)
                {
                    throw;
                }
                Console.WriteLine("Enter another command");

                command = Console.ReadLine();
            }
        }
    }
}

