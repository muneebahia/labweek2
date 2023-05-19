using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopweek5lab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<merit> student = new List<merit>();
            merit obj = new merit();
          

            int option;
            do
            {
                option = choice();
                if (option == 1)
                {
                    Console.Clear();
                    obj= addstudents();
                   


                }
                if (option == 2)
                {
                    
                    Console.WriteLine("merit ="+ obj.Calculatemerit() );
                }
                 if (option == 3)
                 {
                     bool flag = obj.isEligibleforScholorship();
                if(flag)
                {
                    Console.WriteLine("The Student is Eligible for Scholorship");
                }
                else
                {
                    Console.WriteLine("Not Eligible");
                }
              
            }
                if (option == 4)
                {
                    
                   bool flag = addData(student, obj);
                    if (flag)
                    {
                        obj.showstudent();
                    }
                }
            } while (option < 5);
            
        }
        static merit addstudents()
        {
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter rollNo:");
            int rollNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter cgpa:");
            float cgpa = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter fscmarks:");
            float fscmarks =float.Parse( Console.ReadLine());
            Console.WriteLine("Entermatricmarks:");
            float matricmarks = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter ecatmarks:");
            float ecatmarks = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter isHostelite:");
            bool isHostelite =bool.Parse(Console.ReadLine());
            Console.WriteLine("Enter hometown:");
            string hometown = Console.ReadLine();

            
            merit stu = new merit(name,rollNo,cgpa,fscmarks,ecatmarks,matricmarks,hometown, isHostelite);
            return stu;
        }
        static bool addData(List<merit>student ,merit obj)
        {
            student.Add(obj);
            return true;
        }
        static int choice()
        {
            Console.WriteLine("1. Add students");
            Console.WriteLine("2. check merit");
            Console.WriteLine("3. AvailScholorship");
            Console.WriteLine("4.show students");
            Console.WriteLine("Enter your choice:");
            int option=int.Parse(Console.ReadLine());
            return option;
        }
    }
}
