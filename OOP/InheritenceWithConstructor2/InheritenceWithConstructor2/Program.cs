using System;

namespace InheritenceWithConstructor2
{
    class Program
    {
        static void Main(string[] args)
        {
            classB b1 = new classB();
            Console.WriteLine(b1.getFoo());

            classB b2 = new classB(200);
            Console.WriteLine(b2.getFoo());
        }
    }

    class classA
    {
        private int _foo;
        public classA(int foo)
        {
            _foo = foo;
        }
        public int getFoo()
        {
            return _foo;
        }
    }

    class classB: classA
    {
        public classB(): base(100)
        {
            
        }

        public classB(int foo): base(foo)
        {

        }
    }
}
