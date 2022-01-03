using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeBusinessModelApp.Modal
{
    class Employee
    {
        private int _id;
        private string _name;
        private string _designation;
        private int _departmentid;
        private string _joiningdate;
        private int _salary;
        private string _empty;
        private int _workExperience;

        public Employee(int id, string name, string designation, int departmentid, string joiningdate, int salary, string empty, int workExperience)
        {
            _id = id;
            _name = name;
            _designation = designation;
            _departmentid = departmentid;
            _joiningdate = joiningdate;
            _salary = salary;
            _empty = empty;
            _workExperience = workExperience;
        }

        public Employee(string Employees)
        {

        }

        public int ID
        {
            get
            {
                return _id;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public string Designation
        {
            get
            {
                return _designation;
            }
        }

        public int DepartmentID
        {
            get
            {
                return _departmentid;
            }
        }

        public string JoiningDate
        {
            get
            {
                return _joiningdate;
            }
        }

        public int Salary
        {
            get
            {
                return _salary;
            }
        }

        public string Empty
        {
            get
            {
                return _empty;
            }
        }

        public int WorkExperience
        {
            get
            {
                return _workExperience;
            }
        }


        public int maxSalary()
        {
            return 0;
        }

    }
}
