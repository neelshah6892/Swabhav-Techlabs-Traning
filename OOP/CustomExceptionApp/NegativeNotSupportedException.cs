using System;
using CustomExceptionApp.Modal;

namespace CustomExceptionApp
{
    class NegativeNotSupportedException : Exception
    {
        private string _errorDetails;

        public NegativeNotSupportedException(string msg): 
            base(String.Format("Negative Value Not Support {0}", msg))
        {
            _errorDetails = msg;
        }

        public string ErrorDetails
        {
            get
            {
                return "Error" + _errorDetails;
            }
        }
    }
}
