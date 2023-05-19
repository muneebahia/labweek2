 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_01.BL.cs;

namespace task_01.UI.cs
{
    class MenuItemUI
    {
        public int printmenu()
        {
            int choice;
            Console.WriteLine(" 1.Add a Menu item");
            Console.WriteLine("2. Show List");
            Console.WriteLine("3.View the Cheapest Item in the menu");
            Console.WriteLine("4.View the Drink’s Menu");
            Console.WriteLine("5.View the Food’s Menu");
            Console.WriteLine("6.Add Order");
            Console.WriteLine("7.Fulfill the Order");
            Console.WriteLine("8.View the Orders’s List");
            Console.WriteLine("9.Total Payable Amount");
            Console.WriteLine("10.Exit");
            Console.WriteLine("Enter your choice:");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
        public MenuItem adminChoice1()
        {
            string name,type;
            int price,amount;
            bool isWorking = false;
            while (isWorking != true)
            {
                Console.WriteLine("Enter the amount of product you want to add:");
                amount = int.Parse(Console.ReadLine());
                for (int i = 0; i < amount; i++)
                {
                    Console.WriteLine("Enter the name of product you want to add:");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter category of Product:");
                    type = Console.ReadLine();
                    Console.WriteLine("Enter price of product:");
                    price = int.Parse(Console.ReadLine());

                    MenuItem item = new MenuItem(name,type, price);
                    return item;

                }
                isWorking = true;
               
            }
/*            Console.WriteLine("Press any key to continue:");
            Console.ReadKey();
            Console.Clear();
*/            return null;

        }

                public  void PrintItemWithLowPrice(string lowPriceProductName)
        {
           
            Console.WriteLine("the name of the product having higest price in the list is:"+ lowPriceProductName);

        }
        public void printDrinkMenu(CoffeeShop obj)
        {
            foreach (MenuItem i in obj.items)
            {
                bool flag = i.CheckDrinkOrFood();
                if (flag == true)
                {
                    Console.WriteLine(i.name);
                }
            }
        }
        public void printFoodMenu(CoffeeShop obj)
        {
                foreach (MenuItem i in obj.items)
                {
                    bool flag = i.CheckDrinkOrFood();
                    if (flag == false)
                    {
                        Console.WriteLine(i.name);
                    }
                }

            }
        public void showlist(List<MenuItem> itemList)
        {
            Console.Clear();
            Console.WriteLine(" Item Name \t Price \t Stock");
            for (int i = 0; i < itemList.Count; i++)
            {
                Console.WriteLine(i + 1 + "\t" + itemList[i].name + "\t" + itemList[i].type + "\t" + itemList[i].price);
            }
            Console.WriteLine("press any key to continue:");
            Console.ReadKey();
        }
        public void printbill(int bill)
        {
            Console.WriteLine("Total Bill is:"+bill);
        }
            public string selected_items(CoffeeShop item)//add items in cart
        {
           

          /*  adminChoice2Viewproduct();*/
            string name;
            int amount;
            bool flag;
           
            Console.WriteLine("Enter the number of product you want to buy");
            amount = int.Parse(Console.ReadLine());
            for (int i = 0; i < amount; i++)
            {

                Console.WriteLine("enter name of product you want to buy:");
                name = Console.ReadLine();
                flag = item.findProduct(name);
                if(flag)
                {
                    return name;

                }


            }
            return null;
        }
        public void FulfillOrder(List<string> cartList,CoffeeShop obj)
        {

            if(cartList.Count<0)
            {
                Console.WriteLine("This item is not available!!!!");
            }
            else if(cartList.Count>0)
            {
                for(int i=0;i<cartList.Count;i++)
                {
                Console.WriteLine("the order="+cartList[i]+"is ready");
                    obj.removeOrder(i);
                }
            }
            Console.Clear();
            Console.ReadKey();
        }
        public void viewcart(List<string> cartList)
        {

            for (int i = 0; i < cartList.Count; i++)
            {
                Console.WriteLine( cartList[i] );
            }
        }
    }
}
