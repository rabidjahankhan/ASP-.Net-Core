using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount("001", "Rabid Khan", 1000);
            BankAccount account2 = new BankAccount("002", "Anik Hossain", 500);

            account1.ShowInfo();
            account2.ShowInfo();

            account1.Deposit(200);
            account1.Withdraw(150);
            account1.Transfer(account2, 300);

            account1.ShowInfo();
            account2.ShowInfo();
        }
    }
}
