using System;

namespace AbstractionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Console.WriteLine(e1.age);
            Console.WriteLine(e1.name);
            Console.WriteLine(e1.GetHashCode());
            e1.age = 100;
            e1.name = "Saurabh";
            Console.WriteLine(e1.age);
            Console.WriteLine(e1.name);
            Console.WriteLine(e1.GetHashCode());
            
        }
    }
}
