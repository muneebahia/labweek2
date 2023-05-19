using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_01.BL.cs
{
    class CoffeeShop
    { 
        public string nameOfShop;
        public  List<MenuItem> items = new List<MenuItem>();
        public List<string> orders = new List<string>();
        public CoffeeShop(string nameOfShop)
        {
            this.nameOfShop = nameOfShop;
        }

        public CoffeeShop()
        {

        }
        public string CheaperItem()
        {
            string lowPriceProductName = null;
            for (int i = 0; i < items.Count; i++)
            {
                for (int j = i + 1; j < items.Count; j++)
                {
                    if (items[i].price < items[j].price)
                    {
                        lowPriceProductName = items[i].name;
                    }
                    else
                    {
                        lowPriceProductName = items[j].name;
                    }
                }
            }
            return lowPriceProductName;
        }

        public  bool findProduct(string name)
        {
            int price;
           
            foreach (var i in items)
            {
                if (i.name == name)
                {
                    price = i.price;


                    return true;
                }

            }
            return false;
        }
        public  void removeOrder(int x)
        {
           orders.RemoveAt(x);
        }
         public int Calculatebill()
        {
            int price;
            int bill=0;
            foreach (var i in items)
            {
                for(int x=0;x<orders.Count;x++)
                {
                    if (i.name ==orders[x] )
                    {
                        price = i.price;
                        bill = bill + price;

                       
                    }

                }

            }
            return bill;
        }
/*        public int calculatebill()
        {
            int bill = 0;
            int price = findProduct();
            bill = bill + price;
            return bill;
        }
*/
    }
}

