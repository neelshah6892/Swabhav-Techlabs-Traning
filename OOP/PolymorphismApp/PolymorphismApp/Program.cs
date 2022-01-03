using System;
using PolymorphismApp.Modal;

namespace PolymorphismApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //case_1();
            Accounts[] accountList = new Accounts[5];
            accountList[0] = new SavingsAccount(100, "Neel", 6000);
            accountList[1] = new CurrentAccount(100, "kifs", 6000);
            accountList[2] = new SavingsAccount(101, "Kannan", 12000);
            accountList[3] = new CurrentAccount(102, "Swabhav", 18000);
            accountList[4] = new CurrentAccount(103, "Nova", 9000);

            //case_2();

            //max(acc);

            double sum = 0;
            foreach(Accounts account in accountList)
            {
                sum += account.Balance;
            }
            Console.WriteLine(sum);
            Console.WriteLine(sum / accountList.Length);
        }

        private static void max(Accounts[] acc)
        {
            double temp = acc[0].Balance;
            foreach (Accounts account in acc)
            {
                if (temp < account.Balance)
                    temp = account.Balance;

            }
            Console.WriteLine(temp);
        }

        private static void case_2()
        {
            int[] arr = { -5, -4, -6, -3, -2, -1 };
            int temp = arr[0];
            //int temp = arr[0];
            foreach (int arra in arr)
            {
                if (temp < arra)
                    temp = arra;

            }
            Console.WriteLine(temp);
        }

        private static void case_1()
        {
            SavingsAccount sav1 = new SavingsAccount(100, "Neel", 6000);
            printDetails(sav1);
            sav1.Deposit(6000);
            printDetails(sav1);
            sav1.Withdraw(9000);
            printDetails(sav1);
            sav1.Withdraw(3000);
            printDetails(sav1);

            CurrentAccount cur1 = new CurrentAccount(100, "kifs", 6000);
            printDetails(cur1);
            cur1.Deposit(6000);
            printDetails(cur1);
            cur1.Withdraw(9000);
            printDetails(cur1);
            cur1.Withdraw(3000);
            printDetails(cur1);
        }

        public static void printDetails(Accounts accounts)
        {
            Console.WriteLine("Acc no: " + accounts.Accountno + " Name: " + accounts.Name + " Balance: " + accounts.Balance);
        }
    }
}
