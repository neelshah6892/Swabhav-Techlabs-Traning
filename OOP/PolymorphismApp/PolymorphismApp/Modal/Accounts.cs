using System;

namespace PolymorphismApp.Modal
{
    abstract class Accounts
    {
        private int _accountno;
        private string _name;
        protected float _balance;

        public Accounts(int accountno, string name, float balance)
        {
            _accountno = accountno;
            _name = name;
            _balance = balance;
        }

        public void Deposit(float deposit)
        {
            _balance = _balance + deposit;
        }

        public abstract void Withdraw(float amount);

        public int Accountno
        {
            get
            {
                return _accountno;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public float Balance
        {
            get
            {
                return _balance;
            }
        }
    }
}