using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6_task2
{
    class Muser
    {
        public string name;
        public string password;
        public string role;

        public Muser(string name, string password)
        {
            this.name = name;
            this.password = password;
        }
        public Muser(string name, string password, string role)
        {
            this.name = name;
            this.password = password;
            this.role = role;
        }

    }
}
