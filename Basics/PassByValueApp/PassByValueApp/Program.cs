using System;

namespace PassByValueApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int mark = 100;
            ModifyMark(mark);
            Console.WriteLine(mark.GetHashCode()+": "+mark);
            int[] marks = { 100, 80, 90 };
            ModifyMarks(marks);
            for (int i= 0; i < marks.Length; i++) {
                Console.WriteLine(marks[i]);
            }
            Console.WriteLine(marks.GetHashCode());
        }

        static void ModifyMark(int m)
        {
            m = 0;
        }

        static void ModifyMarks(int[] ms)
        {
            for (int i=0; i < ms.Length; i++)
            {
                ms[i] = 0;
            }
            Console.WriteLine(ms.GetHashCode());
        }
    }
}
