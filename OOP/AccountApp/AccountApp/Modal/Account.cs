using System;

namespace AccountApp.Modal
{
    class Account
    {
        private string _accountno;
        private string _name;
        private double _balance;

        public Account(string accountno, string name, double balance)
        {
            _accountno = accountno;
            _name = name;
            _balance = balance;
            Console.WriteLine("OBject Created");
        }

        public Account(string accountno, string name):this(accountno, name, 500)
        {
             
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
