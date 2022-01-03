using System;
using InsufficientFundsExceptionApp.Modal;

namespace InsufficientFundsExceptionApp

{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(100, "Neel", 1000);
            //acc1.Deposit(1000);
            try
            {
                acc1.Withdraw(1000);
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Balance: " + acc1.Balance);
            }

            

        }
    }
}
