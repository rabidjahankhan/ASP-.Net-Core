﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    internal class SavingAccount: BankAccount
    {

        public SavingAccount(string accountNo, string customerName, double interestAmount):base(accountNo, customerName)
        {
            InterestRate = interestAmount;
        }

        public double InterestRate { get; set; }

        public override string Withdraw(decimal amount)
        {
            if (Balance>amount)
            {
                return base.Withdraw(amount);
            }
            else
            {
                return "Insufficient balance";
            }
        }
    }
}
