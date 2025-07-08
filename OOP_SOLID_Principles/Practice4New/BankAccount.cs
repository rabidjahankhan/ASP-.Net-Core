using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4New
{
    public class BankAccount
    {
        public string accountNumber;
        public string accountHolderName;
        public double balance;

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be positive.");
            }
            if (amount > balance)
            {
                throw new Exception("withdraw failed. Insufficient balance");
            }
            balance = balance - amount;
        }

        public bool Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                return true;
            }
            return false;
        }

        public void Transfer(BankAccount targetAccount, double amount)
        {
            Withdraw(amount);
            targetAccount.Deposit(amount);
        }
    }
}
