using System;
using CustomExceptionApp.Modal;

namespace CustomExceptionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            try
            {
                Console.WriteLine(cal.Add(10, 10));
                Console.WriteLine(cal.Add(10, -10));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }            
    }
}
