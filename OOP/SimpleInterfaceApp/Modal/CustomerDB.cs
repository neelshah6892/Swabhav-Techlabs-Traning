using System;

namespace SimpleInterfaceApp.Modal
{
    class CustomerDB : ICrud
    {
        public void Create()
        {
            Console.WriteLine("Customer Created");
        }

        public void Delete()
        {
            Console.WriteLine("Customer Deleted");
        }

        public void Read()
        {
            Console.WriteLine("Customer Read");
        }

        public void Update()
        {
            Console.WriteLine("Customer Updated");
        }
    }
}
