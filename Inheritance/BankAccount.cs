using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class BankAccount
    {
        public string AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public decimal Balance { get;private set; }

        //public double ServiceCharge { get; set; }
        //public double InterestRate { get; set; }

        public string Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                return "Deposit successful";
            }
            else
            {
                return "Deposit failed";
            }
        }
        public string Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                return "Withdrawal successful";
            }
            else
            {
                return "Withdrawal failed";
            }
        }
    }
}
