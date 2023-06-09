using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
  public  class Mammal:Animal
    {
        public Mammal(string name):base(name)
        {

        }
        public override string toString()
        {
            return "Name" + name;
        }
        public override void greet()
        {
            Console.WriteLine("Meow");
        }
    }
}
