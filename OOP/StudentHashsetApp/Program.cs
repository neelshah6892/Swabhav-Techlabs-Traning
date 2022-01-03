using System;
using System.Collections.Generic;
using StudentHashsetApp.Modal;

namespace StudentHashsetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Student> students = new HashSet<Student>();
            Student s1 = new Student(101, "Neel", 10);
            Student s2 = new Student(101, "Neel", 8);
            Student s3 = new Student(101, "Kannan", 10);

            students.Add(s1);
            students.Add(s2);
            students.Add(s3);

            /*foreach(Student student in students)
            {
                Printinfo(student);
            }*/
            Printinfo(students);
        }

        public static void Printinfo(HashSet<Student> student)
        {
            Console.WriteLine("Count: " + student.Count);
        }
    }
}
