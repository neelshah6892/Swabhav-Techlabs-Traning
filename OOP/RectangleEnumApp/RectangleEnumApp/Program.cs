using System;

namespace RectangleEnumApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            Console.WriteLine(rect.GetColor());
            rect.SetColor(ColorType.BLUE);
            Console.WriteLine(rect.GetColor());

        }
    }
}
