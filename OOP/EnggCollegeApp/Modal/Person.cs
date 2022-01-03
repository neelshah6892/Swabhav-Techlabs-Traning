using System;

namespace EnggCollegeApp.Modal
{
    class Person
    {
        private int _id;
        private string _address;
        private string _dob;

        public Person(int id, string address, string dob)
        {
            _id = id;
            _address = address;
            _dob = dob;
        }

        public int ID
        {
            get
            {
                return _id;
            }
        }

        public string Address
        {
            get
            {
                return _address;
            }
        }

        public string DOB
        {
            get
            {
                return _dob;
            }
        }
    }
}
