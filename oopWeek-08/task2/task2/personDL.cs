using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
   public class personDL
    {
      /*  staff s = new staff();
        student stu = new student();*/
        public static List<person> person = new List<person>();
       
        public static void addinList(staff obj1,staff obj2,student obj3,student obj4)
        {
            person.Add(obj1);
            person.Add(obj2);
            person.Add(obj3);
            person.Add(obj4);

        }
    }
}
