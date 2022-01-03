using System;

namespace InterfaceMovableApp.Modal
{
    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car Moved");
        }
    }
}
