using System;

namespace CircleApp
{
    class Circle
    {
        private float pi = 3.14f;
        private float radius;
        private Border borderstyle;

        public Circle(Border pborderstyle, float pradius)
        {
            borderstyle = pborderstyle;
            radius = pradius;
        }

        public Circle(float ppradius)
        {
            radius = ppradius;
        }

        public Border GetBorder()
        {
            return borderstyle;
        }

        public float GetRadius()
        {
            return radius;
        }

        public float Area()
        {
            return pi*radius*2;
        }
    }
}
