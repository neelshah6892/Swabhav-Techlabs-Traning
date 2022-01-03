using System;

namespace EnggCollegeApp.Modal
{
    enum Year
    {
        First,
        Second,
        Third,
    }

    enum Branch
    {
        Computer,
        Mechanical,
        Civil
    }
    class Student: Person
    {
        private string _branch;
        private string _year;
        public Student(int id, string address, string dob, Branch branch, Year year) : base(id, address, dob)
        {
            _branch = Convert.ToString(branch);
            _year = Convert.ToString(year);
        }

        public override string ToString()
        {
            return this.ID + " " + this.Address + " " + this.DOB + " " + this._branch + " " + this._year;
        }
    }
}
