using System;
using RectanglePropertyApp.Model;

namespace RectanglePropertyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle();
            rec.Width = 100;
            rec.Height = 2;
            Console.WriteLine(rec.Width);
            Console.WriteLine(rec.Height);
            Console.WriteLine(rec.Area);
        }
    }
}
