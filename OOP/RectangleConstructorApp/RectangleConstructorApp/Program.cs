using System;

namespace RectangleConstructorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(Thickness.MEDIUM, 100, 20);
            PrintInfo(rect);
            
        }
        static void PrintInfo(Rectangle rec)
        {
            Console.WriteLine(rec.GetThickness());
            Console.WriteLine(rec.GetHeight());
            Console.WriteLine(rec.GetWidth());
            Console.WriteLine(rec.Area());
        }
    }
}
