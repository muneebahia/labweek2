using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5task3product
{
    class Program
    {
        static void Main(string[] args)
        {
            List<product> productlist = new List<product>();
            List<customer> custlist = new List<customer>();
            customer show = customerinput(custlist);
            takeinput(productlist, show);
            bool flag = addData(custlist,show);
            if(flag)
            {
                show.showlist();
            }

        }
        static void takeinput(List<product>productlist,customer show)
        {
            Console.WriteLine("enter the ammount of product he want to buy");
            int ammount =int.Parse( Console.ReadLine());
            for(int i=0;i<ammount;i++)
            {
                Console.WriteLine("Enter the name of the product");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the category of the product");
                string category = Console.ReadLine();
                Console.WriteLine("Enter the price of the product");
                int price =int.Parse( Console.ReadLine());

                product obj = new product(name,category,price);
                show.addproduct(obj);
               


            }
           


        }
        static bool addData(List<customer> custlist,customer show)
        {
            custlist.Add(show);
            return true;
        }
        
        static customer customerinput(List<customer> custlist)
        {
           
                Console.WriteLine("Enter the Name :");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the Adress");
                string adress = Console.ReadLine();
                Console.WriteLine("Enter the contact of the customer");
                int number =int.Parse( Console.ReadLine());
                customer custobj = new customer(name, adress, number);
            return custobj;





        }
    }
}
