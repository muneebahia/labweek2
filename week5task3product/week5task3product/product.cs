using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5task3product
{
   

    class product
    {
        public string name;
        public string category;
        public int price;
       

        public product(string name,string category, int price)
        {
            this.name = name;
            this.category = category;
            this.price = price;
        }
       
    }
}
