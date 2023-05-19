using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        class information
        {
            public string id;
            public string name;
            public int price;
            public string Category;
            public string Brandname;
            public string Country;
        }
        static int options()
        {
            Console.Clear();
            int choice;
            Console.WriteLine("1. Add Products ");
            Console.WriteLine("2. Show products");
            Console.WriteLine("3. Total store worth ");
            Console.WriteLine("4. Exit ");
            choice = int.Parse(Console.ReadLine());
            return choice;

        }
        static information Addproducts()
        {
            information product = new information();
            Console.WriteLine("Enter the ID of the customer : ");
            product.id = (Console.ReadLine());
            Console.WriteLine("ENTER THE NAME OF STUDENT : ");
            product.name = Console.ReadLine();
            Console.WriteLine("Enter the price of the product : ");
            product.price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Category of the product ");
            product.Category = Console.ReadLine();
            Console.WriteLine("Enter the name of the brand: ");
            product.Brandname = Console.ReadLine();
            Console.WriteLine("Enter the name of country : ");
            product.Country = Console.ReadLine();
            return product;

        }
        static void list(information[] productArry, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("ID: {0}  Name : {0}  Price: {1}  Category: {2}  Brandname: {3}  Country: {4}", productArry[i].id, productArry[i].name, productArry[i].price, productArry[i].Category, productArry[i].Country);

            }
            Console.WriteLine("Press  any key to continue");
            Console.ReadKey();
        }
        static void sum(information[] productArry, int count)
        {
            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum = sum + productArry[i].price;
            }
            Console.WriteLine("The total worth is: {0} ",sum);
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            information[] productArry = new information[50];
            int choice=0;
            int count = 0;
            do
            {
                choice = options();
                if (choice == 1)
                {
                    productArry[count] = Addproducts();
                    count++;
                }
                else if (choice == 2)
                {
                    list(productArry, count);
                }
                else if (choice == 3)
                {
                    sum(productArry, count);
                }
                else if (choice == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("INVALID choice!!!");
                }

            }

            while (choice != 4);
            {
                Console.WriteLine("Enter choice:");
            }

        }
    }
}
    

