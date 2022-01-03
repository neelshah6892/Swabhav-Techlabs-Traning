using System;
using RectangleApp.Model;

namespace RectangleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.SetColor("BLuE");
            Console.WriteLine(rect.GetColor());
            rect.SetWidth(105);
            rect.SetHeight(5);
            PrintInfo(rect);

           
            PrintInfo(rect);
           
            PrintInfo(rect);
            
            PrintInfo(rect);

            //rect.SetWidth(20);
            //rect.SetHeight(10);
            //PrintInfo(rect);
            //rect.SetWidth(80);
            //rect.SetHeight(50);
            //PrintInfo(rect);
            //Console.WriteLine(rect.CorrectValue(101));
        }

        static void PrintInfo(Rectangle rec)
        {
            Console.WriteLine("Width: " + rec.GetWidth() + "\nHeight: " + rec.GetHeight());
            Console.WriteLine("Area: " + rec.Area());
        }
    }
}
