using System;
using ShapeInheritence.Modal;

namespace ShapeInheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(10, 10, 5.5f, "red");
            printDetails(c);

            Rectangle r = new Rectangle(100, 100, 25, 35, "green");
            printDetails(r);
        }

        public static void printDetails(Shape shape)
        {
            Console.WriteLine("X=" + shape.X + "Y=" + shape.Y + "Area=" + shape.CalculateArea() 
                + "Color=" + shape.Color);
        }
    }
}
