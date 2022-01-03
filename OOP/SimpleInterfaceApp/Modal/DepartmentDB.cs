using System;

namespace SimpleInterfaceApp.Modal
{
    class DepartmentDB : ICrud
    {
        public void Create()
        {
            Console.WriteLine("Department Created");
        }

        public void Delete()
        {
            Console.WriteLine("Department Deleted");
        }

        public void Read()
        {
            Console.WriteLine("Department Read");
        }

        public void Update()
        {
            Console.WriteLine("Department Updated");
        }
    }
}
