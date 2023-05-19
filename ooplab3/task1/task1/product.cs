using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class product
    {
        public product(string name, string category, int stock, int price, int minstock)
        {
            this.name = name;
            this.category = category;
            this.stock = stock;
            this.minstock = minstock;
            this.price = price;
        }
        public string name;
        public string category;
        public int stock;
        public int price;
        public int minstock;

        public void Addproduct()
        {
            Console.WriteLine("name: {0} price:{1} stock:{2} category:{3} minstock:{4}", name, price, stock, category,minstock);
        }
        public void viewAllProducts(List<product> p)
        {
            foreach (product i in p)
            {
                Console.WriteLine(i  + "\t" + p[i].name + "\t" +p[i].price + "\t" + p[i].stock + "\t" + p[i].minstock);
            }

        }
    }
}
