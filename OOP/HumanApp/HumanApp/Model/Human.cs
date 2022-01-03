using System;

namespace HumanApp.Model
{
    class Human
    {
        private float _height;
        private float _weight;
        private int _age = 18;
        private string _name;

        public Human(float pheight, float pweight, int page, string pname)
        {
            _height = pheight;
            _weight = pweight;
            _age = page;
            _name = pname;
        }

        public Human(float pheight, float pweight, string pname)
        {
            _height = pheight;
            _weight = pweight;
            _name = pname;
        }

        public float Height
        {
            get
            {
                return _height;
            }
        }

        public float Weight
        {
            get
            {
                return _weight;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public void Eat()
        {
            //w = 10% increase
            float _wei = _weight * 10 / 100;
            _weight = _weight + _wei;
        }

        public void Play ()
        {
            //w = 5% decrease h = 1% increase
            float wei = _weight * 5 / 100;
            _weight = _weight - wei;
            float hei = _height * 1 / 100;
            _height = _height + hei;
        }
    }

    
}
