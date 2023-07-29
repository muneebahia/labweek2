using practice.BL;
using practice.DL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice.BL
{
    public class Customer:User
    {
       
        public Customer(string name, string password) : base(name, password)
        {

        }
        public override string getrole()
        {
            return "Customer";
        }
    }
}

