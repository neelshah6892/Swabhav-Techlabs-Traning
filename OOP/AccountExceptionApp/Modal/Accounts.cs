using System;

namespace AccountExceptionApp.Modal
{
    class Accounts
    {
        private int _id;
        private string _name;
        private int _balance;

        public Accounts(int id, string name, int balance)
        {
            _id = id;
            _name = name;
            _balance = balance;
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
                throw new Exception("Balance Insufficent to withdraw amount");
            }
        }
    }
}
