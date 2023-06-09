using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
   public class person
    {
      protected  string name;
        protected string adress;
        public person()
        { }
        public person(string name, string adress)
        {
            this.name = name;
            this.adress = adress;
        }
        public string getname()
        {
            return name;
        }
        public string getadress()
        {
            return adress;
        }
        public void setadress(string adress)
        {
            this.adress = adress;
        }
        public virtual string toString()
        {
            return "name" + name + "adress" + adress;
        }
    }
}
