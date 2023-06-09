using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_06_task1
{
    class fireFighter:Employ
    {
        
        public fireFighter(string name, string adress, int contact) :base(name,adress, contact)
        {
            this.name = name;
        }
    }
}
