using System;

namespace InsufficientFundsExceptionApp.Modal
{
    class Account
    {
        private int _balance;
        private int _accountNumber;
        private string _name;
        
        public Account(int accountNumber, string name, int balance)
        {
            _accountNumber = accountNumber;
            _name = name;
            _balance = balance;
        }

        public int AccountNumber
        {
            get
            {
                return _accountNumber;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public int Balance
        {
            get
            {
                return _balance;
            }
        }
        public void Withdraw(int amt)
        {

            if (_balance >= 500 && _balance - amt >= 500)
            {
                _balance = _balance - amt;
            }
            else
            {
                throw new InsufficientFundsException(this);
            }
        }

        public void Deposit(int amt)
        {
            _balance = _balance + amt;
        }
    }
}
