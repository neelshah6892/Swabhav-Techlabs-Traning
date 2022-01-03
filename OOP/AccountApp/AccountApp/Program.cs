using System;
using AccountApp.Modal;

namespace AccountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account("1000", "Neel", 1000);
            PrintInfo(acc1);
            //acc1.Deposit(10000);
            acc1.Withdraw(400);
            PrintInfo(acc1);
            
            Account acc2 = new Account("2000", "Dhwani");
            PrintInfo(acc2);
            acc2.Deposit(10000);
            acc2.Withdraw(500);
            PrintInfo(acc2);

            PrintInfo(new Account("3000", "Swabhav"));
        }

        static void PrintInfo(Account acc)
        {
            Console.WriteLine(acc.Accountno);
            Console.WriteLine(acc.Name);
            Console.WriteLine(acc.Balance);
            Console.WriteLine(acc.GetHashCode());
        }
    }
}
