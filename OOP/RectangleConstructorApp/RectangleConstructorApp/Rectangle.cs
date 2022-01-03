using System;

namespace RectangleConstructorApp

{
    class Rectangle
    {
        private int width;
        private int height;
        private Thickness thickness;

        public Rectangle(Thickness pthickness, int pwidth, int pheight)
        {
            thickness = pthickness;
            width = pwidth;
            height = pheight;
        }

        public Thickness GetThickness()
        {
            return thickness;
        }
        private int CorrectValue(int val)
        {
           if (val >= 1 && val <= 100)
                return val;
           if (val < 1)
                return  1;
         
           return  100;
            
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
