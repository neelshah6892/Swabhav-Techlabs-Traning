using System;

namespace ExceptionGenerationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Int16.Parse(args[0]);
            int b = Int16.Parse(args[1]);
            int c = a / b;

            Console.WriteLine(c);

            //Main(args);

            #region Exceptions Details
            /*System.DivideByZeroException: Attempted to divide by zero.
            at ExceptionGenerationApp.Program.Main(String[] args) in D:\Swabhav\OOP\ExceptionGenerationApp\Program.cs:line 11*/

            /*System.FormatException: Input string was not in a correct format.
            at System.Number.StringToNumber(String str, NumberStyles options, NumberBuffer& number, NumberFormatInfo info, Boolean parseDecimal)
            at System.Number.ParseInt32(String s, NumberStyles style, NumberFormatInfo info)
            at System.Int16.Parse(String s, NumberStyles style, NumberFormatInfo info)
            at System.Int16.Parse(String s)
            at ExceptionGenerationApp.Program.Main(String[] args) in D:\Swabhav\OOP\ExceptionGenerationApp\Program.cs:line 9*/

            /*System.IndexOutOfRangeException: Index was outside the bounds of the array.
            at ExceptionGenerationApp.Program.Main(String[] args) in D:\Swabhav\OOP\ExceptionGenerationApp\Program.cs:line 10*/

            /*System.OverflowException: Value was either too large or too small for an Int16. ---> System.OverflowException: Value was either too large or too small for an Int32.
            at System.Number.ParseInt32(String s, NumberStyles style, NumberFormatInfo info)
            at System.Int16.Parse(String s, NumberStyles style, NumberFormatInfo info)
            --- End of inner exception stack trace ---
            at System.Int16.Parse(String s, NumberStyles style, NumberFormatInfo info)
            at System.Int16.Parse(String s)
            at ExceptionGenerationApp.Program.Main(String[] args) in D:\Swabhav\OOP\ExceptionGenerationApp\Program.cs:line 9*/

            /*Process is terminated due to StackOverflowException.*/
            #endregion
        }
    }
}
