using System;

namespace ExceptionStackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start of main");
            try
            {
                M1();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            Console.WriteLine("End of main");
        }

        static void M1()
        {
            Console.WriteLine("Inside M1");
            M2();
        }

        static void M2()
        {
            Console.WriteLine("Inside M2");
            M3();
        }

        static void M3()
        {
            Console.WriteLine("Inside M3");
            throw new Exception("Something went wrong");
        }

        #region Output before try-catch
        /*Start of main
        Inside M1
        Inside M2
        Inside M3

        Unhandled Exception: System.Exception: Something went wrong
        at ExceptionStackApp.Program.M3() in D:\Swabhav\OOP\ExceptionStackApp\Program.cs:line 29
        at ExceptionStackApp.Program.M2() in D:\Swabhav\OOP\ExceptionStackApp\Program.cs:line 23
        at ExceptionStackApp.Program.M1() in D:\Swabhav\OOP\ExceptionStackApp\Program.cs:line 17
        at ExceptionStackApp.Program.Main(String[] args) in D:\Swabhav\OOP\ExceptionStackApp\Program.cs:line 10*/
        #endregion
    }
}
