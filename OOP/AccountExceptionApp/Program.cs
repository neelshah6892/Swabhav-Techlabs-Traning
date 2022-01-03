using System;
using AccountExceptionApp.Modal;

namespace AccountExceptionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Accounts acc1 = new Accounts(101, "Neel", 1000);
            acc1.Withdraw(400);
            PrintInfo(acc1);

            Accounts acc2 = new Accounts(102, "Dhiren", 3000);
            acc2.Withdraw(2600);
            PrintInfo(acc2);
        }

        public static void PrintInfo(Accounts account)
        {
            Console.WriteLine(account.ID + " " + account.Name + " " + account.Balance);
        }
    }
}
