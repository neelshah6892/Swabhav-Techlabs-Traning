using System;

namespace WelcomeArgsApp
{
    class Program
    {
        static void Main(string[] names)
        {
            Console.WriteLine("Welcome to C#");
            Console.WriteLine(names.Length);
            /*for (int i=0; i<args.Length; i++)
            {
                Console.WriteLine(i + args[i]);
            }*/
            foreach (string name in names)
            {
                Console.WriteLine("Hello {0}", name);
            }
        }
    }
}
