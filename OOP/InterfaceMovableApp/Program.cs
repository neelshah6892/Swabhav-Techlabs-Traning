using System;
using InterfaceMovableApp.Modal;

namespace InterfaceMovableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IMovable[] race = new IMovable[3];
            race[0] = new Car();
            race[1] = new Bike();
            race[2] = new Bus();
            StartRace(race);
        }

        static void StartRace(IMovable[] movables)
        {
            Console.WriteLine("Start Race");
            foreach(IMovable moveable in movables)
            {
                moveable.Move();
            }
            Console.WriteLine("End Race");
        }
    }
}
