using System;
using SimpleInterfaceApp.Modal;

namespace SimpleInterfaceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DoAllDBOperations(new OrderDB());
            DoAllDBOperations(new CustomerDB());
            DoAllDBOperations(new DepartmentDB());
        }

        static void DoAllDBOperations(ICrud x)
        {
            Console.WriteLine("Doing all Db Operations");
            x.Create();
            x.Read();
            x.Update();
            x.Delete();
        }
    }
}
