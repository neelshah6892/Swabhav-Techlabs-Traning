using System;

namespace MannerEmotionApp.Modal
{
    class Boy : IEmotions, IManners
    {
        public void Cry()
        {
            Console.WriteLine("Boy Cry");
        }

        public void Depart()
        {
            Console.WriteLine("Boy Depart");
        }

        public void Laugh()
        {
            Console.WriteLine("Boy Laugh");
        }

        public void Wish()
        {
            Console.WriteLine("Boy Wish");
        }

        public void Play()
        {
            Console.WriteLine("Boy Play");
        }
    }
}
