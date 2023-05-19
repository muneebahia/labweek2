using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6_task2
{
    class products
    {
        public string name;
        public string category;
        public int price;
        public int stock;
        public int minQuantity;
        public string custproductname;
        public int custproductquantity;
        public int bill2;
        
        public products(string name, int price, string category, int stock, int minQuantity)
        {
            this.name = name;
            this.price = price;
            this.category = category;
            this.stock = stock;
            this.minQuantity = minQuantity;
        }
        public products(string custproductname, int custproductquantity, int price,string category)
        {
            this.custproductname = custproductname;
            this.custproductquantity = custproductquantity;
            this.price = price;
            this.category=category;
        }
        public products(int price,string category)
        {
            this.price = price;
            this.category = category;
        }
        public products(int bill)
        {
            this.bill2 = bill;
        }
        public products()
        {

        }
        public float calculateTax()
        {
            float tax;
            if (category == "grocery")
            {
                tax = price * 0.1F;
            }
            else if (category == "fruit")
            {
                tax = price * 0.05F;
            }
            else
            {
                tax = price * 0.1F;
            }
            return tax;
        }


        public string ThresholdProductName()
        {string nameOfProduct=null; 
            if (stock<minQuantity)
            {
                nameOfProduct = name;
            }
            return nameOfProduct;
        }
       
    }

}
