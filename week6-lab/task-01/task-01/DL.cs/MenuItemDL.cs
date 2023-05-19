using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using task_01.BL.cs;
namespace task_01.DL.cs
{
    class MenuItemDL
    {

        CoffeeShop objt = new CoffeeShop();
       public static void writeDataInFile(string path2, List<MenuItem> itemList)
        {
            StreamWriter file = new StreamWriter(path2, false);
            for (int i = 0; i < itemList.Count; i++)
            {
                file.WriteLine(itemList[i].name + "," + itemList[i].type + "," + itemList[i].price);

            }
            file.Flush();
            file.Close();
        }
       public static void additemInList(MenuItem item, CoffeeShop obj1)
        {
            obj1.items.Add(item);
        }
        public static void addInList(string name, CoffeeShop obj1)
        {
            obj1.orders.Add(name);
        }
        public static void readproductdatafromfile(string path2, CoffeeShop obj1)
            {
                StreamReader variable = new StreamReader(path2);
                string record;

            if (File.Exists(path2))
            {
                while ((record = variable.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string name = splittedRecord[0];
                    string type = splittedRecord[1];
                  int price = int.Parse(splittedRecord[2]);
                        MenuItem Item = new MenuItem(name, type, price);
                    additemInList(Item, obj1);
                }

                variable.Close();
            }
            else
            {
                Console.WriteLine("Not Exists");
            }
            Console.ReadKey();
            }

    }
}
