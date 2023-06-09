using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_06_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<hosepipe> hosepipelist =new  List<hosepipe>();
            truck obj = new truck();
            hosepipe truckobj = new hosepipe(hosepipelist);
            obj.fun(truckobj);
           
        }
    }
}
