using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.BL;
using Application.DL;
namespace Application.UI
{
    class UserUI
    {
        public static int takechoice()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();

            int choice;
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
            if(int.TryParse(Console.ReadLine(),out choice))
            {
                if(choice>3||choice<0)
                {
                    return -1;
                }
                return choice;
            }
            else
            {
                choice = -1;
                return choice;
            }
        }
        public static User takeinputWithoutRole()
        {
            Console.Clear();
            headersUI.Header("Sign Up");
            Console.WriteLine(" ");
            Console.Write("Enter username :");
            string name = Console.ReadLine();
            Console.Write("Enter Password :");
            string password = Console.ReadLine();
            //validations.
            if (name != null && password != null)
            {
                User user = new User(name, password);
                return user;
            }
            return null;
        }
        public static User takeinputWithRole()
        {
            Console.Clear();
            headersUI.Header("Sign In");
            Console.WriteLine(" ");
            User user = new User();
            bool validname = false;
            bool validPass = false;
            bool specialchar = false;
            int sign;
            Console.WriteLine("sign up as a/an 1. Admin 2. Customer");
            if (int.TryParse(Console.ReadLine(), out sign))
            {
                Console.Write("Enter username :");
                string name = Console.ReadLine();
                validname = validations.validName(name);
                bool conDigit = name.Any(char.IsDigit);
                if (conDigit == false && validname == true)
                {
                    Console.Write("Enter Password :");
                    string password = Console.ReadLine();
                    bool isWhiteSpace = password.Any(char.IsWhiteSpace);
                    validPass = validations.validlengthPassword(password);
                    specialchar = validations.validspecialPassword(password);
                    if (!isWhiteSpace)
                    {
                        if (validPass == true)
                        {
                            if (specialchar == true)
                            {
                                if (name != null && password != null)
                                {
                                    if (sign == 1)
                                    {
                                        user = new admin(name, password);
                                        return user;
                                    }
                                    if (sign == 2)
                                    {
                                        user = new customer(name, password);
                                        return user;
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("password should contain special character....");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Password length must be 8");
                        }

                    }
                    else
                    {
                        Console.WriteLine("No white space allowed!!");
                    }
                }
                else
                {
                    Console.WriteLine("Name cannot take integer or less than 3 char");
                }
            }
            else
            {
                Console.WriteLine("Enter valid choice");
            }
            Console.ReadKey();
            return null;
            }
        public static void showAllUsersDetails(List<User> userList)
        {

            Console.Clear();
            headersUI.Header("All Users Details");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("UserName \t Password \t Role");
            foreach (var i in userList)
            {
                Console.WriteLine(i.Name + "\t" + i.Password + "\t" + i.getrole());
            }

        }
    }

    }

