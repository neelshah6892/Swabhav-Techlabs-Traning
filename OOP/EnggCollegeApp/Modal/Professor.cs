using System;

namespace EnggCollegeApp.Modal
{
    class Professor: Person, SalariedEmployee
    {
        private int _salary;
        public Professor(int id, string address, string dob, int salary): base(id, address, dob)
        {
            _salary = salary;
        }

        public int Salary
        {
            get
            {
                return _salary;
            }
        }
        public int AnnualSalary()
        {
            return _salary * 12;
        }

        public override string ToString()
        {
            return this.ID + " " + this.Address + " " + this.DOB + " " + this.Salary + " " + this.AnnualSalary();
        }
    }
}
