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
            
            SavingAccount sv1 = new SavingAccount(accountNo:"1212", customerName:"Rabid", interestAmount:1200);
            sv1.Deposit(amount:5000);
            //sv1.InterestRate = 500;
            //sv1.AccountNumber = "123456789";
            //sv1.CustomerName = "Ishrat Jahan Khan";
            //Console.WriteLine(sv1.Deposit(amount: 10000));
            //Console.WriteLine(sv1.Withdraw(amount: 5202500));
            //Console.WriteLine(sv1.Withdraw(amount: 5000));
            //Console.WriteLine();
            //CheckingAccount ca1 = new CheckingAccount(accountNo:"2131", customerName: "Mahi", sarviceCharge:9000);
            //ca1.ServiceCharge = 50000;
            //ca1.AccountNumber = "123456789";
            //ca1.CustomerName = "RAbid Jahan Khan";
            //Console.WriteLine(ca1.Deposit(amount: 10000));
            //Console.WriteLine(ca1.Withdraw(amount: 5202500));

            Console.ReadKey();

            CheckingAccount ca1 = new CheckingAccount(accountNo: "2131", customerName: "Mahi", sarviceCharge: 9000);
            ca1.Deposit(amount: 5000); Console.ReadKey();

            //BankAccount ba1 = new BankAccount(accountNo:"3525", customerNAme: "Aprotim");
            //ba1.Deposit(amount: 5000); Console.ReadKey();

            BankAccount b1 = new BankAccount();
            b1.AccountNumber = "123456789";
            b1.CustomerName = "Ishrat Jahan Khan";
            b1.Deposit(amount: 10000);
            
            List<BankAccount> accounts = new List<BankAccount>();
            accounts.Add(sv1);
            accounts.Add(ca1);
            accounts.Add(b1);

            foreach (BankAccount bankAccount in accounts)
            {
                bankAccount.Deposit(amount: 1000);
                Console.WriteLine("Account Number: " + bankAccount.AccountNumber);
                Console.WriteLine("Customer Name: " + bankAccount.CustomerName);
                Console.WriteLine("Balance: " + bankAccount.Balance);
                Console.WriteLine();
            }

            //double balance = (double)sv1.Balance;

            //Console.WriteLine("Account Number: " + sv1.AccountNumber);
            //Console.WriteLine("Customer Name: " + sv1.CustomerName);
            //Console.WriteLine("Balance: " + sv1.Balance);

        }
    }
}
