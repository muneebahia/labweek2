using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5task3product
{
  
        class customer
        {
            public string name;
            public int number;
            public string adress;
            public List<product> products = new List<product>();
            public customer(string name, string adress, int number)
            {
                this.name = name;
                this.number = number;
                this.adress = adress;
            }
        public void addproduct(product obj)
        {
            products.Add(obj);

        }
        public List<product> getAllProducts()
        {
            return products;
        }
        public void showlist()
        {
            for(int i=0;i<products.Count;i++)
            {
                Console.WriteLine(products[i].name+ " " + products[i].category+ " " + products[i].price);
            }
            Console.ReadKey();
        }

    }
    
}
