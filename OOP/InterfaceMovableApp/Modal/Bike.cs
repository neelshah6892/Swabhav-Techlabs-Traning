using System;

namespace InterfaceMovableApp.Modal
{
    class Bike : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bike Moved");
        }
    }
}
