using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.BL;
using Application.DL;

namespace Application.UI
{
    class discountUI
    {
        public static void giveDiscount()
        {
            Console.Clear();
            headersUI.Header("Discount");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            float discountPrice, discountPercent;
            Console.WriteLine("Enter the bill price on which you want to give discount:");
            if (float.TryParse(Console.ReadLine(), out discountPrice))
            {   Console.WriteLine("Enter the percentage of discount:");
                if (float.TryParse(Console.ReadLine(), out discountPercent))
                {
                    discount obj1 = new discount(discountPrice, discountPercent);
                    discountDL.addInList(obj1);
                    discountDL.writeDiscountDataInFile();
                }
                else
                {
                    Console.WriteLine("stock should be in integer.");
                }
            }
            else
            {
                Console.WriteLine("price should be in integer.");
            }
        }
        public static void showdiscountlist()
        {
            Console.Clear();
            headersUI.Header("Discount");
            Console.Write(" ");
            Console.Write(" ");
            Console.WriteLine(" Sr.No \t DiscountPrice \t DiscountPercent");
            discountDL.discountloop();
            Console.WriteLine("press any key to continue:");
            Console.ReadKey();
        }
        public static void printBill(float finalBill)
        {
            Console.Clear();
            headersUI.Header("Bill");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("the final bill is= " + finalBill);
            int index = discountDL.getIndex();
            Console.WriteLine(discountDL.discounts[index-1].DiscountPercent+" %" + " discount is available at the bill greater than"+" " + discountDL.discounts[index-1].DiscountPrice);
            if(finalBill< discountDL.discounts[index-1].DiscountPrice)
            {
                Console.WriteLine("At that time no discount is available!!!!!");
            }
        }
    }
}
