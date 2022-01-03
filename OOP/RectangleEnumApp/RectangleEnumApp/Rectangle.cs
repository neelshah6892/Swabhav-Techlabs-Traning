using System;

namespace RectangleEnumApp

{
    class Rectangle
    {
        private int width;
        private int height;
        private ColorType color;

        public void SetColor(ColorType pcolor)
        {
            color = pcolor;
        }

        public ColorType GetColor()
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
