using System;

namespace RectangleApp.Model
{
    class Rectangle
    {
        private int width;
        private int height;
        private string color;

        public void SetColor(string pcolor)
        {
            pcolor = pcolor.ToLower();
            if (pcolor.Equals("red"))
                color = pcolor;
            else if (pcolor.Equals("blue"))
                color = pcolor;
            else if (pcolor.Equals("white"))
                color = pcolor;
            else
                color = "red";

            Console.WriteLine("End of SetColor");
        }

        public string GetColor()
        {
            return color;
        }
        private int CorrectValue(int val)
        {
           if (val >= 1 && val <= 100)
                return val;
           if (val < 1)
                return  1;
         
           return  100;
            
        }
        public void SetWidth(int pwidth)
        {
            width = CorrectValue(pwidth);
        }

        public void SetHeight(int pheight)
        {
            height = CorrectValue(pheight);
        }

        public int GetWidth()
        {
            return CorrectValue(width);
        }

        public int GetHeight()
        {
            return CorrectValue(height);
        }

        public int Area()
        {
            return CorrectValue(width) * CorrectValue(height);
        }

    }
}
