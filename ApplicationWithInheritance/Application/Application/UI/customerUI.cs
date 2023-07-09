using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.BL;
using Application.DL;
namespace Application.UI
{
    class customerUI
    {
        public static int takecustchoice()
        {
            int choice;
            Console.WriteLine("1.show list ");
            Console.WriteLine("2.select medicine");
            Console.WriteLine("3.view cart");
            Console.WriteLine("4.delete medicine from cart ");
            Console.WriteLine("5.calculate bill ");
            Console.WriteLine("6.Discount");
            Console.WriteLine("7.Change Password");
            Console.WriteLine("8.Update cart");
            Console.WriteLine("9.press 9 to go back ");
            Console.WriteLine("Enter your choice: ");
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                if (choice > 9 || choice < 0)
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
        public static void change_Password()
        {
            Console.Clear();
            headersUI.Header("Update Password");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Enter old username :");
            string Name = Console.ReadLine();
            Console.Write("Enter old Password :");
            string pass = Console.ReadLine();
            bool isValidNameAndPassword=UserDL.ValidPassword(Name, pass);
            if(isValidNameAndPassword)
            {
                foreach (var i in UserDL.users)
                {
                    if (Name == i.Name && pass == i.Password)
                    {
                        Console.WriteLine("Enter new password");
                        string newpass = Console.ReadLine();
                        i.Password = newpass;
                        break;
                    }     
                }
            }
            else
            {
                Console.WriteLine("Enter Correct Old Name and Password.");
            }
        }
    }
}
