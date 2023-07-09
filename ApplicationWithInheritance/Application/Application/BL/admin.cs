using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.UI;
namespace Application.BL
{
   public class admin: User
    {
        public admin(string name,string password):base(name,password)
        {

        }
        public override string getrole()
        {
            return "Admin";
        }
        

    }
}
