using System;
using CirclePropertyApp.Model;

namespace CirclePropertyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle cir = new Circle();
            cir.Radius = 8;
            cir.Area = 8;
            Console.WriteLine(cir.Radius);
            Console.WriteLine(cir.Area);
        }
    }
}
