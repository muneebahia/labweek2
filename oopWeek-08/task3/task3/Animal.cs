using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
   public class Animal
    {
        
        protected string name;
        public Animal(string name)
        {
            this.name = name;
        }
        public virtual string toString()
        {
            return "Name" + name;
        }
        public virtual void greet()
        {
            Console.WriteLine("Meow");
        }
    }
}
