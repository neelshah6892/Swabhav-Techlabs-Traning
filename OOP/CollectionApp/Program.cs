using System;
using System.Collections;
using CollectionApp.Modal;

namespace CollectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList order = new ArrayList();
            order.Add(new LineItem(1001, "Phone", 1, 18000));
            order.Add(new LineItem(1002, "Laptop", 2, 36000));
            //order.Add("Neel Shah");

            int _totalprice = 0;

            foreach (Object orderitems in order)
            {
                LineItem item = (LineItem)orderitems;
                PrintDetails(item);
                _totalprice = _totalprice + item.TotalUnitPrice;
            }
            Console.WriteLine(_totalprice);
        }

        static public void PrintDetails(LineItem lineItem)
        {
            Console.WriteLine("Product Id: " + lineItem.ID + " Product Name: " + lineItem.ProductName + " Quantity: " + lineItem.Quantity + " Unit Price: " + lineItem.UnitPrice);
            Console.WriteLine("Total Unit Price: " + lineItem.TotalUnitPrice);
        }
    }
}
