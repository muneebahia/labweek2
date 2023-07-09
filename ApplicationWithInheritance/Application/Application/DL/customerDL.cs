using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.BL;
using Application.UI;
namespace Application.DL
{
    class customerDL
    {
        public static List<product> Cart = new List<product>();
        public static void addmedicinesinCustList(product obj)
        {
            Cart.Add(obj);
        }
        public static List<product> cart()
        {
            return Cart;
        }
       public static float calculateBill()
        {
            float finalBill = 0.0f;
            foreach (product i in Cart)
            {
                int bill = i.MedicinePrice * i.Quantity;
                finalBill = finalBill + bill;
            }
            return finalBill;
        }
        public static void deleteMedicine(string deletedMedicine)
        {
                
            foreach(var i in Cart.ToList())
            {
                if(i.MedicineName==deletedMedicine)
                {
                    Cart.Remove(i);
                }
            }

        }
      
   
    }
}
