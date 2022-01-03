using System;
using System.Collections.Generic;
using SetOperationApp.Modal;

namespace SetOperationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1
            HashSet<String> states = new HashSet<string>();
            states.Add("MH");
            states.Add("MH");
            states.Add("GJ");
            Console.WriteLine("States Count: " + states.Count);

            //Part 2
            Student s1 = new Student(101, "Neel");
            Student s2 = new Student(101, "Neel");
            Console.WriteLine("s1 address: " + s1.GetHashCode());
            Console.WriteLine("s2 address: " + s2.GetHashCode());

            Console.Write("s1==s2: ");
            Console.WriteLine(s1 == s2);
            Console.Write("s1==s1: ");
            Console.WriteLine(s1 == s1);

            Console.Write("s1.Equals(s2): ");
            Console.WriteLine(s1.Equals(s2));

            //Part 3
            HashSet<Student> students = new HashSet<Student>();
            students.Add(s1);
            students.Add(s2);
            Console.WriteLine(s1 == s2);
            Console.WriteLine(s1.Equals(s2));
            Console.WriteLine(states.Count);
        }
    }
}
