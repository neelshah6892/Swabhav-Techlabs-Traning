using System;
using System.Collections.Generic;
using CustomerListApp.Modal;

namespace CustomerListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();

            Customer c1 = new Customer(1, "Neel", 27);
            //c1.addAddress("Mumbai");

            Customer c2 = new Customer(2, "Kannan", 30);
            c2.addAddress("Pune");

            customers.Add(c1);
            customers.Add(c2);
            foreach (Customer customer in customers)
            {
                PrintDetails(customer);
            }
        }

        static public void PrintDetails(Customer customer)
        {
            Console.WriteLine("Customer Id: " + customer.Id + " Customer Name: " + customer.Name + " Customer Age: " + customer.Age);
            List<String> addresses = customer.Addresses;
            foreach(String address in addresses)
            {
                Console.WriteLine("Customer Address: " + address);
            }
        }
    }
}