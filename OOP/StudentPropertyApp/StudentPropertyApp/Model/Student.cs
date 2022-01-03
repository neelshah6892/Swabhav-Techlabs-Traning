using System;

namespace StudentPropertyApp.Model
{
    class Student
    {
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value.ToUpper();
                //_name = _name.ToUpper();
            }
        }
    }
}
