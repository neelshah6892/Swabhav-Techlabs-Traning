using System;

namespace InsufficientFundsExceptionApp.Modal
{
    class InsufficientFundsException : Exception
    {
        private Account _account;
        private string _message;
        public InsufficientFundsException(Account account)
        {
            _account = account;
            _message = "Transaction failed for " + _account.AccountNumber + " " + _account.Name + " where balance is " + _account.Balance;
        }

        public override string Message
        {
            get
            {
                return _message;
            }
        }
    }
}
