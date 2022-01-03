using System;

namespace CustomerListApp.Modal
{
    class CustomerList
    {
        private int _id;
        private string _name;
        private int _age;
        private string _address;

        public CustomerList(int id, string name, int age, string address)
        {
            _id = id;
            _name = name;
            _age = age;
            _address = address;
        }

        public int Id
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

        public int Age
        {
            get
            {
                return _age;
            }
        }

        public string Address
        {
            get
            {
                return _address;
            }
        }
    }
}
