using System;

namespace CircleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle cir = new Circle(8.0f);
            PrintInfo(cir);
            Circle ci = new Circle(Border.DOUBLE, 2.0f);
            PrintInfo(ci);
        }

        static void PrintInfo(Circle circ)
        {
            Console.WriteLine(circ.GetBorder());
            Console.WriteLine(circ.GetRadius());
            Console.WriteLine(circ.Area());
        }
    }
}
