using System;

namespace CustomExceptionApp.Modal
{
    class Calculator
    {
        public int Add(int num1, int num2)
        {
            if (num2 < 0 && num1 < 0)
            {
                NewMethod2(num1, num2);
                return num1 + num2;
            }
            else if(num1 < 0)
            {
                NewMethod(num1);
                return num1;
            }
            else if(num2 < 0)
            {
                NewMethod(num2);
                return num2;
            }
            else
            {
                return num1 + num2;
            }

            void NewMethod(int nums)
            {
                throw new NegativeNotSupportedException("Negative number is: " + nums);
            }

            void NewMethod2(int number1, int number2)
            {
                throw new NegativeNotSupportedException("Negative numbers are num1" + number1 + "num2" + number2);
            }
        }

    }
}
