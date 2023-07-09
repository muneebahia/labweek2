using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.BL;
using Application.DL;
namespace Application.UI
{
    class productUI
    {
        public static void showlist(List<product> itemList)
        {
            Console.Clear();
            headersUI.Header("Medicine List");
            Console.Write(" ");
            Console.Write(" ");
            Console.WriteLine(" Sr.No \t Medicine Name \t Price \t Stock");
            // Sort the itemList based on the Price property
            itemList = itemList.OrderByDescending(i => i.MedicinePrice).ToList();
            int k = 1;
            foreach (var i in itemList)
            {
                Console.WriteLine("\t"+k + "\t" + i.MedicineName + "\t" + i.MedicinePrice + "\t" + i.Quantity);
                k++;
            }
            Console.WriteLine("press any key to continue:");
            Console.ReadKey();
        }
        public static void add_medicine()
        {
            Console.Clear();
            headersUI.Header("Add Medicine");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            bool medicineAddedToitemList = false;
            int length, medicinePrice, medicinestock;
            Console.WriteLine("Enter quantity of the Medicin you want to add in your medical store :");
            if (int.TryParse(Console.ReadLine(), out length))
            {
                for (int i = 0; i < length; i++)
                {
                    bool validname = false;
                    Console.WriteLine("Enter Name of Medicin you want to add in your Store :");
                    string medicineName = Console.ReadLine();
                    validname = validations.validName(medicineName);
                    bool conDigit = medicineName.Any(char.IsDigit);

                    if (validname == true)
                    {
                        if(conDigit == false)
                        { 
                            Console.WriteLine("enter the price of that medicine :");
                            if (int.TryParse(Console.ReadLine(), out medicinePrice))
                            {
                                Console.WriteLine("enter the stock of that medicine :");
                                if (int.TryParse(Console.ReadLine(), out medicinestock))
                                {
                                     foreach (var j in productDL.itemList)
                                     {
                                         if (medicineName == j.MedicineName)
                                         {
                                        //  j.MedicinePrice = j.MedicinePrice + medicinePrice;
                                            j.Quantity = j.Quantity + medicinestock;
                                            medicineAddedToitemList = true;
                                            break;
                                         }
                                     }
                                         if (!medicineAddedToitemList)
                                         {
                                           product obj = new product(medicineName, medicinePrice, medicinestock);
                                           productDL.additemInList(obj);
                                         }
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
                        else
                        {
                        Console.WriteLine("Name cannot take integer");
                        }
                    }
                    else
                    {
                       Console.WriteLine("Medicine name should contain at least 3 characters .");
                    }
                }
            }
           else
           {
            Console.WriteLine("Quantity of medicine should be in integer.");
           }
            productDL.writeDataInFile();
            Console.Write("Press any key to continue:");
            Console.ReadKey();
        }
        public static void delete_medicine()
        {
            Console.Clear();
            headersUI.Header("Delete Medicine");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            string deletedMedicine;
            bool isitemFound = false;
            showlist(productDL.itemList);
            Console.WriteLine("enter the name of the product you want to delete :");
            deletedMedicine = Console.ReadLine();
            foreach (var i in productDL.itemList.ToList())
            {
                if (deletedMedicine == i.MedicineName)
                {
                    isitemFound = true;
                    productDL.deleteMedFromList(deletedMedicine);
                }
            }
            if(!isitemFound)
            {
                Console.WriteLine("Item not found!!");
            }
            Console.Write("press any key to continue:");
            Console.ReadKey();
            productDL.writeDataInFile();
        }
        public static void update_stock()
        {
            Console.Clear();
            headersUI.Header("Update Medicine List");
            Console.Write(" ");
            Console.Write(" ");
            int new_price, new_stock;
            bool priceChk = false;
            bool stockChk = false;
            bool isitemFound = false;
            string medicine_name;
            Console.WriteLine("enter the name of the medicine whose price and stock you want to update:");
            medicine_name = Console.ReadLine();
            bool conDigit = medicine_name.Any(char.IsDigit);
            if (conDigit == false)
            {
                foreach (var i in productDL.itemList)
                {
                    if (medicine_name == i.MedicineName)
                    {
                        isitemFound = true;
                        Console.WriteLine("enter the new price of medicine:");
                        if (int.TryParse(Console.ReadLine(), out new_price))
                        {
                            priceChk = true;
                            i.MedicinePrice = new_price;
                        }
                        else if (priceChk == false)
                        {
                            Console.WriteLine("Enter valid input");
                        }
                        Console.WriteLine("enter the new stock of selected medicine:");
                        if (int.TryParse(Console.ReadLine(), out new_stock))
                        {
                            stockChk = true;
                            i.Quantity = new_stock;
                            Console.WriteLine("Item has been updated");
                            
                        }
                        else if (stockChk == false)
                        {
                            Console.WriteLine("Enter valid stock");
                        }
                    }
                }
                if(!isitemFound)
                {
                    Console.WriteLine("item not found");
                }
            }
            else
            {
                Console.WriteLine("name cannot take integers");
            }
            productDL.writeDataInFile();
            Console.Write("press any key to continue:");
            Console.ReadKey();
        }
        public static void update_customercart()
        {
            Console.Clear();
            headersUI.Header("Update Cart");
            Console.Write(" ");
            Console.Write(" ");
            int new_quantity;
            bool quantityChk = false;
            bool isMedicinefound = false;
            string medicine_name;
            Console.WriteLine("enter the name of the medicine whose quantity you want to update:");
            medicine_name = Console.ReadLine();
            foreach (var i in customerDL.Cart)
            {
                if (medicine_name == i.MedicineName)
                {
                    isMedicinefound = true;
                    Console.WriteLine("enter the new quantity of medicine:");
                    if (int.TryParse(Console.ReadLine(), out new_quantity))
                    {
                        quantityChk = true;
                        i.Quantity = new_quantity;
                    }
                    else if (quantityChk == false)
                    {
                        Console.WriteLine("Enter valid input");
                    }
                }
               
            }
            if(!isMedicinefound)
            {
                Console.WriteLine("Medicine not found!!! Enter valid Name of medicine");
            }
        }
        public static void search_medicine()
        {
            Console.Clear();
            headersUI.Header("Search Medicine");
            string search_Medicine;
            Console.WriteLine("enter the name of the Medicin you want to search :");
            search_Medicine = Console.ReadLine();
            bool validName = productDL.checkName(search_Medicine);
            if (validName)
            {
                Console.WriteLine(" Medicine Name \t Price\t Stock ");
                productUI.search(search_Medicine);
            }
            else
            {
                Console.WriteLine("Medicine of this name is not present in Medical store");
            }
        }
        public static void selected_items(List<product> productlist)
        {
            Console.Clear();
            showlist(productlist);
            headersUI.Header("Add To Cart");
            Console.Write(" ");
            Console.Write(" ");
            string medName;
            int productprice = 0;
            bool medicineAddedToCart = false;
            bool isquantityavaiable = false;
            Console.WriteLine("Enter the name of the medicine you want to buy:");
            medName = Console.ReadLine();
            bool validName = productDL.checkName(medName);
            if (validName)
            { 
                Console.WriteLine("Enter the quantity of the medicine:");
                int quantityUser = int.Parse(Console.ReadLine());
                foreach (var i in productlist)
                {
                    if (medName == i.MedicineName)
                    {
                        if (quantityUser <= i.Quantity)
                        {
                            isquantityavaiable = true;
                            i.Quantity = i.Quantity - quantityUser;
                            productprice = i.MedicinePrice;
                            foreach (var j in customerDL.Cart)
                            {
                                if (medName == j.MedicineName)
                                {
                                    j.Quantity = j.Quantity + quantityUser;
                                    medicineAddedToCart = true;
                                    break;
                                }
                            }
                            if (!medicineAddedToCart)
                            {
                                product obj = new product(medName, productprice, quantityUser);
                                customerDL.addmedicinesinCustList(obj);
                            }
                        }
                    }
                }
                if (!isquantityavaiable)
                {
                    Console.WriteLine("Insufficient quantity of selected medicine.");

                }
            }
            else
            {
                Console.WriteLine("Item not found!!!");
            }
            productDL.writeDataInFile();
        }
        public static void viewCart(List<product> cart)
        {
            Console.Clear();
            headersUI.Header("Cart");
            Console.Write(" ");
            Console.Write(" ");
            Console.Write(" ");
            Console.WriteLine(" Medicine Name \t Price \t Quantity");
            cart = cart.OrderByDescending(i => i.MedicinePrice).ToList();
            foreach (product p in cart)
            {
                Console.WriteLine(p.MedicineName + "\t" + p.MedicinePrice + "\t" + p.Quantity);
            }
            Console.WriteLine("press any key to continue:");
            Console.ReadKey();
        }
        public static void deletecustmedicine()
        {
            Console.Clear();
            viewCart(customerDL.Cart);
            headersUI.Header("Delete Medicine");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            string deletedMedicine;
            bool isitempresent = false;
            Console.WriteLine("enter the name of medicine you want to delete :");
            deletedMedicine = Console.ReadLine();
            foreach(var i in customerDL.Cart.ToList())
            {
                if (deletedMedicine==i.MedicineName)
                {
                    isitempresent = true;
                    customerDL.deleteMedicine(deletedMedicine);
                    Console.WriteLine("Item has Deleted!");
                }

            }
            if(!isitempresent)
            {
                Console.WriteLine("item not found");
            }
            Console.Write("press any key to continue:");
            Console.ReadKey();
        }
        public static void search(string search_Medicine)
        {
            for (int i = 0; i < productDL.itemList.Count; i++)
            {
                if (search_Medicine == productDL.itemList[i].MedicineName)
                {
                    Console.WriteLine(search_Medicine + "\t" + productDL.itemList[i].MedicinePrice + "\t " + productDL.itemList[i].Quantity);
                }
            }

        }
    }
}
