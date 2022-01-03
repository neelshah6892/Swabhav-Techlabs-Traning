using System;

namespace SerializationApp.Modal
{
    [Serializable]
    class Student
    {
        int rollno;
        string name;

        public Student(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }
    }
}
