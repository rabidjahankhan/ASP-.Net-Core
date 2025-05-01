using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingAccount sv1 = new SavingAccount();
            sv1.InterestRate = 500;
            sv1.AccountNumber = "123456789";
            sv1.CustomerName = "Ishrat Jahan Khan";
            Console.WriteLine(sv1.Deposit(amount: 10000));
            Console.WriteLine(sv1.Withdraw(amount: 5202500));
            Console.WriteLine(sv1.Withdraw(amount: 5000));

            CheckingAccount ca1 = new CheckingAccount();
            ca1.ServiceCharge = 50000;
            ca1.AccountNumber = "123456789";
            ca1.CustomerName = "RAbid Jahan Khan";
            Console.WriteLine(ca1.Deposit(amount: 10000));
            Console.WriteLine(ca1.Withdraw(amount: 5202500));

            Console.ReadKey();
            
            //double balance = (double)sv1.Balance;

            //Console.WriteLine("Account Number: " + sv1.AccountNumber);
            //Console.WriteLine("Customer Name: " + sv1.CustomerName);
            //Console.WriteLine("Balance: " + sv1.Balance);

        }
    }
}
