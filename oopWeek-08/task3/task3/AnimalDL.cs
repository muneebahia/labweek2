using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
   public class AnimalDL
    {
        public static List<Animal> A = new List<Animal>();
        public static void addinlist(Cat c1,Cat c2,Dog d1,Dog d2)
        {
            A.Add(c1);
            A.Add(d2);
            A.Add(d1);
            A.Add(d2);

        }
    }

}
