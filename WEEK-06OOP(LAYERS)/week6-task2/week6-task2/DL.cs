using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6_task2
{
    internal class DL
    {
        public static List<Muser> userslist = new List<Muser>();
        public static List<products> itemList = new List<products>();

        public static customer obj1 = new customer();
        public static products obj2 = new products();

        public static void AddUserinList(Muser user)
        {
            userslist.Add(user);
        }
        public static void AddproductsinList(products productData)
        {
            itemList.Add(productData);
        }
        public static string checkforSignin(string name, string password)
        {
            // this function check whether the Admin signing in has signed up fisrt or not
            string role = null;

            for (int i = 0; i < userslist.Count; i++)
            {
                if (name == userslist[i].name && password == userslist[i].password)
                {
                    role = userslist[i].role;
                    break;

                }

            }

            return role;
        }
        public static string AdminChoice3ProductofhighPrice()
        {
            string highPriceProductName=null ;
            for (int i = 0; i < itemList.Count; i++)
            {
                for (int j = i + 1; j < itemList.Count; j++)
                {
                    if (itemList[i].price < itemList[j].price)
                    {
                        highPriceProductName = itemList[j].name;
                    }
                    else
                    {
                        highPriceProductName = itemList[i].name;
                    }
                }
            }
            return highPriceProductName;
        }
        public static products findProduct(string name)
        {
            int price;
            string category;
            foreach (var i in itemList)
            {
                if ( i.name==name)
                {
                    price = i.price;
                    category = i.category;
                    products obj = new products(price, category);
                    return obj;
                }
                
            }
            return null;
        }
        public static void removeFromStock(string enteredname, int num)
        {
            //int stock2 = 0;
            foreach (var i in itemList)
            { 
                if (i.name == enteredname)
                {
                    i.stock = i.stock - num;
                }
            }

        }

    }
}
