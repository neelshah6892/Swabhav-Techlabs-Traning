using System;

namespace OverrideApp.Modal
{
    class Man
    {
        public void read()
        {
            Console.WriteLine("Man Read");
        }
        public void play()
        {
            Console.WriteLine("Man Play");
        }
        public virtual void eat()
        {
            Console.WriteLine("Man Eat");
        }
    }
}
