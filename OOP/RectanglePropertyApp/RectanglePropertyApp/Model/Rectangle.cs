using System;

namespace RectanglePropertyApp.Model
{
    class Rectangle
    {
        private int _width;
        private int _height;
        private int _area;

        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }

        public int Area
        {
            get
            {
                return _area;
            }
            set
            {
                int _are = _width * _height;
                _area = _are;
            }
        }
    }
}
