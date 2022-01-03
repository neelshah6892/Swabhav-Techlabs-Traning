using System;

namespace OverrideApp.Modal
{
    class Boy: Man
    {
        public void run()
        {
            Console.WriteLine("Boy Run");
        }
        public void play()
        {
            Console.WriteLine("Boy Play");
        }
        public override void eat()
        {
            Console.WriteLine("Boy Eat");
        }
    }
}
