using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DL;
using Application.BL;
namespace Application.UI
{
    class adminUI
    {
       public static int takeadminchoice()
        {
            int choice;
            Console.WriteLine("1. Check list");
            Console.WriteLine("2. Add the medicine");
            Console.WriteLine("3. Delete medicine");
            Console.WriteLine("4. Update list ");
            Console.WriteLine("5. search specificmedicine");
            Console.WriteLine("6. Give Discount ");
            Console.WriteLine("7. Check Details of customer");
            Console.WriteLine("8. press 8 to go back ");
            Console.WriteLine("Enter your choice: ");
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                if (choice > 8 || choice < 0)
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
    }
}
