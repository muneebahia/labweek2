using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace csharpproject
{
    class Program
    {
        static void Main(string[] args)
        {
            task1();
            task2();
            task3();
            task4();
            task5();
            task6();
            task7();

            task8();
            task9();
            task10();
            task11();
            task12();
            task13();
            task14();
            task15();
            task16();
            task17();
            task18();
            task19();
            task20();
        }

        static void task1()
        {
            Console.Write("Hello World!!");
            Console.Write("Hello World!!");
            Console.Read();
        }
        static void task2()
        {
            Console.WriteLine("Hello World!!");
            Console.Write("Hello World!!");
            Console.Read();
        }
        static void task3()
        {
            int Variable = 7;
            Console.WriteLine("Value is:");
            Console.Write(Variable);
            Console.ReadKey();
        }
        static void task4()
        {
            String Variable = "I am Muneeba";
            Console.WriteLine("String: ");
            Console.Write(Variable);
            Console.ReadKey();
        }
        static void task5()
        {
            float Variable = 2.2F;
            Console.WriteLine("Decimal: ");
            Console.Write(Variable);
            Console.ReadKey();
        }
        static void task6()
        {
            Char Variable = 'A';
            Console.WriteLine("Character: ");
            Console.Write(Variable);
            Console.ReadKey();
        }
        static void task7()//taking input n string
        {
            String str;
            str = Console.ReadLine();// this function always return the string value
            Console.WriteLine("Enter the string : ");
            Console.WriteLine(str);
            Console.ReadKey();
        }
        static void task8()// taking input in integer from the user
        {
            String str;
            str = Console.ReadLine();
            Console.WriteLine("Enter a integer : ");
            int num = int.Parse(str);
            Console.WriteLine("Value is : ");
            Console.Write(num);
            Console.ReadKey();

        }
        static void task9()// taking input in integer from the user
        {
            String str;
            str = Console.ReadLine();
            Console.WriteLine("Enter the floating point value : ");
            float num = float.Parse(str);
            Console.WriteLine("Floating Value is : ");
            Console.Write(num);
            Console.ReadKey();

        }
        static void task10()
        {
            float length;
            float area;
            String str;
            str = Console.ReadLine();
            Console.WriteLine("Enter length : ");
            length = int.Parse(str);
            area = length * length;
            Console.WriteLine("Area is:");
            Console.Write(area);
            Console.ReadKey();

        }
        static void task11()// taking input in string from the user
        {
            float marks;
            String str;
            str = Console.ReadLine();
            Console.WriteLine("Enter the marks : ");
            marks = float.Parse(str);
            if (marks > 50)
            {
                Console.WriteLine("You are Passed ");
            }
            else
            {
                Console.WriteLine("You are Failed ");
            }
            Console.ReadKey();
        }
        static void task12()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("You are Passed ");
            }
            Console.ReadKey();
        }
        static void task14()
        {
            int num;
            int sum = 0;
            do
            {
                Console.WriteLine("Enter a number : ");
                num = int.Parse(Console.ReadLine());
                sum = sum + num;
            }
            while (num != -1);
            sum = sum + 1;
            Console.WriteLine("the total sum is {0}", sum);
            Console.ReadKey();
        }
        static void task13()
        {
            int num;
            int sum = 0;
            Console.WriteLine("Enter a number : ");
            num = int.Parse(Console.ReadLine());
            while (num != -1)
            {
                sum = sum + num;
                Console.WriteLine("Enter a number : ");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("the total sum is {0}", sum);
            Console.ReadKey();
        }

        static void task15()
        {
            int[] numbers = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter the num {0}", i);
                numbers[i] = int.Parse(Console.ReadLine());

            }
            int largest = -1;
            for (int i = 0; i < 3; i++)
            {
                if (numbers[i] > largest)
                {
                    largest = numbers[i];
                }
            }
            Console.Write("the largest value is: {0}", largest);
            Console.ReadKey();
        }

        static float saved(int age, float price, float toyprice)
        {
            float totalprice = 0;
            float totalpricetoy = 0;
            float totalmoney_saved = 0;
            float money = 0;
            //float x = 1;
            for (int n = 1; n <= age; n = n + 2)
            {
                totalpricetoy = toyprice + totalpricetoy;
            }
            for (int m = 2; m <= age; m = m + 2)
            {
                money = money + 10;
                totalprice = totalprice + money - 1;
            }
            totalmoney_saved = totalpricetoy + totalprice;
            return totalmoney_saved;
        }

        static void task16()
        {
            int age;
            float price;
            float toyprice;
            float result;
            Console.WriteLine("enter age");
            age=int.Parse(Console.ReadLine());
            Console.WriteLine("enter price of washing machine");
            price= float.Parse(Console.ReadLine()); 
            Console.WriteLine("enter price of unit toy");
            toyprice= float.Parse(Console.ReadLine());
            result = saved(age, price ,toyprice);
            if (result > price)
            {
                float savedprice = result - price;
                Console.WriteLine("yes! {0}", savedprice);
            }
            else if (result < price)
            {
                float savedprice = price - result;
                Console.WriteLine("no! {0}" ,savedprice);
            }
            Console.ReadKey();

        }
        static int add(int n1, int n2)
        {
            return n1 + n2;
        }
        static void task17()
        {
            int num1;
            int num2;
            Console.WriteLine("Enter first num : ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second num : ");
            num2 = int.Parse(Console.ReadLine());
            int result = add(num1, num2);
            Console.WriteLine("Sum is {0} ", result);
            Console.ReadKey();
        }
        static void task19()
        {
            string path = "D:\\bootingCsharp\\csharpproject\\text.txt";
            if (File.Exists(path))
            {
                StreamReader variable = new StreamReader(path);
                string Record;
                while ((Record = variable.ReadLine()) != null)
                {
                    Console.WriteLine(Record);
                }
                variable.Close();
            }
            else
            {
                Console.WriteLine("Not Exists");
            }
            Console.ReadKey();
        }
        static void task18()
        {
            string path = "D:\\bootingCsharp\\csharpproject\\text.txt";
            StreamWriter variable = new StreamWriter(path);
            variable.WriteLine("OOPS");
            variable.Flush();
            variable.Close();
            Console.ReadKey();

        }
        static void task20()
        {
            Console.Write("Enter Order Number: ");
            int orderEnter = int.Parse(Console.ReadLine());
            Console.Write("Enter Price: ");
            int priceEnter = int.Parse(Console.ReadLine());
            int[] prices = new int[100];
            int orderFile = 0;
            string name = null;
            task2Read(orderEnter, priceEnter, name, orderFile, prices);
            Console.ReadKey();
        }
        static string parsedata(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int i = 0; i < record.Length; i++)
            {
                if (record[i] == ',' || record[i] == ' ' || record[i] == '[' || record[i] == ']')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[i];
                }
            }
            return item;
        }

        static void task2Read(int orderEnter, int priceEnter, string name, int orderFile, int[] prices)
        {
            int counter = 0;
            string path = "D:\\bootingCsharp\\csharpproject\\text.txt";
            if (File.Exists(path))
            {
                StreamReader filevar = new StreamReader(path);
                string record;
                while ((record = filevar.ReadLine()) != null)
                {
                    name = parsedata(record, 1);
                    orderFile = int.Parse(parsedata(record, 2));


                    if (orderFile >= orderEnter)
                    {
                        for (int i = 0; i < orderFile; i++)
                        {
                            prices[i] = int.Parse(parsedata(record, 4 + i));
                            if (prices[i] >= priceEnter)
                            {
                                counter++;
                            }

                        }
                        if (counter >= orderEnter)
                        {
                            Console.Write("Free Pizza " + name);
                        }

                    }
                }
            }
        }

    }
}