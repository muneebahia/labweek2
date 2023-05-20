using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_01.BL.cs
{
    class MenuItem
    {
        public string name;
        public string type;
        public int price;
        public MenuItem(string name, string type, int price)
        {
            this.name = name;
            this.type = type;
            this.price = price;

        }
        public MenuItem()
        {

        }
        public bool CheckDrinkOrFood()
        {

            bool flag = false;
            if (type == "Drink")
            {
                flag = true;
            }
            else if (type == "Food")
            {
                flag = false;
            }

            return flag;
        }
    }
}
