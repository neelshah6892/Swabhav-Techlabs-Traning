using System;

namespace PolymorphismApp.Modal
{
    class SavingsAccount: Accounts
    {
        private const int MIN_BALANCE= 1000;
        public SavingsAccount(int accountno, string name, float balance):base(accountno, name, balance)
        {

        }

        public override void Withdraw(float amt)
        {
            if (_balance - amt >= MIN_BALANCE)
            {
                _balance = _balance - amt;
            }
        }
    }
}
