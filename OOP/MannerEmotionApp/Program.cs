using System;
using MannerEmotionApp.Modal;

namespace MannerEmotionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Man x = new Man();
            Boy y = new Boy();

            AtThePartyHAll(x);
            AtThePartyHAll(y);
            
            //AtTheMovieHAll(x);
            AtTheMovieHAll(y);
            x.Walk();
            y.Play();
        }

        static void AtThePartyHAll(IManners obj)
        {
            Console.WriteLine("At the party");
            obj.Wish();
            obj.Depart();
        }

        static void AtTheMovieHAll(IEmotions obj)
        {
            Console.WriteLine("At Movie HAll");
            obj.Laugh();
            obj.Cry();
        }
    }
}
