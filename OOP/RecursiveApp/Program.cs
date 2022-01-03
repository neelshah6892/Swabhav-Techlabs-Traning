using System;

namespace RecursiveApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Increment();
            Console.WriteLine("End of Program");
        }


        static int count = 0;
        public static void Increment()
        {
            
            if (count <= 9)
            {
                count += 1;
                Console.WriteLine(count);
                Increment();
            }
            
        }
    }
}
