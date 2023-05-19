using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            do
            {
                choice = UI.takechoice();
                if(choice=="1")
                {
                    UI.signup();
                }
                if (choice == "2")
                {
                    UI.signin();
                }
                else
                {
                    Console.ReadKey();
                }

            } while (choice != "3");
        }
    }
}
