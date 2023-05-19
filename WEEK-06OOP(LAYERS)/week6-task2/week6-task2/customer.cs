using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6_task2
{
    class customer
    {
        public static List<products> cart = new List<products>();
        public static List<products> billlist = new List<products>();

        public void addinCustList(products obj)
        {
            cart.Add(obj);

        }
        public customer()
        {

        }
        public static void AddbillinList(products bill)
        {
            billlist.Add(bill);
        }


        public List<products> returnProduct()
        {
            return cart;
        }
        public float calculatebill()
        {
            float finalBill = 0;
            foreach (products i in cart)
            {
               int bill = i.price * i.custproductquantity;
                products obj = new products(bill);
                AddbillinList(obj);
                finalBill = finalBill + bill;
            }
            return finalBill;


        }
        public float finalbill()
        {
            float bill = calculatebill();
            Console.WriteLine("totalbill="+bill);
            float tax = calculatecustTax();
            Console.WriteLine("total tax="+tax);
            float finalbill = bill - tax;
            return finalbill;
        }
        public float calculatecustTax()
        {
            float tax;
            float totaltax = 0;
            foreach (var i in cart)
            {
                if (i.category == "grocery")
                {
                    tax =i. billlist.bill2 * 0.1F;
                }
                else if (i.category == "fruit")
                {
                    tax = billlist[i].bill2 * 0.05F;
                }
                else
                {
                    tax = billlist[i].bill2 * 0.1F;
                }
                totaltax = totaltax + tax;


            }
            return totaltax;
        }


    }
}
