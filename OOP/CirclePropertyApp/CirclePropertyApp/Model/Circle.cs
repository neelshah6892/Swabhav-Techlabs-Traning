using System;

namespace CirclePropertyApp.Model
{
    class Circle
    {
        private float _pi = 3.14f;
        private float _raduis;
        private float _area;

        public float Radius
        {
            get
            {
                return _raduis;
            }
            set
            {
                _raduis = value;
            }
        }

        public float Area
        {
            get
            {
                return _area;
            }
            set
            {
                _area = 2 * _raduis * _pi;
            }
        }
    }
}
