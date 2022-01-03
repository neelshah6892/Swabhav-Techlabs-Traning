using System;
using StudentPropertyApp.Model;

namespace StudentPropertyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Name = "Neel";
            Console.WriteLine(s1.Name);
        }
    }
}
