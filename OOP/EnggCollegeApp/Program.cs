using System;
using EnggCollegeApp.Modal;

namespace EnggCollegeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(1, "Mumbai", "06 Aug", Branch.Computer, Year.Third);
            Console.WriteLine(s1);

            Professor p1 = new Professor(1, "Mumbai", "12 Dec", 100000);
            Console.WriteLine(p1);
        }

        
    }
}
