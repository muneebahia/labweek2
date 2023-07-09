using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DL;
using Application.UI;
using Application.BL;
namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            discountDL.readDiscountdatafromfile();
            productDL.readproductdatafromfile();
            int option;
            validations.isLoadData();
           
            Console.ReadKey();
            do
            {
                Console.Clear();
                option = UserUI.takechoice();
                Console.Clear();
                if (option == 1)
                {
                    User user = UserUI.takeinputWithRole();
                    if (user != null)
                    {
                        UserDL.storeDatainlist(user);
                        UserDL.storeDatainfile();
                    }
                }
                else if (option == 2)
                {
                    User user = UserUI.takeinputWithoutRole();
                    if (user != null)
                    {
                        user = UserDL.signin(user);
                        if (user == null)
                        {
                            headersUI.showMsg("invalid user");
                        }
                        else if (user.getrole() == "Admin")
                        {
                            Console.Clear();
                            headersUI.Header("Admin Interface");
                            int choice;
                            do
                            {
                                choice = adminUI.takeadminchoice();
                                if (choice == 1)
                                {
                                    productUI.showlist(productDL.itemList);
                                }
                                else if (choice == 2)
                                {
                                    productUI.add_medicine();
                                }
                                else if (choice == 3)
                                {
                                    productUI.delete_medicine();
                                }
                                else if (choice == 4)
                                {
                                    productUI.update_stock();
                                }
                                else if (choice == 5)
                                {
                                    productUI.search_medicine();
                                }
                                else if (choice == 6)
                                {
                                    discountUI.giveDiscount();
                                }
                                else if (choice == 7)
                                {
                                    UserUI.showAllUsersDetails(UserDL.users);
                                }
                                else if (choice == -1)
                                {
                                    
                                    headersUI.showMsg("Enter valid choice");
                                }

                            } while (choice != 8);
                        }
                        else if (user.getrole()=="Customer") 
                        {
                            Console.Clear();
                            headersUI.Header("Customer Interface");
                            product custobj = null;
                            int choice;
                            do
                            {
                                choice = customerUI.takecustchoice();
                                if (choice == 1)
                                {
                                    productUI.showlist(productDL.itemList);
                                }
                                else if (choice == 2)
                                {
                                    productUI.selected_items(productDL.itemList);
                                }
                                else if (choice == 3)
                                {
                                    productUI.viewCart(customerDL.Cart);
                                }
                                else if (choice == 4)
                                {
                                   
                                    productUI.deletecustmedicine();
                                }
                                else if (choice == 5)
                                {
                                    float bill=customerDL.calculateBill();
                                    float BillWithDiscount=discountDL.finalBillWithDiscount(bill);
                                    discountUI.printBill(BillWithDiscount);
                                }
                                else if (choice == 6)
                                {
                                     discountUI.showdiscountlist();
                                }
                                else if (choice == 7)
                                {
                                     customerUI.change_Password();
                                    UserDL.storeDatainfile();
                                }
                                else if (choice == -1)
                                {
                                    headersUI.showMsg("Enter valid choice");
                                }
                                else if(choice==8)
                                {
                                    productUI.update_customercart();
                                }
                            }
                            while (choice != 9);
                        }
                    }
                }
                else if(option== -1)
                {
                    headersUI.showMsg("Enter valid choice");
                }
                Console.ReadKey();
            }
            while (option < 3);

            }
    }
    }

        

    


