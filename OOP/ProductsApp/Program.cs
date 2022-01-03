using System;
using ProductsApp.Modal;
using System.IO;
using System.Text;

namespace ProductsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Products[] productslist = new Products[5];
            productslist[0] = new Products("Mobile", 50000, 10);
            productslist[1] = new Products("Laptop", 80000, 20);
            productslist[2] = new Products("Charger", 1000, 10);
            productslist[3] = new Products("Headphones", 500, 5);
            productslist[4] = new Products("Portable Charger", 3000, 50);
            
            productDetails(productslist);

            double sum = 0;
            foreach(Products product in productslist)
            {
                sum += product.finalPrice;
            }
            Console.WriteLine(sum);
            Console.WriteLine(sum / productslist.Length);

            double temp = productslist[0].Discount;
            foreach (Products product in productslist)
            {
                if (temp < product.Discount)
                    temp = product.Discount;

            }
            Console.WriteLine(temp);

            double temp2 = productslist[0].Discount;
            foreach (Products product in productslist)
            {
                if (temp2 > product.Discount)
                    temp2 = product.Discount;

            }
            Console.WriteLine(temp2);
        }

        private static void productDetails(Products[] productslist)
        {
            using (StreamWriter file = new StreamWriter("Data.txt", append: false))
            {
                Console.WriteLine("ID\tName\t\t\t\tPrice\tDiscount\tFinal Price");
                file.WriteLine("ID\tName\t\t\t\tPrice\tDiscount\tFinal Price");
                foreach (Products product in productslist)
                {
                    string data =  product.ID + "\t" + product.Name + "\t\t\t\t"
                        + product.Price + "\t" + product.Discount + "%\t" + product.finalPrice;

                    Console.WriteLine(data);

                    file.WriteLine(data);
                }
            }
            Console.WriteLine("Average Price: ");
            Console.WriteLine("Max Discount: ");
            Console.WriteLine("Min Dscount: ");
        }
    }
}
