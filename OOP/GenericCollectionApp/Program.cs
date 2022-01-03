using System;
using System.Collections.Generic;
using GenericCollectionApp.Modal;

namespace GenericCollectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Lineitem> order = new List<Lineitem>();
            order.Add(new Lineitem(101, "Phone", 2, 18000));
            order.Add(new Lineitem(102, "Laptop", 1, 36000));

            int _totalprice = 0;

            foreach(Lineitem items in order)
            {
                PrintDetails(items);
                _totalprice = _totalprice + items.UnitTotalPrice();
            }
            Console.WriteLine(_totalprice);
        }

        static public void PrintDetails(Lineitem lineItem)
        {
            Console.WriteLine("Product Id: " + lineItem.ID + " Product Name: " + lineItem.ProductName + " Quantity: " + lineItem.Quantity + " Unit Price: " + lineItem.UnitPrice);
            Console.WriteLine("Total Unit Price: " + lineItem.UnitTotalPrice());
        }
    }
}
