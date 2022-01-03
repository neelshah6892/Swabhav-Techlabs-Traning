using System;

namespace AccountApp.Modal
{
    class Account
    {
        private string _accountno;
        private string _name;
        private double _balance = 500;

        public Account(string accountno, string name, double balance)
        {
            _accountno = accountno;
            _name = name;
            _balance = balance;
            Console.WriteLine("OBject from 1st");
        }

        public Account(string accountno, string name)
        {
            _accountno = accountno;
            _name = name;
            Console.WriteLine("OBject from 2nd");
        }

        
        public string Accountno
        {
            get
            {
                return _accountno;
            }
            set
            {
                _accountno = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public double Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
            }
        }

        public void Deposit(double amt)
        {
            _balance = _balance + amt;
        }

        public void Withdraw(double amt)
        {
            
            if(_balance >= 500 && _balance - amt >= 500)
            {
                _balance = _balance - amt;
            }
                    
            
        }
    }
}
