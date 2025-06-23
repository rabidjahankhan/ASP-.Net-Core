using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public double Balance { get; private set; }

        public BankAccount(string number, string name, double initialBalance)
        {
            AccountNumber = number;
            AccountName = name;
            Balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"{amount} deposited to {AccountName}. New balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"{amount} withdrawn from {AccountName}. New balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Invalid withdraw amount or insufficient balance.");
            }
        }
        public void Transfer(BankAccount toAccount, double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                this.Balance -= amount;
                toAccount.Balance += amount;
                Console.WriteLine($"{amount} transferred from {AccountName} to {toAccount.AccountName}.");
                Console.WriteLine($"{AccountName} balance: {Balance}");
                Console.WriteLine($"{toAccount.AccountName} balance: {toAccount.Balance}");
            }
            else
            {
                Console.WriteLine("Transfer failed: invalid amount or insufficient balance.");
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Account: {AccountNumber} - {AccountName}, Balance: {Balance}");
        }
    }
}
