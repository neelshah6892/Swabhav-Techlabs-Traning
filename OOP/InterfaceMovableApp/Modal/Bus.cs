using System;

namespace InterfaceMovableApp.Modal
{
    class Bus : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bus Moved");
        }
    }
}
