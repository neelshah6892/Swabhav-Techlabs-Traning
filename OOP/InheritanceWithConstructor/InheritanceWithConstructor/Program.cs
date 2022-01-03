using System;

namespace InheritanceWithConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            new classB();
        }
    }

    class classA
    {
        public classA()
        {
            Console.WriteLine("Inside Class A");
        }
    }

    class classB: classA
    {
        public classB(): base()
        {
            Console.WriteLine("Inside Class B");
        }
    }
}
