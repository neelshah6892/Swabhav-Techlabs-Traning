using System;

namespace MannerEmotionApp.Modal
{
    class Man : IManners
    {
        public void Wish()
        {
            Console.WriteLine("Man Wishes");
        }

        public void Depart()
        {
            Console.WriteLine("Man Depart");
        }

        public void Walk()
        {
            Console.WriteLine("Man Walk");
        }
    }
}
