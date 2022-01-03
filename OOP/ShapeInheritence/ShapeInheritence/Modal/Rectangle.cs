using System;
using ShapeInheritence;

namespace ShapeInheritence.Modal
{
    class Rectangle: Shape
    {
        private int _length;
        private int _breadth;

        public Rectangle(int x, int y, int length, int breadth, string color):base(x, y, color)
        {
            _length = length;
            _breadth = breadth;
        }

        public int Length
        {
            get
            {
                return _length;
            }
        }

        public int Breadth
        {
            get
            {
                return _breadth;
            }
        }

        public override double CalculateArea()
        {
            return _length * _breadth;
        }
    }
}
