using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    public class BankAccount
    {
        public string AccountNumber;
        public string AccountHolderName;
        public double Balance;
    }

    public void Diposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited: {amount}. New Balance: {Balance}");
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
                Console.WriteLine($"Withdrawn: {amount}. New Balance: {Balance}");
            }
            else if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds for withdrawal.");
            }
            else
            {
                Console.WriteLine("Withdrawal amount must be positive.");
            }
        }
        public void Transfer(BankAccount targetAccount, double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Withdraw(amount);
                targetAccount.Diposit(amount);
                Console.WriteLine($"Transferred: {amount} to {targetAccount.AccountHolderName}. New Balance: {Balance}");
            }
            else if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds for transfer.");
            }
            else
            {
                Console.WriteLine("Transfer amount must be positive.");
            }
        }
    }
