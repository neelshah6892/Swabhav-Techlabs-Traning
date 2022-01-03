using System;

namespace FunctionApp
{
    class Program
    {
        static void Main(string[] numbers)
        {
           PrintNumbers(numbers);
           PrintMax(numbers);
           PrintMin(numbers);
        }

        private static void PrintNumbers(string[] pnums)
        {
            for (int i =0; i<pnums.Length; i++)
            {
                Console.WriteLine(i + ": " + pnums[i]);
            }
        }

        private static void PrintMax(string[] pmax)
        {
            int max = int.Parse(pmax[0]);
            //Console.WriteLine(max);
            for (int i=0; i<pmax.Length; i++)
            {
                if(int.Parse(pmax[i])> max)
                {
                    max = int.Parse(pmax[i]);
                }
            }
            Console.WriteLine(max);
        }

        private static void PrintMin(string[] pmin)
        {
            int min = int.Parse(pmin[0]);
            //Console.WriteLine(min);
            for (int i = 0; i < pmin.Length; i++)
            {
                if (int.Parse(pmin[i]) < min)
                {
                    min = int.Parse(pmin[i]);
                }
            }
            Console.WriteLine(min);
        }
    }
}
