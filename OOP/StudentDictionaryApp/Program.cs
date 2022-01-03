using System;
using System.Collections.Generic;
using StudentDictionaryApp.Modal;

namespace StudentDictionaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Student, Student> students = new System.Collections.Generic.Dictionary<Student, Student>();
            Student s1 = new Student(101, "Neel", 10);
            Student s2 = new Student(101, "Neel", 8);
            Student s3 = new Student(101, "Kannan", 10);

            students.Add(s1, s1);
            students.Add(s2, s2);
            students.Add(s3, s3);

            foreach (KeyValuePair<Student, Student> student in students)
            {
                Printinfo(student);
            }
        }

        public static void Printinfo(KeyValuePair<Student,Student> student)
        {
            Console.WriteLine("Roll Number: " + student.Value.RollNumber + " Name: "+ student.Value.Name+" Standard: "+student.Value.Standard);
        }
    }
}
