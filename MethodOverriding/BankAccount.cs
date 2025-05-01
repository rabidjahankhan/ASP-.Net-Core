using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    internal class BankAccount
    {
        public string AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public decimal Balance { get; private set; }

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
        public virtual string Withdraw(decimal amount)
        {
            Balance -= amount;
            return "Withdrawal successful";


            //if (amount <= 0)
            //{
            //    return "Withdrawal failed: amount must be positive";
            //}

            //if (amount > Balance)
            //{
            //    return "Insufficient balance";
            //}

            //Balance -= amount;
            //return "Withdrawal successful";
        }
    }
}
