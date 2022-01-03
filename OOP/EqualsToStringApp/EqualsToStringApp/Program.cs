using System;
using AccountApp.Modal;

namespace EqualsToStringApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account("101", "abc", 50000);

            Console.WriteLine(acc1);
            Console.WriteLine(acc1.ToString());

            Account acc2 = new Account("101", "abc", 50000);

            Console.WriteLine(acc1 == acc2);
            Console.WriteLine(acc1.Equals(acc2));
        }
    }
}
