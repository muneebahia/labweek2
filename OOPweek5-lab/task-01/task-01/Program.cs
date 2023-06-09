using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_01.UI.cs;
using task_01.BL.cs;
using task_01.DL.cs;
namespace task_01
{
    class Program
    {
        static void Main(string[] args)
        {
             string path="products.txt";
            
            MenuItemUI obj =new  MenuItemUI();
            MenuItem item = new MenuItem();
            CoffeeShop obj1 = new CoffeeShop();
            MenuItemDL.readproductdatafromfile(path, obj1);
            int choice;
            do
            {
                choice = obj.printmenu();
                if(choice==1)
                {
                    item= obj.adminChoice1();
                    MenuItemDL.additemInList(item, obj1);
                    MenuItemDL.writeDataInFile(path, obj1.items);
                }
                if (choice == 2)
                {
                    obj.showlist(obj1.items);
                }
                if (choice==3)
                {
                    string cheaperItemName=obj1.CheaperItem();
                    obj.PrintItemWithLowPrice(cheaperItemName);
                }
                if(choice==4)
                {
                    obj.printDrinkMenu(obj1);
                }
                if(choice==5)
                {
                   obj.printFoodMenu(obj1);
                }
                if(choice==6)
                {
                    obj.showlist(obj1.items);
                    string name = obj.selected_items(obj1);
                    MenuItemDL.addInList(name, obj1);

                }
                if (choice == 7)
                {
                    obj.viewcart(obj1.orders);
                }
                if(choice==8)
                {
                    obj.FulfillOrder(obj1.orders,obj1);
                }
                if(choice==9)
                {
                    int bill=obj1.Calculatebill();
                    obj.printbill(bill);
                }
            } while (choice != 10);
        }
    }
}
