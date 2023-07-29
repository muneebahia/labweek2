using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using practice.BL;
namespace practice.DL
{
    class discountDL
    {
        public static List<discount> discounts = new List<discount>();
        public static string path3 = "discount.txt";
        public static void addInList(discount obj)
        {
            discounts.Add(obj);
        }
        public static void writeDiscountDataInFile()
        {
            StreamWriter file = new StreamWriter(path3, false);
            for (int i = 0; i < discounts.Count; i++)
            {
                file.WriteLine(discounts[i].DiscountPrice + "," + discounts[i].DiscountPercent );

            }
            file.Flush();
            file.Close();
        }
        public static void readDiscountdatafromfile()
        {

            if (File.Exists(path3))
            {
                StreamReader variable = new StreamReader(path3);
                string record;
                while ((record = variable.ReadLine()) != null)
                {
                    if (record == "" || record == " ")
                    {
                        continue;
                    }
                    
                    if (int.TryParse(record.Split(',')[0], out int discountPrice) && int.TryParse(record.Split(',')[1], out int discountPercent))
                    {
                        discount obj = new discount(discountPrice, discountPercent);
                        discounts.Add(obj);
                    }
                    else
                    {
                        MessageBox.Show("Enter Valid Input!!!!");
                    }
                    

                }
                variable.Close();
            }
            else
            {
                MessageBox.Show("File Not Exists!!!");
            }
           
        }
        public static void discountloop()
        {
            int k = 1;
            foreach (var i in discounts)
            {
                Console.WriteLine(k + "\t" + i.DiscountPrice + "\t" + i.DiscountPercent);
                k++;
            }
        }
        public static float finalBillWithDiscount(float bill)
        {
            float totalBill = 0;
            float  discount;
            //Console.WriteLine( "Bahir wala Bill" + bill);
            int index= getIndex();
            float price = discountDL.discounts[index - 1].DiscountPrice;
            float percent = discountDL.discounts[index - 1].DiscountPercent;
            if (bill >=price)
                    {
                   // Console.WriteLine("discount percent/100:" + discount);
                    discount = bill * (percent / 100);
                   // Console.WriteLine("discount percent:"+ discount1);
                     totalBill = bill - discount;
                   // Console.WriteLine("totalBill:"+totalBill +"Bill:"+bill);
                    }
                    else
                    {
                   // Console.WriteLine("2222222222222");
                     totalBill = bill;
                    }
                
            return totalBill;
        }
        /*public static List<discount> getDiscountRow()
        {
            return discounts.Count;

        }*/
        public static int getIndex()
        {
            int index = discountDL.discounts.Count;
            return index;
        }
    }
}
