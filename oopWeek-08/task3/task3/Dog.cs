using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
   public class Dog:Mammal
    {
        public Dog(string name):base(name)
        {

        }
        public override void greet()
        {
            Console.WriteLine("baooooo");
        }

        public override string toString()
        {
            return "Name" + name;
        }
    }
}
