using System;

namespace StructClassDifferenceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //structures are value type and classes are refrences type.
            //value types are stored in stack
            //refrence types are stored in heap, stack will store address of the heap

            //classes are used for large amount of data
            //structs are used for small amount of data

            //classes are inherited, structs are not

            //struct cannot be null, cant have destructor, can't be abstract

            MySturct s1 = new MySturct();
            MySturct s2 = new MySturct();

            MyClass c1 = new MyClass();
            MyClass c2 = new MyClass();

            s1.FirstName = "Neel";
            s2.FirstName = "Neel";
            s1.LastName = "Shah";
            s2.LastName = "Shah";

            if (s1.Equals(s2))
            {
                Console.WriteLine("s1 = s2");
            }
            else
            {
                Console.WriteLine("s1 != s2");
            }

            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s2.GetHashCode());

            c1.FirstName = "Neel";
            c2.FirstName = "Neel";
            c1.LastName = "Shah";
            c2.LastName = "Shah";

            if (c1.Equals(c2))
            {
                Console.WriteLine("c1 = c2");
            }
            else
            {
                Console.WriteLine("c1 != c2");
            }

            Console.WriteLine(c1.GetHashCode());
            Console.WriteLine(c2.GetHashCode());
        }
    }

    //struct cannot contain parameter less constructor
    /*struct MeStruct
    {
        private MeStruct()
        {

        }
    }*/
    class MeClass
    {
        private MeClass()
        {

        }
    }


    //A static constructor is triggered in the case of a class but not in the case of a structure
    struct MySturct
    {
        //Fields can't be directly instantiated within structures but classes allow such operations
        //public string x = "2";
        public string FirstName;
        public string LastName;
        static MySturct()
        {
            Console.WriteLine("This is struct");
        }
    }

    class MyClass
    {
        public string x = "2";
        public string FirstName;
        public string LastName;
        static MyClass()
        {
            
            Console.WriteLine("This is class");
        }
    }

    

}