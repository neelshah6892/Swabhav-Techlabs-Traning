using System;
using System.Collections.Generic;
using StudentApp.Modal;

namespace StudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            //Student student1 = new Student(1, "Neel", {"Maths", "Science"}, {100, 80});
            //Student student1 = new Student(1, "Neel");
            Student s1 = new Student(1, "Neel");
            s1.addSubject("Maths");
            s1.addSubject("Science");
            s1.addSubject("History");
            s1.addMarks(90);
            s1.addMarks(80);
            s1.addMarks(70);

            Student s2 = new Student(2, "Dhwani");
            s2.addSubject("Maths");
            s2.addSubject("Science");
            s2.addSubject("Geography");
            s2.addMarks(100);
            s2.addMarks(90);
            s2.addMarks(90);

            Student s3 = new Student(3, "Kannan");
            s3.addSubject("History");
            s3.addSubject("Computers");
            s3.addSubject("English");
            s3.addMarks(90);
            s3.addMarks(70);
            s3.addMarks(80);

            students.Add(s1);
            students.Add(s2);
            students.Add(s3);

            foreach (Student student in students)
            {
                Printinfo(student);
            }
        }

        public static void Printinfo(Student student)
        {
            //avg score, max score, min score, second max score
            Console.WriteLine("Roll no.: " + student.RollNumber + " Name: " + student.Name);

            List<String> subjects = student.Subjects;
            foreach(String subject in subjects)
            {
                Console.WriteLine(subject);
            }

            List<Int32> scores = student.Scores;
            foreach (Int32 score in scores)
            {
                Console.WriteLine(score);
            }
            Console.WriteLine("Max Score: " + student.MaxScore);
            Console.WriteLine("Min Score: " + student.MinScore);
            Console.WriteLine("Average: " + student.Average);
            Console.WriteLine("Second Max: " + student.SecondMax);
        }
    }
}
