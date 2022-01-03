using System;

namespace ShapeInheritence.Modal
{
    class Circle: Shape
    {
        private float _radius;
        private float pi = 3.14f;
        public Circle(int x, int y, float radius, string color): base(x, y, color)
        {
            _radius = radius;
        }

        public float Radius
        {
            get
            {
                return _radius;
            }
        }

        public override double CalculateArea()
        {
            return 2 * pi * _radius;
        }
    }
}
