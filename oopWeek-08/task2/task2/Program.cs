using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            staff obj1 = new staff("muneeba","1qw2","NPS",100000);
            staff obj2 = new staff("tayyba", "1fg2", "wPS", 80000);
            student obj3 = new student("muneeba", "1qw2","CS",2021,1222);
            student obj4 = new student("tayyba", "1fg2","COMs",2022,33333);
            personDL.addinList(obj1, obj2, obj3, obj4);
            personUI.showoutput();
            Console.ReadKey();
        }
    }
}
