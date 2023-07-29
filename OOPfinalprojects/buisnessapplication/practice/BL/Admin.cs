using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice.BL
{
    public class Admin:User
    {
        public override string getrole()
        {
            return "Admin";
        }
        public Admin(string name,string password):base(name, password)
        {
        }
       
      //  public Admin() { }
        public override void showList()
        {

        }
    }
}
