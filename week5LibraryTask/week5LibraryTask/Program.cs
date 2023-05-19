
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5LibraryTask
{
    class Program
    {
        static void Main(string[] args)
        {
            library newobj = new library();
            int choice;
            do
            {
                choice = choices();
                if(choice==1)
                {
                    newobj = takeinput();
                    bool flag = newobj.isAvailable;
                    if(flag)
                    {
                        Console.WriteLine("The Book is Available");
                    }
                    else
                    {
                        Console.WriteLine(" The Book IS Not Available");
                    }

                }
                if(choice==2)
                {
                    Console.WriteLine("The BookMark is:"+ newobj.BookMarks);
                   
                }
                if(choice==3)
                {

                   AddChapters(newobj);
                    int chapterNo = chapternoinput();
                    string name=newobj.checkChapterNo(chapterNo);
                    Console.WriteLine("the Name of the Chapter is:"+name);
                }

            } while (choice < 5);
          

        }
        static library takeinput()
        {
            string Author = "Muneeba";
            int Pages = 5000;
            int BookMarks = 1000;
            int Price = 2000;
            bool isAvailable = true;
            library author = new library(Author, Pages, BookMarks, Price, isAvailable);
            return author;
        }
        static int choices()
        {

            Console.WriteLine("1. Book status(Available or Not)");
            Console.WriteLine("2. Book mark");
            Console.WriteLine("3. To Check the Name of Specific Chapter");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter Your Choice :");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
        static void AddChapters(library obj)
        {
            
            Console.WriteLine("Enter the num of chapters:");
            int numchap = int.Parse(Console.ReadLine());
            for (int i = 0; i < numchap; i++)
            {
                Console.WriteLine("Enter the name of the chapter");
                string name = Console.ReadLine();
                obj.addinlist(name);
            }
            Console.ReadKey();
        }
        static int chapternoinput()
        {
            Console.WriteLine("Enter the number of the Chapter Whose Name You Want yo See:");
            int chapterNo =int.Parse( Console.ReadLine());
            return chapterNo;
        }

    }
}
