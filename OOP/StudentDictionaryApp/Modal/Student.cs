using System;

namespace StudentDictionaryApp.Modal
{
    class Student
    {
        private int _rollnumber;
        private string _name;
        private int _standard;

        public Student(int rollnumber, string name, int standard)
        {
            _rollnumber = rollnumber;
            _name = name;
            _standard = standard;
        }

        public int RollNumber
        {
            get
            {
                return _rollnumber;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public int Standard
        {
            get
            {
                return _standard;
            }
        }
    }
}
