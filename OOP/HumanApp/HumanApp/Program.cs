using System;
using HumanApp.Model;

namespace HumanApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Human h1 = new Human(7.3f,60,21,"NEel");
            PrintInfo(h1);
            h1.Eat();
            
            PrintInfo(h1);
            Human h2 = new Human(7.3f, 75, "NEel");
            PrintInfo(h2);
            h2.Play();
            PrintInfo(h2);

            PrintInfo(new Human(8.6f, 50, "NEEL"));
        }

        static void PrintInfo(Human hum)
        {
            Console.WriteLine("Name: " + hum.Name);
            Console.WriteLine("Height: " + hum.Height);
            Console.WriteLine("Weight: " +hum.Weight);
            Console.WriteLine("Age: " + hum.Age);
        }
    }
}
