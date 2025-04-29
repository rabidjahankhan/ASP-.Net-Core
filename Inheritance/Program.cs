using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheakingAccount cheakingAccount = new CheakingAccount();
            cheakingAccount.ServiceCharge = 0.02;
            cheakingAccount.AccountNumber = "987654321";
            cheakingAccount.CustomerName = "Ishrat Jahan Mahi";
            cheakingAccount.Deposit(2000);
            cheakingAccount.Withdraw(1000);
            Console.WriteLine(cheakingAccount.Balance);


            SavingAccount savingAccount = new SavingAccount();
            savingAccount.InterestRate = 0.05;
            savingAccount.AccountNumber = "123456789";
            savingAccount.CustomerName = "Rabid Jahan Khan";
            savingAccount.Deposit(1000);
            savingAccount.Withdraw(500);
            Console.WriteLine(savingAccount.Balance);

        }
    }
}
