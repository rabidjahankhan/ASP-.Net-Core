using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    internal class CheckingAccount : BankAccount
    {
        public CheckingAccount(string accountNo, string customerName, double sarviceCharge):base(accountNo, customerName)
        {
            ServiceCharge = sarviceCharge;
        }

        public double ServiceCharge { get; set; }
    }
}
