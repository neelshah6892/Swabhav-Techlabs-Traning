using System;

namespace EncapsulationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Console.WriteLine(e1.GetAge());
            Console.WriteLine(e1.GetName());
            e1.SetAge(10);
            Console.WriteLine(e1.GetAge());
            e1.SetName("Neel");
            Console.WriteLine(e1.GetName());
            Console.WriteLine(e1.GetHashCode());
            Employee e2 = e1;
            Console.WriteLine(e2.GetName());
            Console.WriteLine(e2.GetAge());
            Console.WriteLine(e2.GetHashCode());
            e2.SetName("Swabhav");
            Console.WriteLine(e2.GetName());
            Console.WriteLine(e1.GetName());
            Console.WriteLine("Anonymous Objetcs");
            Console.WriteLine(new Employee().GetName());
            Console.WriteLine(new Employee().GetAge());

            Employee[] emps = new Employee[5];
            /*foreach(Employee e in emps)
            {
                Console.WriteLine(e.GetName());
                Console.WriteLine(e.GetAge());
            }*/

            Employee emp1 = new Employee();
            emp1.SetAge(12);
            emp1.SetName("Hiya");

            Employee emp2 = new Employee();
            emp2.SetAge(12);
            emp2.SetName("Hiya");

            Employee emp3 = new Employee();
            emp3.SetAge(12);
            emp3.SetName("Hiya");

            Employee emp4 = new Employee();
            emp4.SetAge(30);
            emp4.SetName("Hiya");

            Employee emp5 = new Employee();
            emp5.SetAge(30);
            emp5.SetName("Hiya");

            /*foreach (Employee e in emps)
            {
                Console.WriteLine(e.GetName());
                Console.WriteLine(e.GetAge());
            }*/

            emps[0] = emp1;
            emps[1] = emp2;
            emps[2] = emp3;
            emps[3] = emp4;
            emps[4] = emp5;

            foreach (Employee e in emps)
            {
                Console.WriteLine(e.GetName());
                Console.WriteLine(e.GetAge());
            }
        }
    }
}
