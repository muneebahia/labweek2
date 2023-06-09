using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat M1 = new Cat("Luci");
            Cat M2 = new Cat("Meow");
            Dog D1 = new Dog("Jack");
            Dog D2 = new Dog("Parkar");
          
            AnimalDL.addinlist(M1,M2,D1,D2);

            foreach (Animal p in AnimalDL.A)
            {
                Console.WriteLine(p.toString());
                p.greet();
            }
            Console.ReadKey();

        }
    }
}
