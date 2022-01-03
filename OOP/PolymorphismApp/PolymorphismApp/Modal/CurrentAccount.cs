using System;

namespace PolymorphismApp.Modal
{
    class CurrentAccount: Accounts
    {
        private const int CREDIT_LIMIT = -2000;
        public CurrentAccount(int accountno, string name, float balance) : base(accountno, name, balance)
        {

        }

        public override void Withdraw(float amt)
        {
            if (_balance - amt >= CREDIT_LIMIT)
            {
                _balance = _balance - amt;
            }
        }
    }
}
