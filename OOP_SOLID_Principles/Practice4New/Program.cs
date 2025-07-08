using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4New
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount1 = new BankAccount();
            bankAccount1.accountNumber = "123456789";
            bankAccount1.accountHolderName = "Rabid Jahan Khan";
            bankAccount1.balance = 1000.0;

            bankAccount1.Deposit(500.0);
            bankAccount1.Deposit(500.0);
            bankAccount1.Withdraw(200.0);

            try
            {
                bankAccount1.Withdraw(2000.0);
                Console.WriteLine("Withdrawal successful.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Withdrawal failed: " + ex.Message);
            }

            double balance1 = bankAccount1.balance;

            Console.WriteLine("Account Number: " + bankAccount1.accountNumber);
            Console.WriteLine("Account Holder Name: " + bankAccount1.accountHolderName);
            Console.WriteLine("Balance: " + balance1);

            BankAccount bankAccount2 = new BankAccount();
            bankAccount2.accountNumber = "987654321";
            bankAccount2.accountHolderName = "John Snow";
            bankAccount2.balance = 2000.0;

            bankAccount2.Deposit(30000.0);
            bankAccount2.Withdraw(10000.0);


            bankAccount1.Transfer(bankAccount2, 1000.0);

            double balance2 = bankAccount2.balance;

            Console.WriteLine("Account Number: " + bankAccount2.accountNumber);
            Console.WriteLine("Account Holder Name: " + bankAccount2.accountHolderName);
            Console.WriteLine("Balance: " + balance2);

            BankAccount bankAccount3 = new BankAccount();
            bankAccount3.accountNumber = "456789123";
            bankAccount3.accountHolderName = "Rob Stark";
            bankAccount3.balance = 150000.0;

            bankAccount3.Deposit(200000.0);

            try
            {
                bankAccount3.Withdraw(50000.0);
                Console.WriteLine("Withdrawal successful.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Withdrawal failed: " + ex.Message);
            }

            double balance3 = bankAccount3.balance;

            Console.WriteLine("Account Number: " + bankAccount3.accountNumber);
            Console.WriteLine("Account Holder Name: " + bankAccount3.accountHolderName);
            Console.WriteLine("Balance: " + balance3);

        }
    }
}
