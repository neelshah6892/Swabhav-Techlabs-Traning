using System;
using System.Reflection;
using AccountApp.Modal;
using CirclePropertyApp.Model;

namespace ReflectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account("101", "Neel");
            Console.WriteLine(acc.GetType());
        }
    }
}
