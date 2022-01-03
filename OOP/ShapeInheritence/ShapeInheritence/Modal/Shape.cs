using System;

namespace ShapeInheritence.Modal
{
    abstract class Shape
    {
        private int _x;
        private int _y;
        private string _color;
        //private float _area;

        public Shape(int x, int y, string color)
        {
            _x = x;
            _y = y;
            _color = color;
        }

        public abstract double CalculateArea();

        public int X
        {
            get
            {
                return _x;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }
        }

        public string Color
        {
            get
            {
                return _color;
            }
        }
    }
}
