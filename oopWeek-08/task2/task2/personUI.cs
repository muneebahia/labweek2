using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{

   public class personUI
    {
      //public static person obj = new person();
        public static void showoutput()
        {
            foreach(person p in personDL.person)
            {
                Console.WriteLine(p.toString());
            }
        }
    }
}
