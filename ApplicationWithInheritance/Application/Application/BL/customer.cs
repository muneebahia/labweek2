using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.UI;
namespace Application.BL
{
   public class customer:User
    {
        public customer(string name,string password):base(name,password)
        {

        }
        public override string getrole()
        {
            return "Customer";
        }
      

    }
}
