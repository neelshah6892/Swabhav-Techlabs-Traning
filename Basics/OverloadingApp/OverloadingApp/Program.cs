using System;

namespace OverloadingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Print(10);
            Print("Neel");
            Print(10.5f);
            Print(10.55d);
            Print(true);
            Print('#');
        }

        private static int Print(int val)
        {
            Console.WriteLine(val.GetType()+": "+val);
            return val;
        }

        private static string Print(string val)
        {
            Console.WriteLine(val.GetType() + ": " + val);
            return val;
        }

        private static float Print(float val)
        {
            Console.WriteLine(val.GetType() + ": " + val);
            return val;
        }

        private static double Print(double val)
        {
            Console.WriteLine(val.GetType() + ": " + val);
            return val;
        }

        private static bool Print(bool val)
        {
            Console.WriteLine(val.GetType() + ": " + val);
            return val;
        }

        private static char Print(char val)
        {
            Console.WriteLine(val.GetType() + ": " + val);
            return val;
        }
    }
}
