using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            product product1 = new product();
            Console.WriteLine("enter the name of product");
            product1.name = Console.ReadLine();
            Console.WriteLine("enter the category");
            product1.category = Console.ReadLine();
            Console.WriteLine("enter te price of product");
            product1.price = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the stock of product");
            product1.stock = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the stock of product");
            product1. minstock = int.Parse(Console.ReadLine());
            List<product> p = new List<product>();
            p.Add(product1);
        }
    }
}
