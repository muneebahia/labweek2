using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6_task2
{
    class UI
    {
       public static string takechoice()
        {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine();

            string choice;
            Console.WriteLine("****************************************************************************************** ");
            Console.WriteLine("****************************                                                             * ");
            Console.WriteLine("*********************                                                                    * ");
            Console.WriteLine("**************                                                                           * ");
            Console.WriteLine("*********                                                                                * ");
            Console.WriteLine("*                                      Choose your choice :                              * ");
            Console.WriteLine("*                                      1. for signup:                                    * ");
            Console.WriteLine("*                                      2. for signin:                                    * ");
            Console.WriteLine("*                                      3. Exit                                           * ");
            Console.WriteLine("*                                                                                        * ");
            Console.WriteLine("*                                                               ************************** ");
            Console.WriteLine("*                                                                          *************** ");
            Console.WriteLine("*                                                                                 ******** ");
            Console.WriteLine("****************************************************************************************** ");
            Console.WriteLine("Enter your choice");
            choice = (Console.ReadLine());
            return choice;
        }

       public static int takecustchoice()
        {
            int choice;
            Console.WriteLine("1. View all the products");
            Console.WriteLine("2. Buy the products");
            Console.WriteLine("3. Show Cart");
            Console.WriteLine("4. Generate invoice ");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
       
        



       public static int takeadminchoice()
        {
            int choice;
            Console.WriteLine(" 1. Add Product. ");
            Console.WriteLine("2. View All Products.");
            Console.WriteLine("3. Find Product with Highest Unit Price.");
            Console.WriteLine("4. View Sales Tax of All Products.");
            Console.WriteLine("5. Products to be Ordered. (less than threshold)");
            Console.WriteLine("6. Exit");
            Console.WriteLine("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());
            return choice;

        }
        public static string adminORcustomer()
        {
            string Type;
            Console.Clear();
            

            Console.WriteLine("SignUp:");
            Console.WriteLine("1)As an Admin");
            Console.WriteLine("2)As a Customer");
            Console.Write("Enter choice(Admin or Customer) ");
           Type = Console.ReadLine();

            return Type;

        }
        public static void signup()
        {

            string choice=adminORcustomer();
            Console.Clear();
            if(choice=="Admin" ||choice=="admin")
            {
            Console.Write("Enter username :");
            string adminname = Console.ReadLine();

            Console.Write("Enter Password :");
            string adminpassword = Console.ReadLine();
                Muser adminData = new Muser(adminname, adminpassword,choice);
                DL.AddUserinList(adminData);
                Console.WriteLine("Admin added successfully");

            }
          else  if (choice == "Customer" || choice == "customer")
            {
                Console.WriteLine("Enter your name: ");
                string custname = Console.ReadLine();
                Console.WriteLine("Enter your password: ");
                string custpassword = Console.ReadLine();

                Muser custData = new Muser(custname, custpassword,choice);
                DL.AddUserinList(custData);
                Console.WriteLine("Customer added successfully");


            }

        }

        public static void signin()
        {
            Console.Clear();
          
            string name;
            string password;
            string role;

            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter your password: ");
            password = Console.ReadLine();

            role = DL.checkforSignin(name, password);// this function check whether the Admin signing in had signed up fisrt or not
            if (role == "Admin" || role == "admin")
            {
                int choice1;
                do
                {

                    choice1 = takeadminchoice();
                    if (choice1 == 1)
                    {
                        adminChoice1();

                    }
                    else if (choice1 == 2)
                    {
                        adminChoice2Viewproduct();
                    }
                    else if (choice1 == 3)
                    {
                        adminChoice3HighPrice();
                    }
                    else if (choice1 == 4)
                    {
                        adminChoice4printtax();
                    }

                    else if (choice1 == 5)
                    {
                        printThProducts();
                    }
                } while (choice1 != 6);


            }
            else if (role == "Customer" || role == "customer")
            {
                int choice2;
                do
                {

                    choice2 = takecustchoice();
                    if (choice2 == 1)
                    {
                        adminChoice2Viewproduct();
                    }
                    else if (choice2 == 2)
                    {
                        selected_items();
                       
                    }
                    else if(choice2==3)
                    {
                        customershowlist();
                    }
                    else if (choice2 == 4)
                    {
                        float finalbill=DL.obj1.finalbill();
                        Console.WriteLine("final bill="+finalbill);
                    }

                } while (choice2 != 5);
       
            }
            else
            {
                Console.WriteLine("User does not Exists");
             
            }


        }

        public static void adminChoice1()
        {
            string name, category;
            int price, amount, stock, minQuantity;
            bool isWorking = false;
            while (isWorking != true)
            {
                Console.WriteLine("Enter the amount of product you want to add:");
                amount = int.Parse(Console.ReadLine());
                for (int i = 0; i < amount; i++)
                {
                    Console.WriteLine("Enter the name of product you want to add:");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter category of Product:");
                    category = Console.ReadLine();
                    Console.WriteLine("Enter price of product:");
                    price = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter stock of this product:");
                    stock = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Min Stock Threshold Quantity:");
                    minQuantity = int.Parse(Console.ReadLine());

                    products productData = new products(name, price, category, stock, minQuantity);
                    DL.AddproductsinList(productData);

                }
                isWorking = true;
            }
            Console.WriteLine("Press any key to continue:");
            Console.ReadKey();
            Console.Clear();

        }
        public static void adminChoice2Viewproduct()
        {
            Console.WriteLine("Name" + "\t" + "Price" + "\t" + "Category" + "\t" + "Stock" + "\t" + "Threshold");
            foreach (var i in DL.itemList)
            {
                Console.WriteLine(i.name + "\t" + i.price + "\t" + i.category + "\t" + "\t" + i.stock + "\t" + i.minQuantity);
            }
            Console.WriteLine("Press any key to continue:");
            Console.ReadKey();
            Console.Clear();
        }

        public static void adminChoice3HighPrice()
        {
            string HighPrice = DL.AdminChoice3ProductofhighPrice();
            Console.WriteLine("the name of the product having higest price in the list is:"+ HighPrice);

        }
        public static void adminChoice4printtax()
        {

          
            Console.WriteLine("Name" + "\t" + "Price" + "\t" + "Category" + "\t" + "Tax");
            foreach (products i in DL.itemList)
            {
                Console.WriteLine(i.name + "\t" + i.price + "\t" + i.category + "\t" + i.calculateTax());
            }
        }

        public static void printThProducts()
        {
            foreach (products i in DL.itemList)
            {
                Console.WriteLine("the products to be order:"+ i.ThresholdProductName());
            }

        }
        public static products selected_items()//add items in cart
        {
            Console.Clear();
            
            adminChoice2Viewproduct();
            string name;
            int amount;
            products priceandCategory =null;
            Console.WriteLine("Enter the number of product you want to buy");
            amount = int.Parse(Console.ReadLine());
            for (int i = 0; i < amount; i++)
            {

                Console.WriteLine("enter name of product you want to buy:");
                name = Console.ReadLine();
                priceandCategory = DL.findProduct(name);
               
                
                    Console.WriteLine("enter quantity of product:");
                    int quantity = int.Parse(Console.ReadLine());
                    products obj = new products(name, quantity, priceandCategory.price, priceandCategory.category);
                    DL.obj1.addinCustList(obj);
                    DL.removeFromStock(name, quantity);


            }
            return null;
        }
        public static void customershowlist()
        {
            Console.Clear();
            List<products> cart =DL.obj1.returnProduct();
            Console.WriteLine("Name" + "\t" + "Price" + "\t" + "quantity" );

            foreach (products i in cart)
            {

                Console.WriteLine(i.custproductname+ "\t" + i.price + "\t" + i.custproductquantity);

            }
            Console.WriteLine("press any key to continue:");
            Console.ReadKey();
        }

    }
}

