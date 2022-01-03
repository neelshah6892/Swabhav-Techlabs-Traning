using System;
using System.Collections.Generic;

namespace CustomerListApp.Modal
{
    class Customer
    {
        private int _id;
        private string _name;
        private int _age;
        private List<String> _address = new List<string>{};

        public Customer(int id, string name, int age)
        {
            _id = id;
            _name = name;
            _age = age;
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

        public void addAddress(string address)
        {
            _address.Add(address);
        }

        public List<String> Addresses
        {
            get
            {
                return _address;
            }
        }
    }
}
