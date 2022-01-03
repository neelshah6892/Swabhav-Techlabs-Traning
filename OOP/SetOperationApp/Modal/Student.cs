using System;

namespace SetOperationApp.Modal
{
    class Student
    {
        private int _rollnumber;
        private string _name;

        public Student(int rollnumber, string name)
        {
            _rollnumber = rollnumber;
            _name = name;
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

        public override bool Equals(object obj)
        {
            var student = obj as Student;
            if (student == null)
            {
                return false;
            }
            return student.RollNumber == _rollnumber && student.Name == _name;
        }

        public override int GetHashCode()
        {
            return RollNumber.GetHashCode() ^ Name.GetHashCode();
        }
    }
}
